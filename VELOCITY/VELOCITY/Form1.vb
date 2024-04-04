Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        Dim displacement As Decimal
        Dim time As Decimal
        Dim velocity As Decimal


        displacement = displacement_txt.Text
        time = time_txt.Text
        velocity = displacement / time

        velocity_txt.Text = velocity

        'Console.WriteLine("The velocity is " + velocity.ToString + "m/s")
    End Sub

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click
        velocity_txt.Text = ""
        displacement_txt.Text = ""
        time_txt.Text = ""
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim velocity As Double
        'velocity = velocity_txt.Text
        ' ElseIf ComboBox1.SelectedIndex = "2" Then
        velocity_txt.Enabled = False
        velocity_txt.Text = "?"
        'p1_txt.Enabled = True
    End Sub

    Private Sub displacement_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles displacement_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub time_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time_txt.TextChanged

    End Sub

    Private Sub time_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles time_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub
End Class
