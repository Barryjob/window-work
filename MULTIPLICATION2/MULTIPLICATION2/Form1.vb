Public Class Form1

    Private Sub calculatem_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatem_txt.Click
        Dim first_nom, second_nom, resultm As Double

        first_nom = first_nom_txt.Text
        second_nom = second_nom_txt.Text
        resultm = first_nom * second_nom
        resultm_txt.Text = resultm
    End Sub

    Private Sub first_nom_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If first_nom_txt.Text.Contains(".") Then
            second_nom_txt.Enabled = False
        End If
    End Sub

    Private Sub first_nom_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub

    Private Sub second_nom_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub

    Private Sub third_nom_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub
End Class
