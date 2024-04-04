Public Class loan_app_panel
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim u As Double
    Dim op As String
    Dim n As Int64

    Private Sub scientific_calculator_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scientific_calculator_btn.Click
        home_page_panel.Hide()
        quadratic_equation_pnl.Hide()
        boyles_law_pnl.Hide()
        staff_salary_pnl.Hide()
        simple_calculator_pnl.Hide()
        loan_app_pnl.Hide()
        area_circle_pnl.Hide()
        scientific_calculator_pnl.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_page_btn.Click
        home_page_panel.Show()
        quadratic_equation_pnl.Hide()
        boyles_law_pnl.Hide()
        staff_salary_pnl.Hide()
        simple_calculator_pnl.Hide()
        loan_app_pnl.Hide()
        area_circle_pnl.Hide()
        scientific_calculator_pnl.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quadratic_equation_btn.Click
        home_page_panel.Hide()
        quadratic_equation_pnl.Show()
        boyles_law_pnl.Hide()
        staff_salary_pnl.Hide()
        simple_calculator_pnl.Hide()
        loan_app_pnl.Hide()
        area_circle_pnl.Hide()
        scientific_calculator_pnl.Hide()

    End Sub
    Private Sub clearsc_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearsc_txt.Click
        first_no_txt.Text = ""
        second_no_txt.Text = ""
        resultsc_txt.Text = ""

    End Sub
    'end of simple calculator


    Private Sub staff_salary_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staff_salary_btn.Click
        home_page_panel.Hide()
        quadratic_equation_pnl.Hide()
        boyles_law_pnl.Hide()
        staff_salary_pnl.Show()
        simple_calculator_pnl.Hide()
        loan_app_pnl.Hide()
        area_circle_pnl.Hide()
        scientific_calculator_pnl.Hide()
    End Sub

    Private Sub boyles_law_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boyles_law_btn.Click
        home_page_panel.Hide()
        quadratic_equation_pnl.Hide()
        boyles_law_pnl.Show()
        staff_salary_pnl.Hide()
        simple_calculator_pnl.Hide()
        loan_app_pnl.Hide()
        area_circle_pnl.Hide()
        scientific_calculator_pnl.Hide()
    End Sub

    Private Sub simple_calculator_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simple_calculator_btn.Click
        home_page_panel.Hide()
        quadratic_equation_pnl.Hide()
        boyles_law_pnl.Hide()
        staff_salary_pnl.Hide()
        simple_calculator_pnl.Show()
        loan_app_pnl.Hide()
        area_circle_pnl.Hide()
        scientific_calculator_pnl.Hide()
    End Sub
    Private Sub loan_app_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_app_btn.Click, scientific_calculator_btn.Click
        home_page_panel.Hide()
        quadratic_equation_pnl.Hide()
        boyles_law_pnl.Hide()
        staff_salary_pnl.Hide()
        simple_calculator_pnl.Hide()
        loan_app_pnl.Show()
        area_circle_pnl.Hide()
        scientific_calculator_pnl.Hide()
    End Sub

    Private Sub area_circle_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles area_circle_btn.Click
        home_page_panel.Hide()
        quadratic_equation_pnl.Hide()
        boyles_law_pnl.Hide()
        staff_salary_pnl.Hide()
        simple_calculator_pnl.Hide()
        loan_app_pnl.Hide()
        area_circle_pnl.Show()
        scientific_calculator_pnl.Hide()

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub


    'begining of staff salary
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

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click, clearsc_txt.Click
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

    'end of staff salary

    'begining of quadratic equation
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a, b, c, y, w, v, p, d, k, z, x1, x2 As Double

        a = a_txt.Text
        b = b_txt.Text
        b = c_txt.Text



        y = b * b
        w = 4 * a * c
        p = y - w
        d = Math.Sqrt(p)
        v = -b + d
        k = -b - d
        z = 2 * a

        x1 = v / z
        x2 = k / z

        result_txt.Text = "The root of the equation are: " + x1.ToString + " and " + x2.ToString

    End Sub



    Private Sub a_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles a_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub

    Private Sub b_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles b_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub

    Private Sub c_txt__keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c_txt.KeyPress
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal are allowed")
        End If
    End Sub



    Private Sub a_txt_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a_txt.Click
        If a_txt.Text.Contains(".") Then
            a_txt.Enabled = False
        End If
    End Sub

    Private Sub b_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_txt.TextChanged
        If b_txt.Text.Contains(".") Then
            b_txt.Enabled = False
        End If
    End Sub

    Private Sub c_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c_txt.TextChanged
        If c_txt.Text.Contains(".") Then
            c_txt.Enabled = False
        End If
    End Sub


    Private Sub clear_equation_txt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_equation_txt_btn.Click
        a_txt.Text = ""
        b_txt.Text = ""
        b_txt.Text = ""
    End Sub
    'end of quadratic equation


    'Begining of boyle's law
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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

    Private Sub Combo_boyles_IndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_boyles.SelectedIndexChanged

        If combo_boyles.SelectedIndex = "0" Then
            p1_txt.Enabled = False
            p1_txt.Text = "?"
            p2_txt.Enabled = True
            v2_txt.Enabled = True
            v1_txt.Enabled = True
            p2_txt.Text = ""
            v1_txt.Text = ""
            v2_txt.Text = ""

        ElseIf combo_boyles.SelectedIndex = "1" Then
            p2_txt.Enabled = False
            p2_txt.Text = "?"
            p1_txt.Enabled = True
            v2_txt.Enabled = True
            v1_txt.Enabled = True
            p1_txt.Text = ""
            v1_txt.Text = ""
            v2_txt.Text = ""


        ElseIf combo_boyles.SelectedIndex = "2" Then
            v1_txt.Enabled = False
            v1_txt.Text = "?"
            p1_txt.Enabled = True
            v2_txt.Enabled = True
            p2_txt.Enabled = True
            p1_txt.Text = ""
            p2_txt.Text = ""
            v2_txt.Text = ""

        ElseIf combo_boyles.SelectedIndex = "3" Then
            v2_txt.Enabled = False
            v2_txt.Text = "?"
            p1_txt.Enabled = True
            p2_txt.Enabled = True
            v1_txt.Enabled = True
            p1_txt.Text = ""
            p2_txt.Text = ""
            v1_txt.Text = ""

        Else
            MsgBox("Choose the right option", vbInformation)


        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        p1_txt.Text = ""
        p2_txt.Text = ""
        v1_txt.Text = ""
        v2_txt.Text = ""
        result_txt.Text = ""

    End Sub

    Private Sub v1_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If v1_txt.Text.Contains(".") Then
            v1_txt.Enabled = False
        End If
    End Sub

    ' Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
    'Me.Close()
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staff_salary_btn.Click, boyles_law_btn.Click, quadratic_equation_btn.Click, home_page_btn.Click
    ' Me.WindowState = FormWindowState.Minimized

    'End Sub

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

    'End of boyle's law

    'Begining of simple calculator
    Private Sub calculatesc_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatesc_txt.Click
        Dim first_no, second_no, result As Double
        first_no = first_no_txt.Text
        second_no = second_no_txt.Text


        If op_lbn.Text = "+" Then

            result = first_no + second_no
            resultsc_txt.Text = result

        ElseIf op_lbn.Text = "-" Then
            result = first_no - second_no
            resultsc_txt.Text = result

        ElseIf op_lbn.Text = "/" Then
            result = first_no / second_no
            resultsc_txt.Text = result

        ElseIf op_lbn.Text = "*" Then
            result = first_no * second_no
            resultsc_txt.Text = result



        End If


    End Sub

    Private Sub plus_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus_btn.Click
        op_lbn.Text = "+"

    End Sub

    Private Sub minus_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus_btn.Click
        op_lbn.Text = "-"
    End Sub



    Private Sub divide_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divide_btn.Click
        op_lbn.Text = "/"
    End Sub

    Private Sub multiply_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiply_btn.Click
        op_lbn.Text = "*"
    End Sub

    Private Sub op_lbn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles op_lbn.Click
        Dim oplbn As Double
        oplbn = op_lbn.Text
        op_lbn.Text = "+"
    End Sub


    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles loan_app_pnl.Paint

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   

    Private Sub clear_area_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim radius, area As Integer
        radius_txt.Text = ""
        area_txt.Text = ""
    End Sub


    Private Sub calculatea_area_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pie, radius, area As Double
        radius = radius_txt.Text
        pie = 3.142
        'area = area_txt.text
        area = pie * radius * radius
        area_txt.Text = area


    End Sub

    Private Sub radius_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
            MessageBox.Show("only number and decimal is allowed")
        End If
    End Sub

    Private Sub loan_app_panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub calculate_loan_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_loan_txt.Click
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

            total_interest_txt.Text = "TOTAL INTEREST: " + total_interest.ToString
            total_repayment_txt.Text = "TOTAL REPAYMENT: " + total_repayment.ToString

            ' interest = interest_txt.Text

            'Console.WriteLine("TOTAL INTEREST = " + total_interest.ToString("N2"), ("F2"))
        Next

    End Sub

    Private Sub interest_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interest_txt.TextChanged



    End Sub

    Private Sub loan_app_pnl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles loan_app_pnl.Paint
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

    Private Sub clear_loan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_loan.Click
        loan_amount_txt.Text = ""
        duration_txt.Text = ""
        ' list_view_txt.listbox = ""
        total_interest_txt.Text = ""
        total_repayment_txt.Text = ""
    End Sub


    'scientific calculator

    Private Sub number_btn_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one_btn.Click, two_btn.Click, three_btn.Click, four_btn.Click, five_btn.Click, six_btn.Click, seven_btn.Click, eight_btn.Click, nine_btn.Click, zero_btn.Click
        Dim b As Button = sender
        If scdisplay_result_lbn.Text = "0" Then
            scdisplay_result_lbn.Text = b.Text
        Else
            scdisplay_result_lbn.Text = scdisplay_result_lbn.Text + b.Text
        End If
    End Sub
    Private Sub dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dot_btn.Click
        Dim dp As Button = sender
        If scdisplay_result_lbn.Text = "0" Then
            scdisplay_result_lbn.Text = dp.Text
        Else
            scdisplay_result_lbn.Text = scdisplay_result_lbn.Text + dp.Text
        End If
        If scdisplay_result_lbn.Text.Contains(".") Then
            dot_btn.Enabled = False
        End If
    End Sub

    Private Sub clearsc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearsc_btn.Click
        scdisplay_result_lbn.Text = "0"
        Label3.Text = ""
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        scdisplay_result_lbn.Text = "0"
        Label3.Text = ""

    End Sub

    Private Sub arithmetic_function(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusc_btn.Click, minusc_btn.Click, dividec_btn.Click, mod_btn.Click, exp_btn.Click
        Dim ops As Button = sender
        f = scdisplay_result_lbn.Text
        Label3.Text = scdisplay_result_lbn.Text
        scdisplay_result_lbn.Text = ""
        op = ops.Text
        Label3.Text = Label3.Text + " " + op



    End Sub
    Private Sub arithmetic2_function(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplysc_btn.Click
        Dim ops As Button = sender
        ' u = Label2.Text
        Label3.Text = scdisplay_result_lbn.Text
        scdisplay_result_lbn.Text = ""
        op = ops.Text
        Label3.Text = Label3.Text + " " + op
        If scdisplay_result_lbn.Text.Contains("*") Then
            ' Button14.Enabled = False
            multiply_btn.Enabled = False
            ' Button19.Enabled = False
            'Button24.Enabled = False

        End If


    End Sub

    Private Sub equal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equal_btn.Click
        s = scdisplay_result_lbn.Text
        If op = "+" Then
            a = f + s
            scdisplay_result_lbn.Text = a
            Label3.Text = ""

        ElseIf op = "-" Then
            a = f - s
            scdisplay_result_lbn.Text = a
            Label3.Text = ""

        ElseIf op = "*" Then
            a = f * s
            scdisplay_result_lbn.Text = a
            Label3.Text = ""
        ElseIf op = "/" Then
            a = f / s
            scdisplay_result_lbn.Text = a
            Label3.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            scdisplay_result_lbn.Text = a
            Label3.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            scdisplay_result_lbn.Text = a
            Label3.Text = ""
        Else
            MsgBox("Select a right operation", vbInformation)

        End If

    End Sub

    Private Sub bin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bin_btn.Click
        If Int64.TryParse(scdisplay_result_lbn.Text, n) Then
            scdisplay_result_lbn.Text = Convert.ToString(n, 2)
        Else
            scdisplay_result_lbn.Text = ""
        End If
    End Sub

    Private Sub sin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sin_btn.Click
        a = Math.Sin(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub cos_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cos_btn.Click
        a = Math.Cos(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub tan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tan_btn.Click
        a = Math.Tan(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub log_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log_btn.Click
        a = Math.Log(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit_conversion_combobox.Click
        If unit_conversion_combobox.Text = "Choose One..." Or convt_result_txt.Text = "" Then
            unit_conversion_combobox.Enabled = False
            'MsgBox("Select a Unit of Conversion", vbInformation)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 448
        Me.Width = 260
        equal_btn.Width = 108
        scdisplay_result_lbn.Width = 220
        Label1.Visible = False


        unit_conversion_combobox.Text = "Choose One..."
        unit_conversion_combobox.Items.Add("Celsius to Fahrenheit")
        unit_conversion_combobox.Items.Add("Fahrenheit to Celsius")
        unit_conversion_combobox.Items.Add(" Miles to Kilometers")
        unit_conversion_combobox.Items.Add("Kilometers to Miles")
        'ComboBox1.Items.Add("Centimeters to Meters")


    End Sub

    Private Sub convertuc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertuc_btn.Click
        Dim convt As Double

        If unit_conversion_combobox.Text = "Celsius to Fahrenheit" Then
            convt = (9 / 5 * convt_result_txt.Text) + 32
            convt_Label5.Text = convt & "   Fahrenheit"

        ElseIf unit_conversion_combobox.Text = "Fahrenheit to Celsius" Then
            convt = (5 / 9) * (convt_result_txt.Text - 32)
            convt_Label5.Text = (convt) & "   Celsius"

        ElseIf unit_conversion_combobox.Text = "Kilometers to Miles" Then
            convt = (convt_result_txt.Text / 1.609344)
            convt_Label5.Text = convt & "   Miles"

        ElseIf unit_conversion_combobox.Text = " Miles to Kilometers" Then
            convt = (convt_result_txt.Text * 1.609344)
            convt_Label5.Text = convt & "   kilometers"
        ElseIf unit_conversion_combobox.Text = "Choose One..." Or convt_result_txt.Text = "" Then
            MsgBox("Select a Unit of Conversion", vbInformation)
        Else
            MsgBox("Select a Unit of Conversion", vbInformation)
        End If
    End Sub

    Private Sub ScientificToolStripMenuItem_sctf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificToolStripMenuItem_sctf.Click
        Me.Height = 450
        Me.Width = 393
        equal_btn.Width = 230
        scdisplay_result_lbn.Width = 345
        Label1.Visible = True
    End Sub

    Private Sub UnitConversionToolStripMenuItem_uncvs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitConversionToolStripMenuItem_uncvs.Click
        Me.Height = 450
        Me.Width = 659
        equal_btn.Width = 230
        scdisplay_result_lbn.Width = 345
        Label1.Visible = True
    End Sub

    Private Sub StandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardToolStripMenuItem_std.Click
        Me.Height = 448
        Me.Width = 260
        equal_btn.Width = 108
        scdisplay_result_lbn.Width = 220
        Label1.Visible = False
    End Sub

    

    Private Sub unit_clear_Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearuc_btn.Click
        convt_Label5.Text = ""
        convt_result_txt.Text = ""
    End Sub

    Private Sub convt_result_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit_conversion_combobox.Click


        If unit_conversion_combobox.Text = "Celsius to Fahrenheit" Then
            convt_result_txt.Enabled = True


        ElseIf unit_conversion_combobox.Text = "Fahrenheit to Celsius" Then
            convt_result_txt.Enabled = True

        ElseIf unit_conversion_combobox.Text = "Kilometers to Miles" Then
            convt_result_txt.Enabled = True

        ElseIf unit_conversion_combobox.Text = " Miles to Kilometers" Then
            convt_result_txt.Enabled = True

        Else
            ' ElseIf ComboBox1.Text = "Choose One..." Or convt_result_txt.Text = "" Then
            MsgBox("Select a Unit of Conversion", vbInformation)

        End If
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scdisplay_result_lbn.Click
        'Button14 = Button14.Text
        dot_btn.Text = "."
        If scdisplay_result_lbn.Text.Contains(".") Then
            dot_btn.Enabled = False
        End If
    End Sub

    

    Private Sub unit_conversion_combobox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit_conversion_combobox.SelectedIndexChanged
        If unit_conversion_combobox.Text = "Choose One..." Or convt_result_txt.Text = "" Then
            'ComboBox1.Enabled = False
            'MsgBox("Select a Unit of Conversion", vbInformation)
        End If
    End Sub

    

  
    Private Sub EditToolStripMenuItem_sc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem_sc.Click
        Application.Exit()
    End Sub

    Private Sub EditToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1_SC.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
