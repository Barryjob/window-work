Public Class Form1

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        Dim first_no, second_no, result As Double
        first_no = first_no_txt.Text
        second_no = second_no_txt.Text
        result = first_no - second_no

        result_txt.Text = result
    End Sub

    Private Sub result_txt_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles result_txt.click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
