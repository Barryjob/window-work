Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click
        'Dim radius, area As Integer
        radius_txt.Text = ""
        result_txt.Text = ""
    End Sub


    Private Sub calculate_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        Dim pie, radius, area As Double
        radius = radius_txt.Text
        pie = 3.142

        area = pie * radius * radius
        result_txt.Text = area


    End Sub

    Private Sub radius_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles radius_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub
End Class
