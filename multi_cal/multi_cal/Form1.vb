
Public Class Form1
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim u As Double
    Dim op As String
    Dim n As Int64

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        text_label.Parent = home_picture_box
        text_label.BackColor = Color.Transparent
        scdisplay_result_lbn.Text = "0"



        simple_calc_panel.Show()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub minimize_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize_btn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    'begining of panel and button
    Private Sub simple_calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simple_calc_btn.Click
        simple_calc_panel.Show()
        age_calc_panel.Hide()
        loan_calc_panel.Hide()
        boyles_law_panel.Hide()
        unit_con_panel.Show()
        gp_cal_panel.Hide()
    End Sub

    Private Sub age_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles age_btn.Click
        age_calc_panel.Show()
        simple_calc_panel.Hide()
        loan_calc_panel.Hide()
        boyles_law_panel.Hide()
        unit_con_panel.Hide()
        gp_cal_panel.Hide()
    End Sub

    Private Sub loan_calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_calc.Click
        loan_calc_panel.Show()
        age_calc_panel.Hide()
        simple_calc_panel.Hide()
        boyles_law_panel.Hide()
        unit_con_panel.Hide()
        gp_cal_panel.Hide()
    End Sub

    Private Sub boyles_law_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boyles_law_btn.Click
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        simple_calc_panel.Hide()
        boyles_law_panel.Show()
        unit_con_panel.Hide()
        gp_cal_panel.Hide()
    End Sub

    Private Sub unit_converter_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit_converter_btn.Click
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        simple_calc_panel.Hide()
        boyles_law_panel.Hide()
        unit_con_panel.Show()
        gp_cal_panel.Hide()
    End Sub

    Private Sub afoo_gp_cal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afoo_gp_cal_btn.Click
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        simple_calc_panel.Hide()
        boyles_law_panel.Hide()
        unit_con_panel.Hide()
        gp_cal_panel.Show()
    End Sub
    'end of panels and button



    'begin of scientific calculator
    Private Sub scdisplay_result_lbn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scdisplay_result_lbn.Click
        dot_btn.Text = "."
        If scdisplay_result_lbn.Text.Contains(".") Then
            dot_btn.Enabled = False
        End If



    End Sub

    Private Sub number_btn_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one_btn.Click, four_btn.Click, zero_btn.Click, three_btn.Click, six_btn.Click, seven_btn.Click, nine_btn.Click, four_btn.ClientSizeChanged, five_btn.Click, eight_btn.Click, two_btn.Click
        Dim b As Button = sender
        If scdisplay_result_lbn.Text = "0" Then
            scdisplay_result_lbn.Text = b.Text
        Else
            scdisplay_result_lbn.Text = scdisplay_result_lbn.Text + b.Text
        End If
    End Sub



    Private Sub dp_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dot_btn.Click
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

    Private Sub arithmetic_function_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusc_btn.Click, multiply_btn.Click, mod_btn.Click, minusc_btn.Click, exp_btn.Click, dividec_btn.Click
        Dim ops As Button = sender
        f = scdisplay_result_lbn.Text
        labelin_display_btn.Text = scdisplay_result_lbn.Text
        scdisplay_result_lbn.Text = ""
        op = ops.Text
        labelin_display_btn.Text = labelin_display_btn.Text + " " + op

        If scdisplay_result_lbn.Text.Contains(".") Then
            dot_btn.Enabled = False
        ElseIf scdisplay_result_lbn.Text.Contains("op") Then
            dot_btn.Enabled = True
        End If

    End Sub

    Private Sub equal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equal_btn.Click
        s = scdisplay_result_lbn.Text
        If op = "+" Then
            a = f + s
            scdisplay_result_lbn.Text = a
            labelin_display_btn.Text = ""


        ElseIf op = "-" Then
            a = f - s
            scdisplay_result_lbn.Text = a
            labelin_display_btn.Text = ""

        ElseIf op = "*" Then
            a = f * s
            scdisplay_result_lbn.Text = a
            labelin_display_btn.Text = ""
        ElseIf op = "/" Then
            a = f / s
            scdisplay_result_lbn.Text = a
            labelin_display_btn.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            scdisplay_result_lbn.Text = a
            labelin_display_btn.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            scdisplay_result_lbn.Text = a
            labelin_display_btn.Text = ""
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
        labelin_display_btn.Text = ""
    End Sub

    Private Sub cos_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cos_btn.Click
        a = Math.Cos(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        labelin_display_btn.Text = ""
    End Sub

    Private Sub tan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tan_btn.Click
        a = Math.Tan(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        labelin_display_btn.Text = ""
    End Sub

    Private Sub log_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log_btn.Click
        a = Math.Log(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        labelin_display_btn.Text = ""
    End Sub


    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        If scdisplay_result_lbn.Text.Length > 0 Then
            scdisplay_result_lbn.Text = scdisplay_result_lbn.Text.Remove(scdisplay_result_lbn.Text.Length - 1, 1)
        End If
        dot_btn.Enabled = True
    End Sub

    Private Sub clearsc_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearsc_btn.Click
        scdisplay_result_lbn.Text = "0"
        labelin_display_btn.Text = ""
        dot_btn.Enabled = True
    End Sub


    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub StandardToolStripMenuItem_std_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardToolStripMenuItem_std.Click
        Me.Height = 448
        Me.Width = 260
        equal_btn.Width = 108
        scdisplay_result_lbn.Width = 220
        Label2.Visible = False
        sci_cal_pnl.Width = 240
    End Sub

    Private Sub ScientificToolStripMenuItem_sctf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificToolStripMenuItem_sctf.Click
        Me.Height = 450
        Me.Width = 393
        equal_btn.Width = 230
        scdisplay_result_lbn.Width = 345
        Label1.Visible = True
        sci_cal_pnl.Width = 362

    End Sub
    'end of scientific calculator


    'begining of loan calculator
    Private Sub calculate_loan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_loan_btn.Click
        Dim loan_amount, duration, interest, i, amount, Repayment, total_interest, total_repayment As Double

        If duration_txt.Text = "" Or loan_amount_txt.Text = "" Then
            MsgBox("Field can't be empty", vbInformation)
        Else
            loan_amount = loan_amount_txt.Text
            duration = duration_txt.Text
            amount = loan_amount / duration
        End If
        For i = 1 To duration

            interest = 0.015 * loan_amount
            Repayment = amount + interest
            loan_amount = loan_amount - amount

            total_interest = total_interest + interest
            total_repayment = total_repayment + Repayment



            list_view_txt.Items.Add(i & "                                                 " & amount & "                                 " & interest & "                                      " & Repayment)

            total_interest_txt.Text = "TOTAL INTEREST: " + total_interest.ToString("N2")
            total_repayment_txt.Text = "TOTAL REPAYMENT: " + total_repayment.ToString("N2")

        Next
    End Sub


    Private Sub loan_amount_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles loan_amount_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Letter is not allow here!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot allowed in this fied!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("this field required users to input a numbers before a dot!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub duration_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles duration_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Letter is not allow here!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot allowed in this fied!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("this field required users to input a numbers before a dot!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub clear_loan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_loan_btn.Click

        duration_txt.Text = " "
        loan_amount_txt.Text = " "
        list_view_txt.Text = ""
        'interest_txt.Text = ""
        total_interest_txt.Text = ""
        total_repayment_txt.Text = ""
        list_view_txt.Items.Clear()


    End Sub
    'end of loan calculator


    Private Sub boyles_ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boyles_ComboBox1.SelectedIndexChanged
        

        If boyles_ComboBox1.SelectedIndex = "0" Then
            p1_txt.Enabled = False
            p1_txt.Text = "?"
            p2_txt.Enabled = True
            v2_txt.Enabled = True
            v1_txt.Enabled = True
            p2_txt.Text = ""
            v2_txt.Text = ""
            v1_txt.Text = ""

        ElseIf boyles_ComboBox1.SelectedIndex = "1" Then
            p2_txt.Enabled = False
            p2_txt.Text = "?"
            p1_txt.Enabled = True
            v2_txt.Enabled = True
            v1_txt.Enabled = True
            v2_txt.Text = ""
            p1_txt.Text = ""
            v1_txt.Text = ""


        ElseIf boyles_ComboBox1.SelectedIndex = "2" Then
            v1_txt.Enabled = False
            v1_txt.Text = "?"
            p1_txt.Enabled = True
            v2_txt.Enabled = True
            p2_txt.Enabled = True
            p2_txt.Text = ""
            v2_txt.Text = ""
            p1_txt.Text = ""

        ElseIf boyles_ComboBox1.SelectedIndex = "3" Then
            v2_txt.Enabled = False
            v2_txt.Text = "?"
            p1_txt.Enabled = True
            p2_txt.Enabled = True
            v1_txt.Enabled = True
            p2_txt.Text = ""
            p1_txt.Text = ""
            v1_txt.Text = ""

        Else
            MsgBox("Choose the right option", vbInformation)


        End If
        

    End Sub

    Private Sub calculate_boyles_law_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_boyles_law_btn.Click
        Dim p1, p2, v2, v1, result, a, b As Double
     

        If p1_txt.Text = "" Or p2_txt.Text = "" Or v1_txt.Text = "" Or v2_txt.Text = "" Then
            MsgBox("This can't be empty")
           
        Else

            If p1_txt.Enabled = False Then
                p2 = p2_txt.Text
                v1 = v1_txt.Text
                v2 = v2_txt.Text

                a = p2 * v2
                p1 = a / v1
                result = p1
                result_txt.Text = result

            ElseIf v1_txt.Enabled = False Then
                p2 = p2_txt.Text
                v2 = v2_txt.Text
                p1 = p1_txt.Text

                a = p2 * v2
                v1 = a / p1
                result = v1
                result_txt.Text = result

            ElseIf p2_txt.Enabled = False Then
                v1 = v1_txt.Text
                v2 = v2_txt.Text
                p1 = p1_txt.Text

                b = p1 * v1
                p2 = b / v2
                result = p2
                result_txt.Text = result

            ElseIf v2_txt.Enabled = False Then
                p2 = p2_txt.Text
                v1 = v1_txt.Text
                p1 = p1_txt.Text

                b = p1 * v1
                v2 = b / p2
                result = v2
                result_txt.Text = result
            End If
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        p1_txt.Text = ""
        p2_txt.Text = ""
        v1_txt.Text = ""
        v2_txt.Text = ""
        result_txt.Text = ""
    End Sub





    Private Sub security_boyles_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v2_txt.KeyPress, v1_txt.KeyPress, p1_txt.KeyPress, p2_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Letter is not allow here!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot allowed in this fied!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("this field required users to input a numbers before a dot!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

  

   
    'end of boyle's law


    Private Sub unit_con_panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles unit_con_panel.Paint
        unit_conversion_combobox.Text = "Choose One..."
        unit_conversion_combobox.Items.Add("Celsius to Fahrenheit")
        unit_conversion_combobox.Items.Add("Fahrenheit to Celsius")
        unit_conversion_combobox.Items.Add(" Miles to Kilometers")
        unit_conversion_combobox.Items.Add("Kilometers to Miles")
    End Sub

    Private Sub convertuc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertuc_btn.Click
        Dim convt As Double
        If convt_result_txt.Text = "" Then
            MsgBox("Select a Unit of Conversion", vbInformation)
        Else

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
        End If
    End Sub

    Private Sub convt_result_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convt_result_txt.TextChanged
       

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


    Private Sub clearuc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearuc_btn.Click
        convt_result_txt.Text = ""
        convt_Label5.Text = ""
    End Sub

    Private Sub convt_result_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles convt_result_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Letter is not allow here!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot allowed in this fied!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("this field required users to input a numbers before a dot!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'end of unit conversion


    'begining of age calculator
    Private Sub calculate_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_txt.Click
        Dim today, toyear, tomonth, birthyear, birthmonth, birthday, resultday, resultmonth, resultyear As Integer
        Dim DaysInMonth As Integer


        If (birthday_txt.Text = "") Or (birthmonth_txt.Text = "") Or birthyear_txt.Text = "" Then
            MsgBox("Field can't be empty!")
        ElseIf (birthday_txt.Text = "") And (birthmonth_txt.Text = "") And birthyear_txt.Text = "" Then
            MsgBox("Field can't be empty!")
            ' ElseIf birthmonth = 4 Or 6 Or 9 Or 11 And (birthday > DaysInMonth) Then
            ' MsgBox("Invalid birthmonth or birthday!")

            '  ElseIf birthmonth = "1" Or birthmonth = "3" Or birthmonth = "5" Or birthmonth = "7" Or birthmonth = "8" Or birthmonth = "10" Or birthmonth = "12" And (birthday > DaysInMonth) Then
            ' MsgBox("Invalid birthmonth or birthday!")
        Else

            today = Date.Now.Day
            toyear = Date.Now.Year
            tomonth = Date.Now.Month


            birthday = birthday_txt.Text
            birthmonth = birthmonth_txt.Text
            birthyear = birthyear_txt.Text

            ' If (birthmonth = 2) And (birthday > DaysInMonth) Then
            'MsgBox("Input valid birthday")
            If (birthmonth > tomonth) Then
                MsgBox("Incorrect input!")

            ElseIf (birthday > 31) Or (birthmonth > 12) Or (birthyear > toyear) Or (birthday < 1) Or (birthmonth < 1) Or (birthyear < 1) Then
                MsgBox("Incorrect input!")
            ElseIf (birthyear > toyear) Then
                MsgBox("Input valid birthyear!")
                ' ElseIf (birthday > today) And (birthmonth = tomonth) And (birthmonth > tomonth) Then
                '  MsgBox("Input valid birthmonth!")
            ElseIf (birthday > today) And (birthmonth = tomonth Or birthmonth > tomonth) And (toyear = birthyear) Then
                MsgBox("Input valid birthmonth!")
            ElseIf (birthday > today) And (birthmonth > tomonth) And (toyear < birthyear) Then
                MsgBox("Input valid birthmonth!")
                'MsgBox("Input valid birthmonth!")
                'MsgBox("Input valid birthmonth!")

            Else

                DaysInMonth = System.DateTime.DaysInMonth(birthyear, birthmonth)





                If (today > birthday) And (tomonth > birthmonth) Then
                    resultyear = toyear - birthyear
                ElseIf (today = birthday) And (tomonth > birthmonth) Then
                    resultyear = toyear - birthyear
                ElseIf (today < birthday) And (tomonth > birthmonth) Then
                    resultyear = toyear - birthyear

                ElseIf (today > birthday) And (tomonth = birthmonth) Then
                    resultyear = toyear - birthyear
                ElseIf (today = birthday) And (tomonth = birthmonth) Then
                    resultyear = toyear - birthyear
                ElseIf (tomonth = birthmonth) And (today < birthday) Then
                    resultyear = toyear - 1 - birthyear
                ElseIf (today > birthday) And (tomonth < birthmonth) Then
                    resultyear = toyear - 1 - birthyear
                ElseIf (today = birthday) And (tomonth < birthmonth) Then
                    resultyear = toyear - 1 - birthyear
                ElseIf (today < birthday) And (tomonth < birthmonth) Then
                    resultyear = toyear - 1 - birthyear
                ElseIf (birthday > today) And (birthday < tomonth) And (birthday < toyear) Then
                    resultyear = toyear - 1 - birthyear
                ElseIf (birthday > today) And (birthday = tomonth) And (birthday < toyear) Then
                    resultyear = toyear - 1 - birthyear

                End If





                If (tomonth > birthmonth) And (today > birthday) Then
                    resultmonth = tomonth - birthmonth
                ElseIf (tomonth > birthmonth) And (today = birthday) Then
                    resultmonth = tomonth - birthmonth

                ElseIf (tomonth > birthmonth) And (today < birthday) Then
                    resultmonth = tomonth - 1 - birthmonth


                ElseIf (tomonth = birthmonth) And (birthday > today) Then
                    resultmonth = 11

                ElseIf (today > birthday) And (tomonth < birthmonth) Then
                    resultmonth = 12 + tomonth - birthmonth

                ElseIf (today = birthday) And (tomonth < birthmonth) Then
                    resultmonth = 12 + tomonth - birthmonth

                ElseIf (today < birthday) And (tomonth < birthmonth) Then
                    resultmonth = 11 + tomonth - birthmonth
                ElseIf (birthday > today) And (birthday < tomonth) And (birthday < toyear) Then
                    resultmonth = 11
                ElseIf (birthday > today) And (birthday = tomonth) And (birthday < toyear) Then
                    resultmonth = 11


                End If



                If (today > birthday) Then
                    resultday = today - birthday
                ElseIf (today = birthday) Then
                    resultday = today - birthday

                ElseIf (birthday > today) Then
                    resultday = (DaysInMonth + today) - birthday
                ElseIf (birthday > today) And (birthday < tomonth) And (birthday < toyear) Then
                    resultday = (DaysInMonth + today) - birthday
                ElseIf (birthday > today) And (birthday = tomonth) And (birthday < toyear) Then
                    resultday = (DaysInMonth + today) - birthday
                    'ElseIf birthmonth = "4" Or birthmonth = "6" Or birthmonth = "9" Or birthmonth = "11" Then
                    ' resultday = (DaysInMonth >= 30)
                    ' ElseIf birthmonth = "1" Or birthmonth = "3" Or birthmonth = "5" Or birthmonth = "7" Or birthmonth = "8" Or birthmonth = "10" Or birthmonth = "12" Then
                    ' resultday = (DaysInMonth >= 31)
                End If

                result_day_txt.Text = resultday
                result_month_txt.Text = resultmonth
                result_year_txt.Text = resultyear

            End If
        End If

    End Sub

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click
        birthday_txt.Text = ""
        birthmonth_txt.Text = ""
        birthyear_txt.Text = ""
        result_day_txt.Text = ""
        result_month_txt.Text = ""
        result_year_txt.Text = ""

    End Sub

    Private Sub birthday_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles birthday_txt.TextChanged
        If birthday_txt.Text.Contains(".") Then
            MessageBox.Show("birthday can't contain dot")
        End If
    End Sub

    Private Sub birthmonth_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles birthmonth_txt.TextChanged
        If birthmonth_txt.Text.Contains(".") Then
            MessageBox.Show("birthmonth can't contain dot")
        End If
    End Sub

    Private Sub birthyear_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles birthyear_txt.TextChanged
        If birthyear_txt.Text.Contains(".") Then
            MessageBox.Show("birthyear can't contain dot")
       
        End If
    End Sub


    Private Sub security_agecal_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthday_txt.KeyPress, birthmonth_txt.KeyPress, birthyear_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Letter is not allow here!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("dot is not allow!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    
    'end of age calculator



    Private Sub check_cgpa_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_cgpa_btn.Click
        Dim SPDT101, MAD102, SDA103, WAD104, NS105, AGDT106, p1, p2, p3, p4, p5, p6, Tp, gp, cgpa As Double


        If (spdt_txt.Text = "") Or (sda_txt.Text = "") Or (mad_txt.Text = "") Or (wad_txt.Text = "") Or (ns_txt.Text = "") Or (agdt_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SDA103 = sda_txt.Text
            MAD102 = mad_txt.Text
            WAD104 = wad_txt.Text
            NS105 = ns_txt.Text
            AGDT106 = agdt_txt.Text
            SPDT101 = spdt_txt.Text







            If (SPDT101 >= 80 Or SPDT101 <= 100) Then
                p1 = 4 * 4
            ElseIf (SPDT101 <= 79.9 And SPDT101 >= 70) Then
                p1 = 3.5 * 4
            ElseIf (SPDT101 <= 69.9 And SPDT101 >= 60) Then
                p1 = 3 * 4
            ElseIf (SPDT101 <= 59.9 And SPDT101 >= 50) Then
                p1 = 2.5 * 4
            ElseIf (SPDT101 <= 49.9 And SPDT101 >= 40) Then
                p1 = 2 * 4
            ElseIf (SPDT101 <= 39.9) And (SPDT101 >= 0) Then
                p1 = 0 * 4

            Else
                MsgBox("Invalid Input!", vbInformation)
            End If



            If (MAD102 >= 80 And MAD102 <= 100) Then
                p2 = 4 * 4
            ElseIf (MAD102 >= 70) Then
                p2 = 3.5 * 4
            ElseIf (MAD102 >= 60) Then
                p2 = 3 * 4
            ElseIf (MAD102 >= 50) Then
                p2 = 2.5 * 4
            ElseIf (MAD102 >= 40) Then
                p2 = 2 * 4
            ElseIf (MAD102 <= 39.9) And (MAD102 >= 0) Then
                p2 = 0 * 4
            Else
                MsgBox("Invalid Input!", vbInformation)

            End If






            If (SDA103 >= 80 And SDA103 <= 100) Then
                p3 = 4 * 4
            ElseIf (SDA103 >= 70) Then
                p3 = 3.5 * 4
            ElseIf (SDA103 >= 60) Then
                p3 = 3 * 4
            ElseIf (SDA103 >= 50) Then
                p3 = 2.5 * 4
            ElseIf (SDA103 >= 40) Then
                p3 = 2 * 4
            ElseIf (SDA103 <= 39.9) And (SDA103 >= 0) Then
                p3 = 0 * 4
            Else
                MsgBox("Invalid Input!", vbInformation)

            End If



            If (WAD104 >= 80 And WAD104 <= 100) Then
                p4 = 4 * 4
            ElseIf (WAD104 >= 70) Then
                p4 = 3.5 * 4
            ElseIf (WAD104 >= 60) Then
                p4 = 3 * 4
            ElseIf (WAD104 >= 50) Then
                p4 = 2.5 * 4
            ElseIf (WAD104 >= 40) Then
                p4 = 2 * 4
            ElseIf (WAD104 <= 39.9) And (WAD104 >= 0) Then
                p4 = 0 * 4
            Else
                MsgBox("Invalid Input!", vbInformation)

            End If



            If (NS105 >= 80 And NS105 <= 100) Then
                p5 = 4 * 4
            ElseIf (NS105 >= 70) Then
                p5 = 3.5 * 4
            ElseIf (NS105 >= 60) Then
                p5 = 3 * 4
            ElseIf (NS105 >= 50) Then
                p5 = 2.5 * 4
            ElseIf (NS105 >= 40) Then
                p5 = 2 * 4
            ElseIf (NS105 <= 39.9) And (NS105 >= 0) Then
                p5 = 0 * 4
            Else
                MsgBox("Invalid Input!", vbInformation)
            End If


            If (AGDT106 >= 80 Or AGDT106 <= 100) Then
                p6 = 4 * 4
            ElseIf (AGDT106 >= 70) Then
                p6 = 3.5 * 4
            ElseIf (AGDT106 >= 60) Then
                p6 = 3 * 4
            ElseIf (AGDT106 >= 50) Then
                p6 = 2.5 * 4
            ElseIf (AGDT106 >= 40) Then
                p6 = 2 * 4
            ElseIf (AGDT106 <= 39.9) And (AGDT106 >= 0) Then
                p6 = 0 * 4
            Else
                MsgBox("Invalid Input!", vbInformation)

            End If






            Tp = p1 + p2 + p3 + p4 + p5 + p6





            gp = Tp / 20
            cgpa = gp
            result_gp_lbn.Text = ("Your CGPA is " + cgpa.ToString)


            If (cgpa >= 3.5 Or cgpa = 4) Then
                result_grade_lbn.Text = ("First Class")

            ElseIf (cgpa <= 3.49 Or cgpa = 3.0) Then
                result_grade_lbn.Text = ("Seconds Class Upper")

            ElseIf (cgpa <= 2.99 Or cgpa >= 2.5) Then
                result_grade_lbn.Text = ("Second Class Lower")

            ElseIf (cgpa <= 2.49 Or cgpa = 2.0) Then
                result_grade_lbn.Text = ("Pass")

            ElseIf cgpa = 0 Or cgpa < 2.0 Then
                result_grade_lbn.Text = ("Fair")

            Else
                result_grade_lbn.Text = ("Invalid")

            End If
        End If


    End Sub



    Private Sub clear_gp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_gp_btn.Click
        sda_txt.Text = ""
        spdt_txt.Text = ""
        ns_txt.Text = ""
        mad_txt.Text = ""
        wad_txt.Text = ""
        agdt_txt.Text = ""
        result_gp_lbn.Text = ""
        result_grade_lbn.Text = ""
    End Sub

  

    Private Sub course_security_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles spdt_txt.KeyPress, mad_txt.KeyPress, agdt_txt.KeyPress, wad_txt.KeyPress, ns_txt.KeyPress, sda_txt.KeyPress
        Dim SPDT101, MAD102, SDA103, WAD104, NS105, AGDT106 As Double

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Letter is not allow here!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot allowed in this fied!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("this field required users to input a numbers before a dot!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
       
        End If

        SDA103 = sda_txt.Text
        MAD102 = mad_txt.Text
        WAD104 = wad_txt.Text
        NS105 = ns_txt.Text
        AGDT106 = agdt_txt.Text
        SPDT101 = spdt_txt.Text



        If (SPDT101 < 0 Or SPDT101 > 100) Or (MAD102 < 0 Or MAD102 > 100) Or (WAD104 < 0 Or WAD104 > 100) Or (AGDT106 < 0 Or AGDT106 > 100) Or (NS105 < 0 Or NS105 > 100) Or (SDA103 < 0 Or SDA103 > 100) Then
            MessageBox.Show(" empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If



    End Sub

    

 
End Class