
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class staff_details
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim connstring As String
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim user_id As String

    Private Sub staff_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        query = "UPDATE staff_tab SET fullname=@fullname,email=@email,phone_no=@Phone_no,passport=@passport,created_time=NOW() WHERE staff_id=@staff_id"
        command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@fullname", fullname_txt.Text)
        command.Parameters.AddWithValue("@email", email_txt.Text)
        command.Parameters.AddWithValue("@phone_no", phone_txt.Text)
        command.Parameters.AddWithValue("@passport", msstream.ToArray)
        reader = command.ExecuteReader
        connection.Close()
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


    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub sta_reg_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sta_reg_close_btn.Click
        Me.Close()
    End Sub

   

   

    Private Sub select_passport_staff_reg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_passport_staff_reg_btn.Click
        passportimage()
    End Sub
End Class