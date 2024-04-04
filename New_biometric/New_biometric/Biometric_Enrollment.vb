
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class Biometric_Enrollment_form
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim connstring As String
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim user_id As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Biometric_Enrollment_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        query = "UPDATE user_counter_tab SET counter_value=@counter_value WHERE counter_id=@counter_id"
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
        query = "SELECT counter_value FROM user_counter_tab WHERE counter_id='REG'"
        Command = New MySqlCommand(query, connection)
        Command.Parameters.AddWithValue("@counter_id", counter_value)
        reader = Command.ExecuteReader
        reader.Read()
        counter_value = reader("counter_value")
        connection.Close()

        counter_value = counter_value + 1
        TimeID = Now.ToString("yyyyMMdd")
        Call counter_user(" REG", counter_value)
        user_id = "REG" + TimeID + counter_value.ToString

        '---------------------------INSERTION TO DB-----------------------------------------------------
        connection = New MySqlConnection
        connection.ConnectionString = connstring
        connection.Open()
        query = "INSERT into user_tab (user_id,fullname,email,phone_no,address_location,gender,passport,created_time) VALUES(@user_id,@fullname,@email,@phone_no,@address_location,@gender,@passport,NOW())"
        Command = New MySqlCommand(query, connection)
        Command.Parameters.AddWithValue("@user_id", user_id)
        Command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
        Command.Parameters.AddWithValue("@email", email_txt.Text)
        command.Parameters.AddWithValue("@phone_no", phone_txt.Text)
        command.Parameters.AddWithValue("@address_location", address_txt.Text)
        command.Parameters.AddWithValue("@gender", gender_txt.Text)
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

    Private Sub select_passport_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_passport_btn.Click
        passportimage()
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        Dim response As Integer

        If response = vbYes Then
            Registration()

        End If
    End Sub

End Class