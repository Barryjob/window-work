Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label3.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub calculate_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        Dim staff_salary As Double
        Dim tax_deducted, tax_rate As Double
        Dim salary_after_deduction As Double

        staff_salary = staff_salary_txt.Text

        tax_rate = tax_rate_txt.Text

        tax_deducted = tax_rate / 100 * staff_salary
        salary_after_deduction = staff_salary - tax_deducted

        'result
        amount_deducted_txt.Text = "AMOUNT DEDUCTED AS TAX (%): " + tax_deducted.ToString("N2")
        stake_home_salary_txt.Text = "SALARY AFTER TAX DEDUCTION (#): " + salary_after_deduction.ToString("N2")
        'Console.WriteLine("Amount Deducted from Salary is #" + tax_deducted.ToString("N2"), ("F2"))
        'Console.WriteLine("Salary After deduction of tax is #" + take_home_salary.ToString("N2"), ("F2"))
    End Sub

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click
        amount_deducted_txt.Text = ""
        stake_home_salary_txt.Text = ""
        staff_salary_txt.Text = ""

        tax_rate_txt.Text = ""
    End Sub

    Private Sub staff_salary_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles staff_salary_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub tax_rate_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tax_rate_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub staff_salary_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staff_salary_txt.TextChanged
        If staff_salary_txt.Text.Contains(".") Then
            staff_salary_txt.Enabled = False
        End If
    End Sub

    Private Sub tax_rate_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tax_rate_txt.TextChanged
        If tax_rate_txt.Text.Contains(".") Then
            tax_rate_txt.Enabled = False
        End If
    End Sub
End Class
