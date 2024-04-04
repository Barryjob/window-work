Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles result_txt.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        Dim a, b, c, y, w, v, p, d, k, z, x1, x2 As Double

        a = a_txt.Text
        b = b_txt.Text
        b = c_txt.Text



        y = b * b
        w = 4 * a * c
        p = y - w
        d = Math.Sqrt(p)
        v = -b + d
        k = -b - d
        z = 2 * a

        x1 = v / z
        x2 = k / z

        result_txt.Text = "The root of the equation are: " + x1.ToString + " and " + x2.ToString

    End Sub

    

    Private Sub a_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles a_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub

    Private Sub b_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles b_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub

    Private Sub c_txt__keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click
        a_txt.Text = ""
        b_txt.Text = ""
        b_txt.Text = ""
    End Sub

    Private Sub a_txt_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_txt.Click
        If a_txt.Text.Contains(".") Then
            a_txt.Enabled = False
        End If
    End Sub

    Private Sub b_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_txt.TextChanged
        If b_txt.Text.Contains(".") Then
            b_txt.Enabled = False
        End If
    End Sub

    Private Sub c_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_txt.TextChanged
        If c_txt.Text.Contains(".") Then
            c_txt.Enabled = False
        End If
    End Sub
End Class
