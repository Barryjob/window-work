Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class log_in_form
    Dim connection As MySqlConnection
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim connstring As String
    Dim query As String
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim DT As New DataTable
    Dim user_id As String



    Private Sub log_in_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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





    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logIn_logIn_btn.Click
        Dim hashcode As Form
        hashcode = New Form
        If email_txt.Text = "" Or password_txt.Text = "" Then
            Dim formodal As New Form
            Dim modal As New Biometric_Enrollment_form
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            messagebox.ShowDialog()
            formodal.Dispose()

        ElseIf validateEmail(email_txt.Text) = False Then
            Dim formodal As New Form
            Dim modal As New Biometric_Enrollment_form
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal
            emailemptyvalidate.ShowDialog()
            formodal.Dispose()

            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        Else
            connection = MyFuctions.GetSqlConnection
            query = "SELECT email, password_hash FROM staff_tab WHERE email=@email AND password_hash=@password_hash"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email", email_txt.Text)
            command.Parameters.AddWithValue("@password_hash", (password_txt.Text))
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                dashboard.Show()
                Me.Hide()
            Else
                Dim formodal As New Form
                Dim modal As New Biometric_Enrollment_form
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.Show()
                modal.Owner = formodal
                Invaliddetail.ShowDialog()
                formodal.Dispose()
            End If
        End If
        ' Me.Show()
        ' MessageBox.Show("Invalid username or Password! Please try again!!")



    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_logIn_btn.Click
        Me.Close()
    End Sub



    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password_txt.UseSystemPasswordChar = True
            CheckBox1.BackgroundImage = My.Resources.eye5
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch
        Else
            password_txt.UseSystemPasswordChar = False
            CheckBox1.BackgroundImage = My.Resources.pngwing_com
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch

        End If
    End Sub

    Private Sub email_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_txt.TextChanged

    End Sub
End Class
