Public Class Form1

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, Label5.Click

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub calculate__txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate__txt.Click
        Dim first_noh, second_noh, third_noh, resulth As Double

        first_noh = first_noh_txt.Text
        second_noh = second_noh_txt.Text
        third_noh = third_noh_txt.Text
        If first_noh > second_noh And first_noh > third_noh Then
            resulth = first_noh
        ElseIf second_noh > first_noh And second_noh > third_noh Then
            resulth = second_noh
        ElseIf third_noh > first_noh And third_noh > second_noh Then
            resulth = third_noh
   
        End If

        resulth_txt.Text = resulth
    End Sub

    Private Sub clear_btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn1.Click
        first_noh_txt.Text = ""
        second_noh_txt.Text = ""
        third_noh_txt.Text = ""
        resulth_txt.Text = ""
    End Sub

    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Me.Close()

    End Sub
End Class
