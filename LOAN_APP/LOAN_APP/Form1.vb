Public Class Form1

    Private Sub interest_txt_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interest_txt.Click
        
    End Sub

    Private Sub calculate_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        Dim loan_amount, duration, interest, amount, Repayment, total_interest, total_repayment As Double
      
        loan_amount = loan_amount_txt.Text
        duration = duration_txt.Text
        amount = loan_amount / duration

        For i = 1 To duration

            interest = 0.015 * loan_amount
            Repayment = amount + interest
            loan_amount = loan_amount - amount

            total_interest = total_interest + interest
            total_repayment = total_repayment + Repayment



            list_view_txt.Items.Add(i & "                                                 " & amount & "                                  " & interest & "                                       " & Repayment)

            total_interest_txt.Text = "TOTAL INTEREST: " + total_interest.ToString("N2")
            total_repayment_txt.Text = "TOTAL REPAYMENT: " + total_repayment.ToString("N2")

            ' interest = interest_txt.Text

            'Console.WriteLine("TOTAL INTEREST = " + total_interest.ToString("N2"), ("F2"))
        Next

    End Sub

    Private Sub interest_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interest_txt.TextChanged


       
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        interest_txt.Enabled = False
        interest_txt.Text = "1.5%"
    End Sub

    Private Sub list_view_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_view_txt.SelectedIndexChanged
        list_view_txt.Enabled = False

    End Sub

    Private Sub loan_amount_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles loan_amount_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub duration_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles duration_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub interest_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles interest_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click

    End Sub

    Private Sub loan_amount_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_amount_txt.TextChanged

    End Sub
End Class
