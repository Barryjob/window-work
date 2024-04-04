Public Class Form1

    Private Sub calculate__txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate__txt.Click
        Dim first_noh, second_noh, resulth As Double

        first_noh = first_noh_txt.Text
        second_noh = second_noh_txt.Text
        If first_noh > second_noh Then
            resulth = first_noh
        Else
            resulth = second_noh
        End If

        resulth_txt.Text = resulth
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        first_noh_txt.Text = ""
        second_noh_txt.Text = ""
        resulth_txt.Text = ""
    End Sub

    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Me.Close()

    End Sub
End Class
