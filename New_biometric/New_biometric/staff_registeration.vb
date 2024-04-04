Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class staff_registeration
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim connstring As String
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim user_id As String

    Private Sub staff_registeration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection to database
        connstring = "server=localhost;userid=root;password=;database=biometric_db"
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
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

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sta_reg_exit.Click
        Me.Close()
    End Sub

    Private Sub sta_reg_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sta_reg_close_btn.Click
        Me.Close()
        dashboard.ShowDialog()
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
        query = "SELECT counter_value FROM counter_tab WHERE counter_id='STAFF'"
        Command = New MySqlCommand(query, connection)
        Command.Parameters.AddWithValue("@counter_id", counter_value)
        reader = Command.ExecuteReader
        reader.Read()
        counter_value = reader("counter_value")
        connection.Close()

        counter_value = counter_value + 1
        TimeID = Now.ToString("yyyyMMdd")
        Call counter_user("STAFF", counter_value)
        user_id = "STAFF" + TimeID + counter_value.ToString

        '---------------------------INSERTION TO DB-----------------------------------------------------
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "INSERT into staff_tab (staff_id,fullname,email,phone_no,address_location,staff_role,staff_status,passport,created_time) VALUES(@user_id,@fullname,@email,@phone_no,@address_location,@staff_role,@staff_status,@passport,NOW())"
        Command = New MySqlCommand(query, connection)
        Command.Parameters.AddWithValue("@user_id", user_id)
        Command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
        Command.Parameters.AddWithValue("@email", email_txt.Text)
        command.Parameters.AddWithValue("@phone_no", phone_txt.Text)
        command.Parameters.AddWithValue("@address_location", address_txt.Text)
        command.Parameters.AddWithValue("@staff_role", staff_role_txt.Text)
        command.Parameters.AddWithValue("@staff_status", status_txt.Text)
        Command.Parameters.AddWithValue("@passport", arrimage)
        reader = Command.ExecuteReader
        connection.Close()

        '  Catch ex As Exception
        '  MessageBox.Show("Image Size is too Bigger, Kindly Reduce the Size to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        ' recordcount_label.Text += 1
    End Sub


    '--------------------------- PASSPORT -----------------------------------------------------
    Private Sub passportimage()
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub select_passport_staff_reg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_passport_staff_reg_btn.Click
        passportimage()
    End Sub


    Private Sub submit_staff_reg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_staff_reg_btn.Click

            Registration()


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub staff_role_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staff_role_txt.SelectedIndexChanged

    End Sub
End Class