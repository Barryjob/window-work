Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class autosystem_form
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim connstring As String
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim user_id As String

    Private Sub autosystem_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        home()


        'connection to database
        connstring = "server=localhost;userid=root;password=;database=auto_system"
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        mastercountrecord()
        load_profile_id()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        exitbtn()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

   

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit ?", " exit application",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub okay_delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okay_delete_btn.Click
        Okaypanel()
    End Sub

    Private Sub okay_successful_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okay_successful_btn.Click
       Okaypanel()
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Clear()
    End Sub


    Private Sub autosystem_pnl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles autosystem_pnl.Paint
        Dim fullname, email, phoneno As Char
        fullname = fullname_txt.Text
        email = email_txt.Text
        phoneno = phoneno_txt.Text
    End Sub


    Private Sub fullname_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fullname_txt.TextChanged

        If fullname_txt.Text = "" Then
            fullname_lbl.Visible = True
        Else
            fullname_lbl.Visible = False

        End If

    End Sub

    Private Sub email_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_txt.TextChanged
        If email_txt.Text = "" Then
            email_lbl.Visible = True
        Else
            email_lbl.Visible = False
        End If
    End Sub

    Private Sub phoneno_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phoneno_txt.TextChanged
        If phoneno_txt.Text = "" Then
            phoneno_lbl.Visible = True
        Else
            phoneno_lbl.Visible = False

        End If
    End Sub


    Public Sub counter_user(ByVal counter_id, ByVal counter_value)
        'counter query
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "UPDATE counter_tab SET counter_value=@counter_value WHERE counter_id=@counter_id"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        command.Parameters.AddWithValue("@counter_value", counter_value)
        reader = command.ExecuteReader
        reader.Read()
        connection.Close()
    End Sub


    Private Sub Registration()
        '-----------------------------------INSERT IMAAGE TO DB-----------------------------------
        ' insertion query code

        'allow passport to save
        'passport.Image.Save(mstream, passport.Image.RawFormat)
        Dim arrimage
        Dim mstream As New System.IO.MemoryStream()
        passport.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = mstream.GetBuffer()
        Dim filesize As UInt32
        filesize = mstream.Length
        mstream.Close()

        '--------------------GENERATING ID-------------------------------------------
        Dim counter_value As Integer
        Dim TimeID As String
        ' Dim command As MySqlCommand
        '  Try
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "SELECT counter_value FROM counter_tab WHERE counter_id='USER'"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@counter_id", counter_value)
        reader = command.ExecuteReader
        reader.Read()
        counter_value = reader("counter_value")
        connection.Close()

        counter_value = counter_value + 1
        TimeID = Now.ToString("yyyyMMdd")
        Call counter_user("USER", counter_value)
        user_id = "USER" + TimeID + counter_value.ToString

        '---------------------------INSERTION TO DB-----------------------------------------------------
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "INSERT into user_tab (user_id,fullname,email,phone_no,passport,created_time) VALUES(@user_id,@fullname,@email,@phone_no,@passport,NOW())"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@user_id", user_id)
        command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
        command.Parameters.AddWithValue("@email", email_txt.Text)
        command.Parameters.AddWithValue("@phone_no", phoneno_txt.Text)
        command.Parameters.AddWithValue("@passport", arrimage)
        reader = command.ExecuteReader
        connection.Close()

        '  Catch ex As Exception
        '  MessageBox.Show("Image Size is too Bigger, Kindly Reduce the Size to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        recordcount_label.Text += 1
    End Sub

    Private Sub exitbtn()
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit ?", " exit application",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub mastercountrecord()
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "SELECT count(*) FROM user_tab"
        command = New MySqlCommand(query, connection)
        mastercount_label.Text = command.ExecuteScalar
        connection.Close()
    End Sub


    '----------------------------DELETE BUTTON------------------------------------------------
    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        Dim response As Integer
        If profile_id.Text = "" Then
            MessageBox.Show("Profile ID Can't be Empty!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            response = vbYes
            response = MessageBox.Show("Are you sure you want to delete ?", " delete application",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            succesful_pnl.Hide()
            delete_pnl.Show()
            autosystem_pnl.Hide()
        End If
        delete()
    End Sub

    Private Sub delete()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = connstring
            connection.Open()
            query = "DELETE FROM user_tab WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", profile_id.SelectedValue)
            reader = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        Finally
            'connection.Close()
        End Try
        connection.Close()

    End Sub


    '--------------------------------   FUNCTION BUTTON  ------------------------------------------------

    Private Sub successfulpanel()
        succesful_pnl.Visible = True
        delete_pnl.Visible = False
        ' autosystem_pnl.Visible = False
        menustripe_pnl.Visible = False
        record_pnl.Visible = False
        'save_update_pnl.Visible = False
    End Sub


    Private Sub Okaypanel()
        succesful_pnl.Visible = False
        autosystem_pnl.Visible = True
        menustripe_pnl.Visible = True
        delete_pnl.Visible = False
        record_pnl.Visible = False
        save_update_pnl.Visible = False

    End Sub


    Private Sub recordmenusripe()
        record_pnl.Visible = True
        succesful_pnl.Visible = False
        autosystem_pnl.Visible = False
        delete_pnl.Visible = False
        menustripe_pnl.Visible = False
        save_update_pnl.Visible = False
    End Sub

    Private Sub savedupdatedpanel()
        save_update_pnl.Visible = True
        succesful_pnl.Visible = False
        autosystem_pnl.Visible = False
        delete_pnl.Visible = False
        menustripe_pnl.Visible = False
    End Sub

    Private Sub home()
        delete_pnl.Hide()
        autosystem_pnl.Show()
        menustripe_pnl.Show()
        record_pnl.Hide()
        save_update_pnl.Hide()

        fullname_txt.Text = Nothing
        email_txt.Text = Nothing
        phoneno_txt.Text = Nothing
        profile_id.Text = Nothing
    End Sub

    Private Sub Clear()
        fullname_txt.Text = Nothing
        email_txt.Text = Nothing
        phoneno_txt.Text = Nothing
        profile_id.Text = " "
        passport.Image = Nothing
    End Sub

    Private Sub okay_save_updated_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okay_save_updated_btn.Click
        save_update_pnl.Show()
        autosystem_pnl.Hide()
        delete_pnl.Hide()
        succesful_pnl.Hide()
    End Sub


    Private Sub record_pnl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles record_pnl.Paint
        recordmenusripe()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        home()
    End Sub

    Public Function validateEmail(ByVal emailAddress) As Boolean
        Dim email As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})")
        If email.IsMatch(emailAddress) Then
            Return True
        End If
       
    End Function

    '----------------------------------EXECUTE AND SAVE ------------------------------------------
    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click

        Dim response As Integer
        If fullname_txt.Text = "" Or email_txt.Text = "" Or phoneno_txt.Text = "" Then
            MessageBox.Show("All Fields are Required!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        ElseIf phoneno_txt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phoneno_txt.Text = ""
            phoneno_txt.Focus()
            Exit Sub
        ElseIf passport.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id.SelectedValue = Nothing) Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If response = vbYes Then
                    connection = New MySqlConnection
                    connection.ConnectionString = connstring
                    connection.Open()
                    query = "SELECT count(*) FROM user_tab WHERE email=@email"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@email", email_txt.Text)
                    Dim count As Integer
                    count = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else
                        Registration()
                        successfulpanel()


                    End If
                End If

            Else
                response = MessageBox.Show("Are You Sure You Want to update?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If response = vbYes Then
                    Updated()

                End If
            End If
        End If
    End Sub

    Private Sub Updated()
        'allow passport to save

        Dim msstream As New System.IO.MemoryStream()
        passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()

        query = "UPDATE user_tab SET fullname=@fullname,email=@email,phone_no=@Phone_no,passport=@passport,created_time=NOW() WHERE user_id=@user_id"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@user_id", profile_id.SelectedValue)
        command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
        command.Parameters.AddWithValue("@email", email_txt.Text)
        command.Parameters.AddWithValue("@phone_no", phoneno_txt.Text)
        command.Parameters.AddWithValue("@passport", msstream.ToArray)
        reader = command.ExecuteReader
        connection.Close()
    End Sub
    '---------------------------------PASSPORT ------------------------------------------

    Private Sub passport_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passport_btn.Click
        passportimage()
    End Sub
    Private Sub passportimage()
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub


    '---------------------------------PROFILE ID ------------------------------------------

    Private Sub profile_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_id.Click
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "SELECT * FROM user_tab"
        command = New MySqlCommand(query, connection)
        DT.Load(command.ExecuteReader)
        profile_id.DataSource = DT
        profile_id.DisplayMember = "fullname"
        profile_id.ValueMember = "user_id"
        connection.Close()
    End Sub

    Private Sub load_profile_id()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = connstring
            connection.Open()
            query = "SELECT * FROM user_tab"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                Dim name = reader.GetString("fullname")
                profile_id.Items.Add(name)
            End While
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '---------------------------------    FETCH   ------------------------------------------
    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If profile_id.Text = "" Then
            MessageBox.Show("Profile ID Can't be Empty!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                connection = New MySqlConnection
                connection.ConnectionString = connstring
                connection.Open()
                query = "SELECT * FROM user_tab WHERE user_id=@user_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@user_id", profile_id.SelectedValue)
                reader = command.ExecuteReader
                reader.Read()

                fullname_txt.Text = reader("fullname")
                email_txt.Text = reader("email")
                phoneno_txt.Text = reader("phone_no")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                passport.Image = Image.FromStream(mstream)
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            Finally
                'connection.Close()
            End Try
            connection.Close()
        End If

    End Sub

    '---------------------------------    SECURITY   ------------------------------------------

    Private Sub combobox_press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles profile_id.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field does not accept value", vbInformation)
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("This field does not accept value", vbInformation)
        ElseIf e.KeyChar = "." Then
            e.Handled = True
            MsgBox("This field does not accept value", vbInformation)
        End If
    End Sub

    Private Sub fullname_pres(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullname_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub email_press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email_txt.KeyPress
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("A Dot before letters is not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub phoneno_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phoneno_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECORDToolStripMenuItem.Click
        recordmenusripe()
    End Sub

    Private Sub EXITToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        exitbtn()
    End Sub

 
End Class
