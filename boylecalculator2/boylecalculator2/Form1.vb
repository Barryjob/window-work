Public Class Form1
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p1, p2, v2, v1, result, a, b As Double
      

            If p1_txt.Enabled = False Then

                p2 = p2_txt.Text
                v1 = v1_txt.Text
                v2 = v2_txt.Text

                a = p2 * v2
                p1 = a / v1
                result = p1
                result_txt.Text = result

            ElseIf v1_txt.Enabled = False Then

                p1 = p1_txt.Text
                p2 = v1_txt.Text
                v2 = v2_txt.Text

                a = p2 * v2
                v1 = a / p1
                result = v1
                result_txt.Text = result

            ElseIf p2_txt.Enabled = False Then

                p1 = p1_txt.Text
                v1 = v1_txt.Text
                v2 = v2_txt.Text

                b = p1 * v1
                p2 = b / v2
                result = p2
                result_txt.Text = result

            ElseIf v2_txt.Enabled = False Then

                p2 = p2_txt.Text
                v1 = v1_txt.Text
                p1 = v1_txt.Text

                b = p1 * v1
                v2 = b / p2
                result = v2
                result_txt.Text = result
            End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = "0" Then
            p1_txt.Enabled = False
            p1_txt.Text = "?"
            p2_txt.Enabled = True
            v2_txt.Enabled = True
            v1_txt.Enabled = True

        ElseIf ComboBox1.SelectedIndex = "1" Then
            p2_txt.Enabled = False
            p2_txt.Text = "?"
            p1_txt.Enabled = True
            v2_txt.Enabled = True
            v1_txt.Enabled = True


        ElseIf ComboBox1.SelectedIndex = "2" Then
            v1_txt.Enabled = False
            v1_txt.Text = "?"
            p1_txt.Enabled = True
            v2_txt.Enabled = True
            p2_txt.Enabled = True

        ElseIf ComboBox1.SelectedIndex = "3" Then
            v2_txt.Enabled = False
            v2_txt.Text = "?"
            p1_txt.Enabled = True
            p2_txt.Enabled = True
            v1_txt.Enabled = True

        Else
            MsgBox("Choose the right option", vbInformation)


        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        p1_txt.Text = ""
        p2_txt.Text = ""
        v1_txt.Text = ""
        v2_txt.Text = ""
        result_txt.Text = ""

    End Sub

    Private Sub v1_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v1_txt.TextChanged
        If v1_txt.Text.Contains(".") Then
            v1_txt.Enabled = False
        End If
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub p1_txt_keypres(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles p1_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub p2_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles p2_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub v1_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v1_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub v2_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v2_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub p1_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1_txt.TextChanged
        If p1_txt.Text.Contains(".") Then
            p1_txt.Enabled = False
        End If
    End Sub

    Private Sub p2_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2_txt.TextChanged
        If p2_txt.Text.Contains(".") Then
            p2_txt.Enabled = False
        End If
    End Sub

    Private Sub v2_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2_txt.TextChanged
        If v2_txt.Text.Contains(".") Then
            v2_txt.Enabled = False
        End If
    End Sub
End Class
