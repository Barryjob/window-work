Public Class Form1
    Dim first_no, second_no, result, oplbn As Double
  
    Private Sub calculate_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        first_no = first_no_txt.Text
        second_no = second_no_txt.Text


        If op_lbn.Text = "+" Then

            result = first_no + second_no
            result_txt.Text = result

        ElseIf op_lbn.Text = "-" Then
            result = first_no - second_no
            result_txt.Text = result

        ElseIf op_lbn.Text = "/" Then
            result = first_no / second_no
            result_txt.Text = result

        ElseIf op_lbn.Text = "*" Then
            result = first_no * second_no
            result_txt.Text = result

        Else

        End If


    End Sub

    Private Sub plus_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus_btn.Click
        op_lbn.Text = "+"

    End Sub

    Private Sub minus_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus_btn.Click
        op_lbn.Text = "-"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub divide_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divide_btn.Click
        op_lbn.Text = "/"
    End Sub

    Private Sub multiply_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiply_btn.Click
        op_lbn.Text = "*"
    End Sub

    Private Sub op_lbn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles op_lbn.Click
        oplbn = op_lbn.Text
        op_lbn.Text = "+"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub result_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        first_no_txt.Text = ""
        second_no_txt.Text = ""
        result_txt.Text = ""
    End Sub
End Class
