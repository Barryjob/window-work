Public Class Form1
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim u As Double
    Dim op As String
    Dim n As Int64

    Private Sub number_button_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one_btn.Click, two_btn.Click, three_btn.Click, seven_btn.Click, five_btn.Click, six_btn.Click, four_btn.Click, zero_btn.Click, eight_btn.Click, nine_btn.Click
        Dim b As Button = sender
        If scdisplay_result_lbn.Text = "0" Then
            scdisplay_result_lbn.Text = b.Text
        Else
            scdisplay_result_lbn.Text = scdisplay_result_lbn.Text + b.Text
        End If
    End Sub
    Private Sub dp_Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dot_btn.Click
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

    Private Sub clear_Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearsc_btn.Click
        scdisplay_result_lbn.Text = "0"
        Label3.Text = ""
    End Sub

    Private Sub ce_Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        scdisplay_result_lbn.Text = "0"
        Label3.Text = ""

    End Sub

    Private Sub arithmetic_function(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusc_btn.Click, minusc_btn.Click, exp_btn.Click, mod_btn.Click, dividec_btn.Click
        Dim ops As Button = sender
        f = scdisplay_result_lbn.Text
        Label3.Text = scdisplay_result_lbn.Text
        scdisplay_result_lbn.Text = ""
        op = ops.Text
        Label3.Text = Label3.Text + " " + op



    End Sub
    Private Sub arithmetic2_function(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiply_btn.Click
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

    Private Sub equal_Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equal_btn.Click
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

    Private Sub binary_Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bin_btn.Click
        If Int64.TryParse(scdisplay_result_lbn.Text, n) Then
            scdisplay_result_lbn.Text = Convert.ToString(n, 2)
        Else
            scdisplay_result_lbn.Text = ""
        End If
    End Sub

    Private Sub sin_Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sin_btn.Click
        a = Math.Sin(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub cos_Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cos_btn.Click
        a = Math.Cos(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub tan_Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tan_btn.Click
        a = Math.Tan(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub log_Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log_btn.Click
        a = Math.Log(scdisplay_result_lbn.Text)
        scdisplay_result_lbn.Text = a
        Label3.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit_conversion_combobox.SelectedIndexChanged
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

    Private Sub convert_Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertuc_btn.Click
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

    Private Sub ScientificToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Height = 450
        Me.Width = 393
        equal_btn.Width = 230
        scdisplay_result_lbn.Width = 345
        Label1.Visible = True
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitConversionToolStripMenuItem.Click
        Me.Height = 450
        Me.Width = 659
        equal_btn.Width = 230
        scdisplay_result_lbn.Width = 345
        Label1.Visible = True
    End Sub

    Private Sub StandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Height = 448
        Me.Width = 260
        equal_btn.Width = 108
        scdisplay_result_lbn.Width = 220
        Label1.Visible = False
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub unit_clear_Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearuc_btn.Click
        convt_Label5.Text = ""
        convt_result_txt.Text = ""
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


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scdisplay_result_lbn.Click
        'Button14 = Button14.Text
        dot_btn.Text = "."
        If scdisplay_result_lbn.Text.Contains(".") Then
            dot_btn.Enabled = False
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        If unit_conversion_combobox.Text = "Choose One..." Or convt_result_txt.Text = "" Then
            'ComboBox1.Enabled = False
            'MsgBox("Select a Unit of Conversion", vbInformation)
        End If
    End Sub

    Private Sub hex_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hex_btn.Click

    End Sub

    Private Sub convt_Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convt_Label5.Click

    End Sub

    Private Sub convt_result_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles convt_result_txt.KeyPress

    End Sub
End Class
