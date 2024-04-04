Public Class Form1

    Private Sub calcukate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcukate_btn.Click
        Dim first_no, second_no, result As Double
        first_no = first_no_txt.Text
        second_no = second_no_txt.Text

        result = first_no + second_no

        result_txt.Text = result

    End Sub

 
    Private Sub second_no_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("Allow only number")
        End If
    End Sub

    
    Private Sub first_no_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub result_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        result_txt.Enabled = False
    End Sub
End Class
