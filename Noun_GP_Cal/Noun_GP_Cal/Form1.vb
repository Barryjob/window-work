Public Class Form1
    Dim gp, cgpa, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, GST103, GST101, GST107, BIO101, CHM101,
              CHM103, CIT143, MTH101, MTH103, PHY192, BIO191, CHM191, PHY191, PHY101, GST102, GST104, CHM102, CIT102, CIT104 As Double
    Dim STT102, MTH102, BIO102, BIO192, CHM192, PHY102, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C12, C11, gp2, cgpa2,
     GST201, GST203, CIT211, CIT215, CIT237, MTH211, MTH213, MTH281, K1, K2, K3, K4, K5, K6, K7, K8, gp3, cgpa3, cgpa4,
     GST202, GST204, CIT212, CIT236, CIT292, CIT208, MTH212, MTH232, MTH282, PHY208, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, gp4, f,
     CIT303, CIT305, CIT309, CIT311, CIT341, CIT371, CIT381, CIT389, gp5, cgpa5, B1, B2, B3, B4, B5, B6, B7, B8,
     GST302, CIT322, CIT342, CIT344, CIT392, DAM301, DAM364, DAM344, DAM382, R1, R3, R2, R4, R5, R6, R7, R8, R9, gp6, cgpa6,
     CIT403, CIT411, CIT415, CIT427, CIT445, CIT461, CIT463, CIT465, Y1, Y2, Y3, Y4, Y5, Y6, Y7, Y8, gp7, cgpa7,
    CIT425, CIT474, CIT478, CIT484, CIT499, DAM461, Q1, Q2, Q3, Q4, Q5, Q6, gp8, cgpa8 As Double
    Dim x, y, K, J, m, L, U, pan As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
       

        If ComboBox1.SelectedIndex = "0" Then
            hundred_lvl_pnl.Show()
            two_hundred_lvl_pnl.Hide()
            three_hundred_lvl_pnl.Hide()
            four_hundred_lvl_pnl.Hide()
            first_smt_hundred_pnl.Hide()
            second_smt_hundred_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_threehundred_lvl_pnl.Hide()
            second_smt_threehundred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            first_smt_four_hrd_lvl_pnl.Hide()
            second_smt_four_hrd_lvl_pnl.Hide()
            ' calculate_pnl.Hide()

        ElseIf ComboBox1.SelectedIndex = "1" Then
            two_hundred_lvl_pnl.Show()
            hundred_lvl_pnl.Hide()
            three_hundred_lvl_pnl.Hide()
            four_hundred_lvl_pnl.Hide()
            first_smt_hundred_pnl.Hide()
            second_smt_hundred_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_threehundred_lvl_pnl.Hide()
            second_smt_threehundred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            first_smt_four_hrd_lvl_pnl.Hide()
            second_smt_four_hrd_lvl_pnl.Hide()
            ' calculate_pnl.Hide()

        ElseIf ComboBox1.SelectedIndex = "2" Then
            two_hundred_lvl_pnl.Hide()
            hundred_lvl_pnl.Hide()
            three_hundred_lvl_pnl.Show()
            four_hundred_lvl_pnl.Hide()
            first_smt_hundred_pnl.Hide()
            second_smt_hundred_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_threehundred_lvl_pnl.Hide()
            second_smt_threehundred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            first_smt_four_hrd_lvl_pnl.Hide()
            second_smt_four_hrd_lvl_pnl.Hide()
            ' calculate_pnl.Hide()

        Else
            ComboBox1.SelectedIndex = "3"
            two_hundred_lvl_pnl.Hide()
            hundred_lvl_pnl.Hide()
            three_hundred_lvl_pnl.Hide()
            four_hundred_lvl_pnl.Show()
            first_smt_hundred_pnl.Hide()
            second_smt_hundred_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_threehundred_lvl_pnl.Hide()
            second_smt_threehundred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Hide()
            first_smt_two_hred_lvl_pnl.Hide()
            first_smt_four_hrd_lvl_pnl.Hide()
            second_smt_four_hrd_lvl_pnl.Hide()
            'calculate_pnl.Hide()

        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        home()
        ComboBox1.Items.Add("100 Level")
        ComboBox1.Items.Add("200 Level")
        ComboBox1.Items.Add("300 Level")
        ComboBox1.Items.Add("400 Level")

        
     
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one_hundred_CheckBox1.CheckedChanged
        If one_hundred_CheckBox1.CheckState = CheckState.Checked Then
            two_hundre_CheckBox2.CheckState = CheckState.Unchecked
            first_smt_hundred_pnl.Show()
            second_smt_hundred_pnl.Hide()
        End If

       

        onehundredfirstsemester()
    End Sub
   
    Private Sub two_hundre_CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles two_hundre_CheckBox2.CheckedChanged
        onehundredsecondsemester()
      

        If two_hundre_CheckBox2.CheckState = CheckState.Checked Then
            one_hundred_CheckBox1.CheckState = CheckState.Unchecked
            first_smt_hundred_pnl.Hide()
            second_smt_hundred_pnl.Show()
        End If

    End Sub

    Private Sub one_fourhundred_lvl_CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one_fourhundred_lvl_CheckBox1.CheckedChanged
        fourhundredfirstsemester()
        If one_fourhundred_lvl_CheckBox1.CheckState = CheckState.Checked Then
            two_fourhundred_lvl_CheckBox1.CheckState = CheckState.Unchecked
            first_smt_four_hrd_lvl_pnl.Show()
            second_smt_four_hrd_lvl_pnl.Hide()
        End If
       
    End Sub

    Private Sub two_fourhundred_lvl_CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles two_fourhundred_lvl_CheckBox1.CheckedChanged
        fourhundredsecondsemester()
        If two_fourhundred_lvl_CheckBox1.CheckState = CheckState.Checked Then
            one_fourhundred_lvl_CheckBox1.CheckState = CheckState.Unchecked
            first_smt_four_hrd_lvl_pnl.Hide()
            second_smt_four_hrd_lvl_pnl.Show()
        End If
    End Sub

    Private Sub one_three_lvl_CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles one_three_lvl_CheckBox2.CheckedChanged
        threehundredfirstsemester()
        If one_three_lvl_CheckBox2.CheckState = CheckState.Checked Then
            second_tlhree_lvCheckBox1.CheckState = CheckState.Unchecked
            first_smt_threehundred_lvl_pnl.Show()
            second_smt_threehundred_lvl_pnl.Hide()
        End If
    End Sub

    Private Sub second_tlhree_lvCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second_tlhree_lvCheckBox1.CheckedChanged
        threehundredsecondsemester()
        If second_tlhree_lvCheckBox1.CheckState = CheckState.Checked Then
            one_three_lvl_CheckBox2.CheckState = CheckState.Unchecked
            first_smt_threehundred_lvl_pnl.Hide()
            second_smt_threehundred_lvl_pnl.Show()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second_sem_two_hund_ckbox.CheckedChanged
        twohundredsecondsemester()
        If second_sem_two_hund_ckbox.CheckState = CheckState.Checked Then
            first_sem_two_hund_ckbox.CheckState = CheckState.Unchecked
            first_smt_two_hred_lvl_pnl.Hide()
            second_smt_twohred_lvl_pnl.Show()
        End If
   
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first_sem_two_hund_ckbox.CheckedChanged
        twohundredfirstsemester()
        If first_sem_two_hund_ckbox.CheckState = CheckState.Checked Then
            second_sem_two_hund_ckbox.CheckState = CheckState.Unchecked
            first_smt_two_hred_lvl_pnl.Show()
            second_smt_twohred_lvl_pnl.Hide()
        End If
    End Sub

    Private Sub clearfirstsemesteronehund()
        gst101_txt.Text = ""
        gst103_txt.Text = ""
        gst107_txt.Text = ""
        bio101_txt.Text = ""
        chm101_txt.Text = ""
        chm103_txt.Text = ""
        cit143_txt.Text = ""
        mth101_txt.Text = ""
        mth103_txt.Text = ""
        bio191_txt.Text=""
        phy101_txt.Text = ""
        gpa_txt.Text = ""
        cgpa_txt.Text = ""
        grade_lbl.Text = ""

    End Sub

    Private Sub clearsecondsemesteronehund()
        gst102_txt.Text = ""
        gst104_txt.Text = ""
        chm102_txt.Text = ""
        cit102_txt.Text = ""
        cit104_txt.Text = ""
        stt102_txt.Text = ""
        mth102_txt.Text = ""
        bio102_txt.Text = ""
        bio192_txt.Text = ""
        chm192_txt.Text = ""
        phy192_txt.Text = ""
        phy102_txt.Text = ""
        gpa_sec_sem_hund_txt.Text = ""
        cgpa_sec_sem_hund_txt.Text = ""
        grade_sec_sem_hund.Text = ""
    End Sub

    Private Sub clearfirstsemestertwohund()
        chm191_txt.Text = ""
        gst201_txt.Text = ""
        gst203_txt.Text = ""
        cit211_txt.Text = ""
        cit215_txt.Text = ""
        cit237_txt.Text = ""
        mth211_txt.Text = ""
        mth213_txt.Text = ""
        mth281_txt.Text = ""
        gpa_firstsem_twohund_txt.Text = ""
        gpa_firstsem_twohund_txt.Text = ""
        grade_firstsem_twohund_lbl.Text = ""
    End Sub

    Private Sub clearsecondsementertwohund()
        phy191_txt.Text = ""
        gst202_txt.Text = ""
        gst204_txt.Text = ""
        cit208_txt.Text = ""
        cit212_txt.Text = ""
        cit236_txt.Text = ""
        cit292_txt.Text = ""
        mth212_txt.Text = ""
        mth232_txt.Text = ""
        mth282_txt.Text = ""
        gpa_second_smt_twohred_lvl_txt.Text = ""
        cgpa_second_smt_twohred_lvl_txt.Text = ""
        grade_second_smt_twohred_lvl_lbl.Text = ""
    End Sub

    Private Sub clearfirstsemesterthreehund()
        cit303_txt.Text = ""
        cit305_txt.Text = ""
        cit311_txt.Text = ""
        cit381_txt.Text = ""
        cit292_txt.Text = ""
        cit389_txt.Text = ""
        gpafirst_smt_threehundred_lvl_txt.Text = ""
        cgpafirst_smt_threehundred_lvl__txt.Text = ""
        gradefirst_smt_threehundred_lvl_lbl.Text = ""
    End Sub

    Private Sub clearsecondsemesterthreehund()
        gst302_txt.Text = ""
        cit344_txt.Text = ""
        cit342_txt.Text = ""
        cit392_txt.Text = ""
        dam301_txt.Text = ""
        dam364_txt.Text = ""
        dam382_txt.Text = ""
        gpa_econd_smt_threehundred_lvl_txt.Text = ""
        cgpa_second_smt_threehundred_lvl_txt.Text = ""
        grade_second_smt_threehundred_lvl_lbl.Text = ""
    End Sub

    Private Sub clearfirstsemesterfourhund()
        cit403_txt.Text = ""
        cit411_txt.Text = ""
        cit415_txt.Text = ""
        cit427_txt.Text = ""
        cit445_txt.Text = ""
        cit461_txt.Text = ""
        cit463_txt.Text = ""
        cit465_txt.Text = ""
        gpa_first_smt_four_hrd_lvl_txt.Text = ""
        cgpa_first_smt_four_hrd_lvl_txt.Text = ""
        grade_first_smt_four_hrd_lvl_txt.Text = ""
    End Sub

    Private Sub clearsecondsemesterfourhund()
        cit425_txt.Text = ""
        cit474_txt.Text = ""
        cit478_txt.Text = ""
        cit484_txt.Text = ""
        cit499_txt.Text = ""
        dam461_txt.Text = ""
        grade_second_smt_four_hrd_lvl_lbl.Text = ""
        gpa_first_smt_four_hrd_lvl_txt.Text = ""
        cgpa_first_smt_four_hrd_lvl_txt.Text = ""
    End Sub

    Private Sub home()
        home_pnl.Show()
        ComboBox1.Visible = True
        PictureBox1.Visible = True
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Hide()
        'calculate_pnl.Hide()
    End Sub

    Private Sub onehundredfirstsemester()
        home_pnl.Hide()
        first_smt_hundred_pnl.Show()
        second_smt_hundred_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
        hundred_lvl_pnl.Show()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Hide()
        ' calculate_pnl.Show()
    End Sub

    Private Sub onehundredsecondsemester()
        home_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Show()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        hundred_lvl_pnl.Show()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
        'calculate_pnl.Show()
    End Sub

    Private Sub twohundredfirstsemester()
        home_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Show()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Show()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
        'calculate_pnl.Hide()
    End Sub

    Private Sub twohundredsecondsemester()
        home_pnl.Hide()
        second_smt_twohred_lvl_pnl.Show()
        first_smt_two_hred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Show()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
        'calculate_pnl.Hide()
    End Sub

    Private Sub threehundredfirstsemester()
        home_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Show()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Show()
        four_hundred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
        ' calculate_pnl.Hide()
    End Sub

    Private Sub threehundredsecondsemester()
        home_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Show()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Show()
        four_hundred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
        ' calculate_pnl.Hide()
    End Sub

    Private Sub fourhundredfirstsemester()
        home_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Show()
        second_smt_four_hrd_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Show()
        ' calculate_pnl.Hide()
    End Sub

    Private Sub fourhundredsecondsemester()
        home_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Show()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Show()
        'calculate_pnl.Hide()
    End Sub
    Private Sub hundred()
        one_hundred_CheckBox1.Checked = True
        two_hundre_CheckBox2.Checked = True
        second_sem_two_hund_ckbox.Checked = False
        first_sem_two_hund_ckbox.Checked = False
    End Sub

    Private Sub twohundred()
        one_hundred_CheckBox1.Checked = False
        two_hundre_CheckBox2.Checked = False
        second_sem_two_hund_ckbox.Checked = True
        first_sem_two_hund_ckbox.Checked = True
    End Sub


    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        clearfirstsemesteronehund()
    End Sub
    Private Sub clear_sec_sem_hund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_sec_sem_hund.Click
        clearsecondsemesteronehund()
    End Sub


    Private Sub clear_firstsem_twohund_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_firstsem_twohund_btn.Click
        clearfirstsemestertwohund()
    End Sub

    Private Sub clear_second_smt_twohred_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_second_smt_twohred_lvl_btn.Click
        clearsecondsementertwohund()
    End Sub
    Private Sub clearfirst_smt_threehundred_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearfirst_smt_threehundred_lvl_btn.Click
        clearfirstsemesterthreehund()
    End Sub

    Private Sub clearsecsem_threhund_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearsecsem_threhund_btn.Click
        clearsecondsemesterthreehund()
    End Sub

    Private Sub cleat_first_smt_four_hrd_lvl_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cleat_first_smt_four_hrd_lvl_btn.Click
        clearfirstsemesterfourhund()
    End Sub
 
    Private Sub clear_second_smt_four_hrd_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_second_smt_four_hrd_lvl_btn.Click
        clearsecondsemesterfourhund()
    End Sub
  

    '--------------------------- 100L FIRST SEMESTER------------------------------------

    Private Sub calculate_grade_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_grade_btn.Click

        If ComboBox1.SelectedIndex = "0" And one_hundred_CheckBox1.Checked = True Then
            hundred()
            second_smt_hundred_pnl.Hide()
            first_smt_hundred_pnl.Show()
            one_hundred_CheckBox1.CheckState = CheckState.Checked
            two_hundre_CheckBox2.CheckState = CheckState.Unchecked

        ElseIf (gst101_txt.Text = "") Or (gst103_txt.Text = "") Or (bio101_txt.Text = "") Or (chm103_txt.Text = "") Or (bio191_txt.Text = "") Or (mth103_txt.Text = "") Or (cit143_txt.Text = "") Or (gst107_txt.Text = "") Or (mth101_txt.Text = "") Or (chm101_txt.Text = "") Or (phy101_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            GST101 = gst101_txt.Text
            If (GST101 >= 70) And (GST101 <= 100) Then
                P1 = 5 * 2
            ElseIf (GST101 >= 60) And (GST101 <= 69) Then
                P1 = 4 * 2
            ElseIf (GST101 >= 50) And (GST101 <= 59) Then
                P1 = 3 * 2
            ElseIf (GST101 >= 45) And (GST101 <= 49) Then
                P1 = 2 * 2
            ElseIf (GST101 >= 40) And (GST101 <= 44) Then
                P1 = 1 * 2
            ElseIf (GST101 >= 0) And (GST101 <= 39) Then
                P1 = 0 * 2
            Else
                Console.WriteLine("Input correct score")

                End
            End If


            GST103 = gst103_txt.Text
            If (GST103 >= 70) And (GST103 <= 100) Then
                P2 = 5 * 2
            ElseIf (GST103 >= 60) And (GST103 <= 69) Then
                P2 = 4 * 2
            ElseIf (GST103 >= 50) And (GST103 <= 59) Then
                P2 = 3 * 2
            ElseIf (GST103 >= 45) And (GST103 <= 49) Then
                P2 = 2 * 2
            ElseIf (GST103 >= 40) And (GST103 <= 44) Then
                P2 = 1 * 2
            ElseIf (GST103 >= 0) And (GST103 <= 39) Then
                P2 = 0 * 2
            Else
                Console.WriteLine("Input correct score")

                End
            End If

            GST107 = gst107_txt.Text
            If (GST107 >= 70) And (GST107 <= 100) Then
                P1 = 5 * 2
            ElseIf (GST107 >= 60) And (GST107 <= 69) Then
                P1 = 4 * 2
            ElseIf (GST101 >= 50) And (GST101 <= 59) Then
                P1 = 3 * 2
            ElseIf (GST107 >= 45) And (GST107 <= 49) Then
                P1 = 2 * 2
            ElseIf (GST107 >= 40) And GST107 <= 44 Then
                P1 = 1 * 2
            ElseIf (GST107 >= 0) And (GST107 <= 39) Then
                P1 = 0 * 2
            Else
                Console.WriteLine("Input correct score")

                End
            End If

            BIO101 = bio101_txt.Text
            If (BIO101 >= 70) And (BIO101 <= 100) Then
                P4 = 5 * 2
            ElseIf (BIO101 >= 60) And (BIO101 <= 69) Then
                P4 = 4 * 2
            ElseIf (BIO101 >= 50) And (BIO101 <= 59) Then
                P4 = 3 * 2
            ElseIf (BIO101 >= 45) And (BIO101 <= 49) Then
                P4 = 2 * 2
            ElseIf (BIO101 >= 40) And (BIO101 <= 44) Then
                P4 = 1 * 2
            ElseIf (BIO101 >= 0) And (BIO101 <= 39) Then
                P4 = 0 * 2
            Else
                Console.WriteLine("Input correct score")
                Console.WriteLine()

                End
            End If

            CHM101 = chm101_txt.Text
            If (CHM101 >= 70) And (CHM101 <= 100) Then
                P5 = 5 * 2
            ElseIf (CHM101 >= 60) And (CHM101 <= 69) Then
                P5 = 4 * 2
            ElseIf (CHM101 >= 50) And (CHM101 <= 59) Then
                P5 = 3 * 2
            ElseIf (CHM101 >= 45) And (CHM101 <= 49) Then
                P5 = 2 * 2
            ElseIf (CHM101 >= 40) And (CHM101 <= 44) Then
                P5 = 1 * 2
            ElseIf (CHM101 >= 0) And (CHM101 <= 39) Then
                P5 = 0 * 2
            Else
                Console.WriteLine("Input correct score")

                End
            End If

            CHM103 = chm103_txt.Text
            If (CHM103 >= 70) And (CHM103 <= 100) Then
                P6 = 5 * 2
            ElseIf (CHM103 >= 60) And (CHM103 <= 69) Then
                P6 = 4 * 2
            ElseIf (CHM103 >= 50) And (CHM103 <= 59) Then
                P6 = 3 * 2
            ElseIf (CHM103 >= 45) And (CHM103 <= 49) Then
                P6 = 2 * 2
            ElseIf (CHM103 >= 40) And (CHM103 <= 44) Then
                P6 = 1 * 2
            ElseIf (CHM103 >= 0) And (CHM103 <= 39) Then
                P6 = 0 * 2
            Else
                Console.WriteLine("Input correct score")


                End
            End If

            CIT143 = cit143_txt.Text
            If (CIT143 >= 70) And (CIT143 <= 100) Then
                P7 = 5 * 2
            ElseIf (CIT143 >= 60) And (CIT143 <= 69) Then
                P7 = 4 * 2
            ElseIf (CIT143 >= 50) And (CIT143 <= 59) Then
                P7 = 3 * 2
            ElseIf (CIT143 >= 45) And (CIT143 <= 49) Then
                P7 = 2 * 2
            ElseIf (CIT143 >= 40) And (CIT143 <= 44) Then
                P7 = 1 * 2
            ElseIf (CIT143 >= 0) And (CIT143 <= 39) Then
                P7 = 0 * 2
            Else
                Console.WriteLine("Input correct score")


                End
            End If

            MTH101 = mth101_txt.Text
            If (MTH101 >= 70) And (MTH101 <= 100) Then
                P8 = 5 * 3
            ElseIf (MTH101 >= 60) And (MTH101 <= 69) Then
                P8 = 4 * 3
            ElseIf (MTH101 >= 50) And (MTH101 <= 59) Then
                P8 = 3 * 3
            ElseIf (MTH101 >= 45) And (MTH101 <= 49) Then
                P8 = 2 * 3
            ElseIf (MTH101 >= 40) And (MTH101 <= 44) Then
                P8 = 1 * 3
            ElseIf (MTH101 >= 0) And (MTH101 <= 39) Then
                P8 = 0 * 2
            Else
                Console.WriteLine("Input correct score")

                End
            End If

            MTH103 = mth103_txt.Text
            If (MTH103 >= 70) And (MTH103 <= 100) Then
                P9 = 5 * 3
            ElseIf (MTH103 >= 60) And (MTH103 <= 69) Then
                P9 = 4 * 3
            ElseIf (MTH103 >= 50) And (MTH103 <= 59) Then
                P9 = 3 * 3
            ElseIf (MTH103 >= 45) And (MTH103 <= 49) Then
                P9 = 2 * 3
            ElseIf (MTH103 >= 40) And (MTH103 <= 44) Then
                P9 = 1 * 3
            ElseIf (MTH103 >= 0) And (MTH103 <= 39) Then
                P9 = 0 * 2
            Else
                Console.WriteLine("Input correct score")


                End
            End If

            PHY101 = phy101_txt.Text
            If PHY101 >= 70 And PHY101 <= 100 Then
                P10 = 5 * 2
            ElseIf PHY101 >= 60 And PHY101 <= 69 Then
                P10 = 4 * 2
            ElseIf PHY101 >= 50 And PHY101 <= 59 Then
                P10 = 3 * 2
            ElseIf PHY101 >= 45 And PHY101 <= 49 Then
                P10 = 2 * 2
            ElseIf PHY101 >= 40 And PHY101 <= 44 Then
                P10 = 1 * 2
            ElseIf (PHY101 >= 0) And (PHY101 <= 39) Then
                P10 = 0 * 2
            Else
                Console.WriteLine("Input correct score")

                End
            End If

            BIO191 = bio191_txt.Text
            If BIO191 >= 70 And BIO191 <= 100 Then
                P11 = 5 * 1
            ElseIf BIO191 >= 60 And BIO191 <= 69 Then
                P11 = 4 * 1
            ElseIf BIO191 >= 50 And BIO191 <= 59 Then
                P11 = 3 * 1
            ElseIf BIO191 >= 45 And BIO191 <= 49 Then
                P11 = 2 * 1
            ElseIf BIO191 >= 40 And BIO191 <= 44 Then
                P11 = 1 * 1
            ElseIf (BIO191 >= 0) And (BIO191 <= 39) Then
                P11 = 0 * 2
            Else
                Console.WriteLine("Input correct score")
                Console.WriteLine()
                End
            End If


            gp = P1 + P2 + P3 + P4 + P5 + P6 + P7 + P8 + P9 + P10 + P11
            cgpa = gp / 23
            gpa_txt.Text = gp
            cgpa_txt.Text = cgpa.ToString("N2")

            If (cgpa >= 3.6) And (cgpa <= 5.0) Then
                grade_lbl.Text = "First Class"

            ElseIf (cgpa >= 3.0) And (cgpa <= 3.5) Then
                grade_lbl.Text = "Seconds Class Upper"

            ElseIf (cgpa >= 2.5) And (cgpa <= 2.99) Then
                grade_lbl.Text = "Second Class Lower"

            ElseIf (cgpa >= 2.0) And (cgpa <= 2.49) Then
                grade_lbl.Text = "Pass"

            Else
                grade_lbl.Text = "Fair"
            End If


        End If
    End Sub

    '--------------------------- 100L SECOND SEMESTER------------------------------------

    Private Sub cal_sec_sem_hund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_sec_sem_hund.Click

        If ComboBox1.SelectedIndex = "0" And two_hundre_CheckBox2.Checked = True Then

        ElseIf (gst102_txt.Text = "") Or (gst104_txt.Text = "") Or (chm102_txt.Text = "") Or (bio191_txt.Text = "") Or (bio102_txt.Text = "") Or (cit102_txt.Text = "") Or (cit104_txt.Text = "") Or (stt102_txt.Text = "") Or (bio191_txt.Text = "") Or (mth102_txt.Text = "") Or (chm192_txt.Text = "") Or (phy102_txt.Text = "") Or (phy192_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            GST102 = gst102_txt.Text
            If GST102 >= 70 And GST102 <= 100 Then
                C1 = 5 * 2
            ElseIf GST102 >= 60 And GST102 <= 69 Then
                C1 = 4 * 2
            ElseIf GST102 >= 50 And GST102 <= 59 Then
                C1 = 3 * 2
            ElseIf GST102 >= 45 And GST102 <= 49 Then
                C1 = 2 * 2
            ElseIf GST102 >= 40 And GST102 <= 44 Then
                C1 = 1 * 2
            Else
                C1 = 0 * 2

            End If

            GST104 = gst104_txt.Text
            If GST104 >= 70 And GST104 <= 100 Then
                C2 = 5 * 2
            ElseIf GST104 >= 60 And GST104 <= 69 Then
                C2 = 4 * 2
            ElseIf GST104 >= 50 And GST104 <= 59 Then
                C2 = 3 * 2
            ElseIf GST104 >= 45 And GST104 <= 49 Then
                P1 = 2 * 2
            ElseIf GST104 >= 40 And GST104 <= 44 Then
                C2 = 1 * 2
            Else
                C2 = 0 * 2

            End If



            CHM102 = chm102_txt.Text
            If CHM102 >= 70 And CHM102 <= 100 Then
                C3 = 5 * 2
            ElseIf CHM102 >= 60 And CHM102 <= 69 Then
                C3 = 4 * 2
            ElseIf CHM102 >= 50 And CHM102 <= 59 Then
                C3 = 3 * 2
            ElseIf CHM102 >= 45 And CHM102 <= 49 Then
                C3 = 2 * 2
            ElseIf CHM102 >= 40 And CHM102 <= 44 Then
                C3 = 1 * 2
            Else
                C3 = 0 * 2

            End If



            CIT102 = cit102_txt.Text
            If CIT102 >= 70 And CIT102 <= 100 Then
                C4 = 5 * 2
            ElseIf CIT102 >= 60 And CIT102 <= 69 Then
                C4 = 4 * 2
            ElseIf CIT102 >= 50 And CIT102 <= 59 Then
                C4 = 3 * 2
            ElseIf CIT102 >= 45 And CIT102 <= 49 Then
                C4 = 2 * 2
            ElseIf CIT102 >= 40 And CIT102 <= 44 Then
                C4 = 1 * 2
            Else
                C4 = 0 * 2

            End If


            CIT104 = cit104_txt.Text
            If CIT104 >= 70 And CIT104 <= 100 Then
                C5 = 5 * 2
            ElseIf CIT104 >= 60 And CIT104 <= 69 Then
                C5 = 4 * 2
            ElseIf CIT104 >= 50 And CIT104 <= 59 Then
                C5 = 3 * 2
            ElseIf CIT104 >= 45 And CIT104 <= 49 Then
                C5 = 2 * 2
            ElseIf CIT104 >= 40 And CIT104 <= 44 Then
                C5 = 1 * 2
            Else
                C5 = 0 * 2

            End If


            STT102 = stt102_txt.Text
            If STT102 >= 70 And STT102 <= 100 Then
                P1 = 5 * 2
            ElseIf STT102 >= 60 And STT102 <= 69 Then
                C6 = 4 * 2
            ElseIf STT102 >= 50 And STT102 <= 59 Then
                C6 = 3 * 2
            ElseIf STT102 >= 45 And STT102 <= 49 Then
                C6 = 2 * 2
            ElseIf STT102 >= 40 And STT102 <= 44 Then
                C6 = 1 * 2
            Else
                C6 = 0 * 2

            End If


            MTH102 = mth102_txt.Text
            If MTH102 >= 70 And MTH102 <= 100 Then
                C7 = 5 * 2
            ElseIf MTH102 >= 60 And MTH102 <= 69 Then
                C7 = 4 * 2
            ElseIf MTH102 >= 50 And MTH102 <= 59 Then
                C7 = 3 * 2
            ElseIf MTH102 >= 45 And MTH102 <= 49 Then
                C7 = 2 * 2
            ElseIf MTH102 >= 40 And MTH102 <= 44 Then
                C7 = 1 * 2
            Else
                C7 = 0 * 2

            End If


            BIO102 = bio102_txt.Text
            If BIO102 >= 70 And BIO102 <= 100 Then
                C8 = 5 * 2
            ElseIf BIO102 >= 60 And BIO102 <= 69 Then
                C8 = 4 * 2
            ElseIf BIO102 >= 50 And BIO102 <= 59 Then
                C8 = 3 * 2
            ElseIf BIO102 >= 45 And BIO102 <= 49 Then
                C8 = 2 * 2
            ElseIf BIO102 >= 40 And GST101 <= 44 Then
                C8 = 1 * 2
            Else
                C8 = 0 * 2

            End If


            bio191_txt.Text = BIO191
            If BIO192 >= 70 And BIO192 <= 100 Then
                C9 = 5 * 1
            ElseIf BIO192 >= 60 And BIO192 <= 69 Then
                C9 = 4 * 1
            ElseIf BIO192 >= 50 And BIO192 <= 59 Then
                C9 = 3 * 1
            ElseIf BIO192 >= 45 And BIO192 <= 49 Then
                C9 = 2 * 1
            ElseIf BIO192 >= 40 And BIO192 <= 44 Then
                C9 = 1 * 1
            Else
                C9 = 0 * 1

            End If


            CHM192 = chm192_txt.Text
            If CHM192 >= 70 And CHM192 <= 100 Then
                C10 = 5 * 1
            ElseIf CHM192 >= 60 And CHM192 <= 69 Then
                C10 = 4 * 1
            ElseIf CHM192 >= 50 And CHM192 <= 59 Then
                C10 = 3 * 1
            ElseIf CHM192 >= 45 And CHM192 <= 49 Then
                C10 = 2 * 1
            ElseIf CHM192 >= 40 And CHM192 <= 44 Then
                C10 = 1 * 1
            Else
                C10 = 0 * 1

            End If


            PHY192 = phy192_txt.Text
            If PHY192 >= 70 And PHY192 <= 100 Then
                C11 = 5 * 1
            ElseIf PHY192 >= 60 And PHY192 <= 69 Then
                C11 = 4 * 1
            ElseIf PHY192 >= 50 And PHY192 <= 59 Then
                C11 = 3 * 1
            ElseIf PHY192 >= 45 And PHY192 <= 49 Then
                C11 = 2 * 1
            ElseIf PHY192 >= 40 And PHY192 <= 44 Then
                C11 = 1 * 1
            Else
                C11 = 0 * 1

            End If


            PHY102 = phy102_txt.Text
            If PHY102 >= 70 And PHY102 <= 100 Then
                C12 = 5 * 3
            ElseIf PHY102 >= 60 And PHY102 <= 69 Then
                C12 = 4 * 3
            ElseIf PHY102 >= 50 And PHY102 <= 59 Then
                C12 = 3 * 3
            ElseIf PHY102 >= 45 And PHY102 <= 49 Then
                C12 = 2 * 3
            ElseIf PHY102 >= 40 And PHY102 <= 44 Then
                C12 = 1 * 3
            Else
                C12 = 0 * 3

            End If



            gp2 = C1 + C1 + C3 + C4 + C5 + C6 + C7 + C8 + C9 + C10 + C11 + C12
            cgpa2 = gp2 / 22

            gpa_sec_sem_hund_txt.Text = gp2
            cgpa_sec_sem_hund_txt.Text = cgpa2.ToString("N2")

            If (cgpa2 >= 3.6) And (cgpa2 <= 5.0) Then
                grade_sec_sem_hund.Text = "First Class"

            ElseIf (cgpa2 >= 3.0) And (cgpa2 <= 3.5) Then
                grade_sec_sem_hund.Text = "Seconds Class Upper"

            ElseIf (cgpa2 >= 2.5) And (cgpa2 <= 2.99) Then
                grade_sec_sem_hund.Text = "Second Class Lower"

            ElseIf (cgpa2 >= 2.0) And (cgpa2 <= 2.49) Then
                grade_sec_sem_hund.Text = "Pass"

            Else
                grade_sec_sem_hund.Text = "Fair"
            End If
        End If
    End Sub



    '--------------------------- 200L FIRST SEMESTER------------------------------------

    Private Sub cal_firstsem_twohund_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_firstsem_twohund_btn.Click

        If (gst201_txt.Text = "") Or (gst203_txt.Text = "") Or (cit211_txt.Text = "") Or (cit215_txt.Text = "") Or (cit237_txt.Text = "") Or (mth213_txt.Text = "") Or (mth281_txt.Text = "") Or (chm191_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            GST201 = gst201_txt.Text
            If GST201 >= 70 And GST201 <= 100 Then
                K1 = 5 * 2
            ElseIf GST201 >= 60 And GST201 <= 69 Then
                K1 = 4 * 2
            ElseIf GST201 >= 50 And GST201 <= 59 Then
                K1 = 3 * 2
            ElseIf GST201 >= 45 And GST201 <= 49 Then
                K1 = 2 * 2
            ElseIf GST201 >= 40 And GST201 <= 44 Then
                K1 = 1 * 2
            Else
                K1 = 0 * 2
            End If


            GST203 = gst203_txt.Text
            If GST203 >= 70 And GST203 <= 100 Then
                K2 = 5 * 2
            ElseIf GST203 >= 60 And GST203 <= 69 Then
                K2 = 4 * 2
            ElseIf GST203 >= 50 And GST203 <= 59 Then
                K2 = 3 * 2
            ElseIf GST203 >= 45 And GST203 <= 49 Then
                K2 = 2 * 2
            ElseIf GST203 >= 40 And GST203 <= 44 Then
                K2 = 1 * 2
            Else
                K2 = 0 * 2
            End If


            CIT211 = cit211_txt.Text
            If CIT211 >= 70 And CIT211 <= 100 Then
                K3 = 5 * 3
            ElseIf CIT211 >= 60 And CIT211 <= 69 Then
                K3 = 4 * 3
            ElseIf CIT211 >= 50 And CIT211 <= 59 Then
                K3 = 3 * 3
            ElseIf CIT211 >= 45 And CIT211 <= 49 Then
                K3 = 2 * 3
            ElseIf CIT211 >= 40 And CIT211 <= 44 Then
                K3 = 1 * 3
            Else
                K3 = 0 * 3
            End If


            CIT215 = cit215_txt.Text
            If CIT215 >= 70 And CIT215 <= 100 Then
                K4 = 5 * 3
            ElseIf CIT215 >= 60 And CIT215 <= 69 Then
                K4 = 4 * 3
            ElseIf CIT215 >= 50 And CIT215 <= 59 Then
                K4 = 3 * 3
            ElseIf CIT215 >= 45 And CIT215 <= 49 Then
                K4 = 2 * 3
            ElseIf CIT215 >= 40 And CIT215 <= 44 Then
                K4 = 1 * 3
            Else
                K4 = 0 * 3
            End If

            CIT237 = cit237_txt.Text
            If CIT237 >= 70 And CIT237 <= 100 Then
                K5 = 5 * 3
            ElseIf CIT237 >= 60 And CIT237 <= 69 Then
                K5 = 4 * 3
            ElseIf CIT237 >= 50 And CIT237 <= 59 Then
                K5 = 3 * 3
            ElseIf CIT237 >= 45 And CIT237 <= 49 Then
                K5 = 2 * 3
            ElseIf CIT237 >= 40 And CIT237 <= 44 Then
                K5 = 1 * 3
            Else
                K5 = 0 * 3
            End If


            MTH211 = mth211_txt.Text
            If MTH211 >= 70 And MTH211 <= 100 Then
                K6 = 5 * 3
            ElseIf MTH211 >= 60 And MTH211 <= 69 Then
                K6 = 4 * 3
            ElseIf MTH211 >= 50 And MTH211 <= 59 Then
                K6 = 3 * 3
            ElseIf MTH211 >= 45 And MTH211 <= 49 Then
                K6 = 2 * 3
            ElseIf MTH211 >= 40 And MTH211 <= 44 Then
                K6 = 1 * 3
            Else
                K6 = 0 * 3
            End If


            MTH213 = mth213_txt.Text
            If MTH213 >= 70 And MTH213 <= 100 Then
                K7 = 5 * 3
            ElseIf MTH213 >= 60 And MTH213 <= 69 Then
                K7 = 4 * 3
            ElseIf MTH213 >= 50 And MTH213 <= 59 Then
                K7 = 3 * 3
            ElseIf MTH213 >= 45 And MTH213 <= 49 Then
                K7 = 2 * 3
            ElseIf MTH213 >= 40 And MTH213 <= 44 Then
                K7 = 1 * 3
            Else
                K7 = 0 * 3
            End If


            MTH281 = mth281_txt.Text
            If MTH281 >= 70 And MTH281 <= 100 Then
                K8 = 5 * 3
            ElseIf MTH281 >= 60 And MTH281 <= 69 Then
                K8 = 4 * 3
            ElseIf MTH281 >= 50 And MTH281 <= 59 Then
                K8 = 3 * 3
            ElseIf MTH281 >= 45 And MTH281 <= 49 Then
                K8 = 2 * 3
            ElseIf MTH281 >= 40 And MTH281 <= 44 Then
                K8 = 1 * 3
            Else
                K8 = 0 * 3
            End If
            Console.WriteLine()

            CHM191 = chm191_txt.Text
            If CHM191 >= 70 And CHM191 <= 100 Then
                P12 = 5 * 1
            ElseIf CHM191 >= 60 And CHM191 <= 69 Then
                P12 = 4 * 1
            ElseIf CHM191 >= 50 And CHM191 <= 59 Then
                P12 = 3 * 1
            ElseIf CHM191 >= 45 And CHM191 <= 49 Then
                P12 = 2 * 1
            ElseIf CHM191 >= 40 And CHM191 <= 44 Then
                P12 = 1 * 1
            ElseIf (CHM191 >= 0) And (CHM191 <= 39) Then
                P12 = 0 * 2
            Else


            End If

            gp3 = K1 + K2 + K3 + K4 + K5 + K6 + K7 + K8 + P12
            cgpa3 = gp3 / 23
            gpa_firstsem_twohund_txt.Text = gp3
            gpa_firstsem_twohund_txt.Text = cgpa3.ToString("N2")


            If (cgpa3 >= 3.6) And (cgpa3 <= 5.0) Then
                grade_firstsem_twohund_lbl.Text = "First Class"

            ElseIf (cgpa3 >= 3.0) And (cgpa3 <= 3.5) Then
                grade_firstsem_twohund_lbl.Text = "Seconds Class Upper"

            ElseIf (cgpa3 >= 2.5) And (cgpa3 <= 2.99) Then
                grade_firstsem_twohund_lbl.Text = "Second Class Lower"

            ElseIf (cgpa3 >= 2.0) And (cgpa3 <= 2.49) Then
                grade_firstsem_twohund_lbl.Text = "Pass"

            Else
                grade_firstsem_twohund_lbl.Text = "Fair"
            End If

        End If
    End Sub


    '--------------------------- 200L SECOND SEMESTER------------------------------------

    Private Sub cal_second_smt_twohred_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_second_smt_twohred_lvl_btn.Click

        If (gst204_txt.Text = "") Or (gst202_txt.Text = "") Or (cit208_txt.Text = "") Or (cit212_txt.Text = "") Or (cit236_txt.Text = "") Or (mth212_txt.Text = "") Or (mth232_txt.Text = "") Or (mth282_txt.Text = "") Or (phy191_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else




            GST202 = gst202_txt.Text
            If GST202 >= 70 And GST202 <= 100 Then
                A1 = 5 * 2
            ElseIf GST202 >= 60 And GST202 <= 69 Then
                A1 = 4 * 2
            ElseIf GST202 >= 50 And GST202 <= 59 Then
                A1 = 3 * 2
            ElseIf GST202 >= 45 And GST202 <= 49 Then
                A1 = 2 * 2
            ElseIf GST202 >= 40 And GST202 <= 44 Then
                A1 = 1 * 2
            Else
                A1 = 0 * 2
            End If


            GST204 = gst204_txt.Text
            If GST204 >= 70 And GST204 <= 100 Then
                A2 = 5 * 2
            ElseIf GST204 >= 60 And GST204 <= 69 Then
                A2 = 4 * 2
            ElseIf GST204 >= 50 And GST204 <= 59 Then
                A2 = 3 * 2
            ElseIf GST204 >= 45 And GST204 <= 49 Then
                A2 = 2 * 2
            ElseIf GST204 >= 40 And GST204 <= 44 Then
                A2 = 1 * 2
            Else
                A2 = 0 * 2
            End If


            CIT208 = cit208_txt.Text
            If CIT208 >= 70 And CIT208 <= 100 Then
                A3 = 5 * 2
            ElseIf CIT208 >= 60 And CIT208 <= 69 Then
                A3 = 4 * 2
            ElseIf CIT208 >= 50 And CIT208 <= 59 Then
                A3 = 3 * 2
            ElseIf CIT208 >= 45 And CIT208 <= 49 Then
                A3 = 2 * 2
            ElseIf CIT208 >= 40 And MTH213 <= 44 Then
                A3 = 1 * 2
            Else
                A3 = 0 * 2
            End If


            CIT212 = cit212_txt.Text
            If CIT212 >= 70 And CIT212 <= 100 Then
                A4 = 5 * 3
            ElseIf CIT212 >= 60 And CIT212 <= 69 Then
                A4 = 4 * 3
            ElseIf CIT212 >= 50 And CIT212 <= 59 Then
                A4 = 3 * 3
            ElseIf CIT212 >= 45 And CIT212 <= 49 Then
                A4 = 2 * 3
            ElseIf CIT212 >= 40 And CIT212 <= 44 Then
                A4 = 1 * 3
            Else
                A4 = 0 * 3
            End If

            CIT236 = cit236_txt.Text
            If CIT236 >= 70 And CIT236 <= 100 Then
                A5 = 5 * 3
            ElseIf CIT236 >= 60 And CIT236 <= 69 Then
                A5 = 4 * 3
            ElseIf CIT236 >= 50 And CIT236 <= 59 Then
                A5 = 3 * 3
            ElseIf CIT236 >= 45 And CIT236 <= 49 Then
                A5 = 2 * 3
            ElseIf CIT236 >= 40 And CIT236 <= 44 Then
                A5 = 1 * 3
            Else
                A5 = 0 * 3
            End If


            MTH212 = mth212_txt.Text
            If MTH212 >= 70 And MTH212 <= 100 Then
                A7 = 5 * 3
            ElseIf MTH212 >= 60 And MTH212 <= 69 Then
                A7 = 4 * 3
            ElseIf MTH212 >= 50 And MTH212 <= 59 Then
                A7 = 3 * 3
            ElseIf MTH212 >= 45 And MTH212 <= 49 Then
                A7 = 2 * 3
            ElseIf MTH212 >= 40 And MTH212 <= 44 Then
                A7 = 1 * 3
            Else
                A7 = 0 * 3
            End If


            MTH232 = mth232_txt.Text
            If MTH232 >= 70 And MTH232 <= 100 Then
                A10 = 5 * 3
            ElseIf MTH232 >= 60 And MTH232 <= 69 Then
                A10 = 4 * 3
            ElseIf MTH232 >= 50 And MTH232 <= 59 Then
                A10 = 3 * 3
            ElseIf MTH232 >= 45 And MTH232 <= 49 Then
                A10 = 2 * 3
            ElseIf MTH232 >= 40 And MTH232 <= 44 Then
                A10 = 1 * 3
            Else
                A10 = 0 * 3
            End If


            MTH282 = mth282_txt.Text
            If MTH282 >= 70 And MTH282 <= 100 Then
                A8 = 5 * 3
            ElseIf MTH282 >= 60 And MTH282 <= 69 Then
                A8 = 4 * 3
            ElseIf MTH282 >= 50 And MTH282 <= 59 Then
                A8 = 3 * 3
            ElseIf MTH282 >= 45 And MTH282 <= 49 Then
                A8 = 2 * 3
            ElseIf MTH282 >= 40 And MTH282 <= 44 Then
                A8 = 1 * 3
            Else
                A8 = 0 * 3
            End If


            PHY191 = phy191_txt.Text
            If PHY191 >= 70 And PHY191 <= 100 Then
                P13 = 5 * 1
            ElseIf PHY191 >= 60 And PHY191 <= 69 Then
                P13 = 4 * 1
            ElseIf PHY191 >= 50 And PHY191 <= 59 Then
                P13 = 3 * 1
            ElseIf PHY191 >= 45 And PHY191 <= 49 Then
                P13 = 2 * 1
            ElseIf PHY191 >= 40 And PHY191 <= 44 Then
                P13 = 1 * 1
            ElseIf (PHY191 >= 0) And (PHY191 <= 39) Then
                P13 = 0 * 1
            Else

            End If

            gp4 = A1 + A2 + A3 + A4 + A5 + A7 + A8 + A10 + P13
            cgpa4 = gp4 / 22
            gpa_second_smt_twohred_lvl_txt.Text = gp4
            cgpa_second_smt_twohred_lvl_txt.Text = cgpa4.ToString("N2")

            If (cgpa4 >= 3.6) And (cgpa4 <= 5.0) Then
                grade_second_smt_twohred_lvl_lbl.Text = "First Class"

            ElseIf (cgpa4 >= 3.0) And (cgpa4 <= 3.5) Then
                grade_second_smt_twohred_lvl_lbl.Text = "Seconds Class Upper"

            ElseIf (cgpa4 >= 2.5) And (cgpa4 <= 2.99) Then
                grade_second_smt_twohred_lvl_lbl.Text = "Second Class Lower"

            ElseIf (cgpa4 >= 2.0) And (cgpa4 <= 2.49) Then
                grade_second_smt_twohred_lvl_lbl.Text = "Pass"

            Else
                grade_second_smt_twohred_lvl_lbl.Text = "Fair"
            End If



        End If
    End Sub


    '--------------------------- 300L FIRST SEMESTER------------------------------------


    Private Sub calfirst_smt_threehundred_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calfirst_smt_threehundred_lvl_btn.Click

        If (cit303_txt.Text = "") Or (cit381_txt.Text = "") Or (cit389_txt.Text = "") Or (cit305_txt.Text = "") Or (cit236_txt.Text = "") Or (cit309_txt.Text = "") Or (cit311_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            CIT303 = cit303_txt.Text
            If CIT303 >= 70 And CIT303 <= 100 Then
                B1 = 5 * 3
            ElseIf CIT303 >= 60 And CIT303 <= 69 Then
                B1 = 4 * 3
            ElseIf CIT303 >= 50 And CIT303 <= 59 Then
                B1 = 3 * 3
            ElseIf CIT303 >= 45 And CIT303 <= 49 Then
                B1 = 2 * 3
            ElseIf CIT303 >= 40 And CIT303 <= 44 Then
                B1 = 1 * 3
            Else
                B1 = 0 * 3
            End If


            CIT305 = cit305_txt.Text
            If CIT305 >= 70 And CIT305 <= 100 Then
                B2 = 5 * 3
            ElseIf CIT305 >= 60 And CIT305 <= 69 Then
                B2 = 4 * 3
            ElseIf CIT305 >= 50 And CIT305 <= 59 Then
                B2 = 3 * 3
            ElseIf CIT305 >= 45 And CIT305 <= 49 Then
                B2 = 2 * 3
            ElseIf CIT305 >= 40 And CIT305 <= 44 Then
                B2 = 1 * 3
            Else
                B2 = 0 * 3
            End If


            CIT309 = cit309_txt.Text
            If CIT309 >= 70 And CIT309 <= 100 Then
                B3 = 5 * 3
            ElseIf CIT309 >= 60 And CIT309 <= 69 Then
                B3 = 4 * 3
            ElseIf CIT309 >= 50 And CIT309 <= 59 Then
                B3 = 3 * 3
            ElseIf CIT309 >= 45 And CIT309 <= 49 Then
                B3 = 2 * 3
            ElseIf CIT309 >= 40 And CIT309 <= 44 Then
                B3 = 1 * 3
            Else
                B3 = 0 * 3
            End If


            CIT311 = cit311_txt.Text
            If CIT311 >= 70 And CIT311 <= 100 Then
                B4 = 5 * 3
            ElseIf CIT311 >= 60 And CIT311 <= 69 Then
                B4 = 4 * 3
            ElseIf CIT311 >= 50 And CIT311 <= 59 Then
                B4 = 3 * 3
            ElseIf CIT311 >= 45 And CIT311 <= 49 Then
                B4 = 2 * 3
            ElseIf CIT311 >= 40 And CIT311 <= 44 Then
                B4 = 1 * 3
            Else
                B4 = 0 * 3
            End If



            CIT381 = cit381_txt.Text
            If CIT381 >= 70 And CIT381 <= 100 Then
                B7 = 5 * 3
            ElseIf CIT381 >= 60 And CIT381 <= 69 Then
                B7 = 4 * 3
            ElseIf CIT381 >= 50 And CIT381 <= 59 Then
                B7 = 3 * 3
            ElseIf CIT381 >= 45 And CIT381 <= 49 Then
                B7 = 2 * 3
            ElseIf CIT381 >= 40 And CIT381 <= 44 Then
                B7 = 1 * 3
            Else
                B7 = 0 * 3
            End If


            CIT389 = cit389_txt.Text
            If CIT389 >= 70 And CIT389 <= 100 Then
                B8 = 5 * 6
            ElseIf CIT389 >= 60 And CIT389 <= 69 Then
                B8 = 4 * 6
            ElseIf CIT389 >= 50 And CIT389 <= 59 Then
                B8 = 3 * 6
            ElseIf CIT389 >= 45 And CIT389 <= 49 Then
                B8 = 2 * 6
            ElseIf CIT389 >= 40 And CIT389 <= 44 Then
                B8 = 1 * 6
            Else
                B8 = 0 * 6
            End If
            Console.WriteLine()

            gp5 = B1 + B2 + B3 + B4 + B5 + B6 + B7 + B8
            cgpa5 = gp5 / 27
            gpafirst_smt_threehundred_lvl_txt.Text = gp5
            cgpafirst_smt_threehundred_lvl__txt.Text = cgpa5.ToString("N2")

            If (cgpa5 >= 3.6) And (cgpa5 <= 5.0) Then
                gradefirst_smt_threehundred_lvl_lbl.Text = "First Class"

            ElseIf (cgpa5 >= 3.0) And (cgpa5 <= 3.5) Then
                gradefirst_smt_threehundred_lvl_lbl.Text = "Seconds Class Upper"

            ElseIf (cgpa5 >= 2.5) And (cgpa5 <= 2.99) Then
                gradefirst_smt_threehundred_lvl_lbl.Text = "Second Class Lower"

            ElseIf (cgpa5 >= 2.0) And (cgpa5 <= 2.49) Then
                gradefirst_smt_threehundred_lvl_lbl.Text = "Pass"

            Else
                gradefirst_smt_threehundred_lvl_lbl.Text = "Fair"
            End If

        End If
    End Sub


    '--------------------------- 300L SECOND SEMESTER------------------------------------

    Private Sub cal_second_smt_threehundred_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_second_smt_threehundred_lvl_btn.Click

        If (gst302_txt.Text = "") Or (cit344_txt.Text = "") Or (cit342_txt.Text = "") Or (cit392_txt.Text = "") Or (dam382_txt.Text = "") Or (dam364_txt.Text = "") Or (dam301_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            GST302 = gst302_txt.Text
            If GST302 >= 70 And GST302 <= 100 Then
                R1 = 5 * 2
            ElseIf GST302 >= 60 And GST302 <= 69 Then
                R1 = 4 * 2
            ElseIf GST302 >= 50 And GST302 <= 59 Then
                R1 = 3 * 2
            ElseIf GST302 >= 45 And GST302 <= 49 Then
                R1 = 2 * 2
            ElseIf GST302 >= 40 And GST302 <= 44 Then
                R1 = 1 * 2
            Else
                R1 = 0 * 2
            End If


            CIT344 = cit344_txt.Text
            If CIT322 >= 70 And CIT322 <= 100 Then
                R2 = 5 * 3
            ElseIf CIT322 >= 60 And CIT322 <= 69 Then
                R2 = 4 * 3
            ElseIf CIT322 >= 50 And CIT322 <= 59 Then
                R2 = 3 * 3
            ElseIf CIT322 >= 45 And CIT322 <= 49 Then
                R2 = 2 * 3
            ElseIf CIT322 >= 40 And CIT322 <= 44 Then
                R2 = 1 * 3
            Else
                R2 = 0 * 3
            End If


            CIT342 = cit342_txt.Text
            If CIT342 >= 70 And CIT342 <= 100 Then
                R3 = 5 * 3
            ElseIf CIT371 >= 60 And CIT342 <= 69 Then
                R3 = 4 * 3
            ElseIf CIT342 >= 50 And CIT342 <= 59 Then
                R3 = 3 * 3
            ElseIf CIT342 >= 45 And CIT342 <= 49 Then
                R3 = 2 * 3
            ElseIf CIT342 >= 40 And CIT342 <= 44 Then
                R3 = 1 * 3
            Else
                R3 = 0 * 3
            End If



            CIT392 = cit392_txt.Text
            If CIT392 >= 70 And CIT392 <= 100 Then
                R5 = 5 * 2
            ElseIf CIT392 >= 60 And CIT392 <= 69 Then
                R5 = 4 * 2
            ElseIf CIT392 >= 50 And CIT392 <= 59 Then
                R5 = 3 * 2
            ElseIf CIT392 >= 45 And CIT392 <= 49 Then
                R5 = 2 * 2
            ElseIf CIT392 >= 40 And CIT392 <= 44 Then
                R5 = 1 * 2
            Else
                R5 = 0 * 2
            End If


            DAM301 = dam301_txt.Text
            If DAM301 >= 70 And DAM301 <= 100 Then
                R6 = 5 * 3
            ElseIf DAM301 >= 60 And DAM301 <= 69 Then
                R6 = 4 * 3
            ElseIf DAM301 >= 50 And DAM301 <= 59 Then
                R6 = 3 * 3
            ElseIf DAM301 >= 45 And DAM301 <= 49 Then
                R6 = 2 * 3
            ElseIf DAM301 >= 40 And DAM301 <= 44 Then
                R6 = 1 * 3
            Else
                R6 = 0 * 3
            End If



            DAM364 = dam364_txt.Text
            If DAM364 >= 70 And DAM364 <= 100 Then
                R8 = 5 * 2
            ElseIf DAM364 >= 60 And DAM364 <= 69 Then
                R8 = 4 * 2
            ElseIf DAM364 >= 50 And DAM364 <= 59 Then
                R8 = 3 * 2
            ElseIf DAM364 >= 45 And DAM364 <= 49 Then
                R8 = 2 * 2
            ElseIf DAM364 >= 40 And DAM364 <= 44 Then
                R8 = 1 * 2
            Else
                R8 = 0 * 2
            End If


            DAM382 = dam382_txt.Text
            If DAM382 >= 70 And DAM382 <= 100 Then
                R9 = 5 * 3
            ElseIf DAM382 >= 60 And DAM382 <= 69 Then
                R9 = 4 * 3
            ElseIf DAM382 >= 50 And DAM382 <= 59 Then
                R9 = 3 * 3
            ElseIf DAM382 >= 45 And DAM382 <= 49 Then
                R9 = 2 * 3
            ElseIf DAM382 >= 40 And DAM382 <= 44 Then
                R9 = 1 * 3
            Else
                R9 = 0 * 3
            End If
            Console.WriteLine()

            gp6 = R1 + R2 + R3 + R5 + R6 + R8 + R9
            cgpa6 = gp6 / 23
            gpa_econd_smt_threehundred_lvl_txt.Text = gp6
            cgpa_second_smt_threehundred_lvl_txt.Text = cgpa6.ToString("N2")

            If (cgpa6 >= 3.6) And (cgpa6 <= 5.0) Then
                grade_second_smt_threehundred_lvl_lbl.Text = "First Class"

            ElseIf (cgpa6 >= 3.0) And (cgpa6 <= 3.5) Then
                grade_second_smt_threehundred_lvl_lbl.Text = "Seconds Class Upper"

            ElseIf (cgpa6 >= 2.5) And (cgpa6 <= 2.99) Then
                grade_second_smt_threehundred_lvl_lbl.Text = "Second Class Lower"

            ElseIf (cgpa6 >= 2.0) And (cgpa6 <= 2.49) Then
                grade_second_smt_threehundred_lvl_lbl.Text = "Pass"

            Else
                grade_second_smt_threehundred_lvl_lbl.Text = "Fair"
            End If

        End If
    End Sub


    '--------------------------- 400L FIRST SEMESTER------------------------------------


    Private Sub cal_first_smt_four_hrd_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_first_smt_four_hrd_lvl_btn.Click

        If (cit403_txt.Text = "") Or (cit411_txt.Text = "") Or (cit415_txt.Text = "") Or (cit427_txt.Text = "") Or (cit445_txt.Text = "") Or (cit461_txt.Text = "") Or (cit463_txt.Text = "") Or (cit461_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            CIT403 = cit403_txt.Text
            If CIT403 >= 70 And CIT403 <= 100 Then
                Y1 = 5 * 3
            ElseIf CIT403 >= 60 And CIT403 <= 69 Then
                Y1 = 4 * 3
            ElseIf CIT403 >= 50 And CIT403 <= 59 Then
                Y1 = 3 * 3
            ElseIf CIT403 >= 45 And CIT403 <= 49 Then
                Y1 = 2 * 3
            ElseIf CIT403 >= 40 And CIT403 <= 44 Then
                Y1 = 1 * 3
            Else
                Y1 = 0 * 3
            End If


            CIT411 = cit411_txt.Text
            If CIT411 >= 70 And CIT411 <= 100 Then
                Y2 = 5 * 2
            ElseIf CIT411 >= 60 And CIT411 <= 69 Then
                Y2 = 4 * 2
            ElseIf CIT411 >= 50 And CIT411 <= 59 Then
                Y2 = 3 * 2
            ElseIf CIT411 >= 45 And CIT411 <= 49 Then
                Y2 = 2 * 2
            ElseIf CIT411 >= 40 And CIT411 <= 44 Then
                Y2 = 1 * 2
            Else
                Y2 = 0 * 2
            End If


            CIT415 = cit415_txt.Text
            If CIT415 >= 70 And CIT415 <= 100 Then
                Y3 = 5 * 3
            ElseIf CIT415 >= 60 And CIT415 <= 69 Then
                Y3 = 4 * 3
            ElseIf CIT415 >= 50 And CIT415 <= 59 Then
                Y3 = 3 * 3
            ElseIf CIT415 >= 45 And CIT415 <= 49 Then
                Y3 = 2 * 3
            ElseIf CIT415 >= 40 And CIT415 <= 44 Then
                Y3 = 1 * 3
            Else
                Y3 = 0 * 3
            End If


            CIT427 = cit427_txt.Text
            If CIT427 >= 70 And CIT427 <= 100 Then
                Y4 = 5 * 3
            ElseIf CIT427 >= 60 And CIT427 <= 69 Then
                Y4 = 4 * 3
            ElseIf CIT427 >= 50 And CIT427 <= 59 Then
                Y4 = 3 * 3
            ElseIf CIT427 >= 45 And CIT427 <= 49 Then
                Y4 = 2 * 3
            ElseIf CIT427 >= 40 And CIT427 <= 44 Then
                Y4 = 1 * 3
            Else
                Y4 = 0 * 3
            End If


            CIT445 = cit445_txt.Text
            If CIT445 >= 70 And CIT445 <= 100 Then
                Y5 = 5 * 3
            ElseIf CIT445 >= 60 And CIT445 <= 69 Then
                Y5 = 4 * 3
            ElseIf CIT445 >= 50 And CIT445 <= 59 Then
                Y5 = 3 * 3
            ElseIf CIT445 >= 45 And CIT445 <= 49 Then
                Y5 = 2 * 3
            ElseIf CIT445 >= 40 And CIT445 <= 44 Then
                Y5 = 1 * 3
            Else
                Y5 = 0 * 3
            End If


            CIT461 = cit461_txt.Text
            If CIT461 >= 70 And CIT461 <= 100 Then
                Y6 = 5 * 3
            ElseIf DAM382 >= 60 And CIT461 <= 69 Then
                Y6 = 4 * 3
            ElseIf CIT461 >= 50 And CIT461 <= 59 Then
                Y6 = 3 * 3
            ElseIf CIT461 >= 45 And CIT461 <= 49 Then
                Y6 = 2 * 3
            ElseIf CIT461 >= 40 And CIT461 <= 44 Then
                Y6 = 1 * 3
            Else
                Y6 = 0 * 3
            End If


            CIT463 = cit463_txt.Text
            If CIT463 >= 70 And CIT463 <= 100 Then
                Y8 = 5 * 3
            ElseIf CIT463 >= 60 And CIT463 <= 69 Then
                Y8 = 4 * 3
            ElseIf CIT463 >= 50 And CIT463 <= 59 Then
                Y8 = 3 * 3
            ElseIf CIT463 >= 45 And CIT463 <= 49 Then
                Y8 = 2 * 3
            ElseIf CIT463 >= 40 And CIT463 <= 44 Then
                Y8 = 1 * 3
            Else
                Y8 = 0 * 3
            End If


            CIT465 = cit465_txt.Text
            If CIT465 >= 70 And CIT465 <= 100 Then
                Y7 = 5 * 2
            ElseIf CIT465 >= 60 And CIT465 <= 69 Then
                Y7 = 4 * 2
            ElseIf CIT465 >= 50 And CIT465 <= 59 Then
                Y7 = 3 * 2
            ElseIf CIT465 >= 45 And CIT465 <= 49 Then
                Y7 = 2 * 2
            ElseIf CIT465 >= 40 And CIT465 <= 44 Then
                Y7 = 1 * 2
            Else
                Y7 = 0 * 2
            End If
            Console.WriteLine()

            gp7 = Y1 + Y2 + Y3 + Y4 + Y5 + Y6 + Y7 + R8
            cgpa7 = gp7 / 22
            gpa_first_smt_four_hrd_lvl_txt.Text = gp7
            cgpa_first_smt_four_hrd_lvl_txt.Text = cgpa7.ToString("N2")


            If (cgpa7 >= 3.6) And (cgpa7 <= 5.0) Then
                grade_first_smt_four_hrd_lvl_txt.Text = " First Class"

            ElseIf (cgpa7 >= 3.0) And (cgpa7 <= 3.5) Then
                grade_first_smt_four_hrd_lvl_txt.Text = "Seconds Class Upper"

            ElseIf (cgpa7 >= 2.5) And (cgpa7 <= 2.99) Then
                grade_first_smt_four_hrd_lvl_txt.Text = "Second Class Lower"

            ElseIf (cgpa7 >= 2.0) And (cgpa7 <= 2.49) Then
                grade_first_smt_four_hrd_lvl_txt.Text = "Pass"

            Else
                grade_first_smt_four_hrd_lvl_txt.Text = "Fair"
            End If

        End If
    End Sub


    '--------------------------- 400L SECOND SEMESTER------------------------------------

    Private Sub cal_second_smt_four_hrd_lvl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal_second_smt_four_hrd_lvl_btn.Click

        If (cit425_txt.Text = "") Or (cit474_txt.Text = "") Or (cit478_txt.Text = "") Or (cit484_txt.Text = "") Or (cit499_txt.Text = "") Or (dam461_txt.Text = "") Then
            MessageBox.Show("This field can't empty!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            CIT425 = cit425_txt.Text
            If CIT425 >= 70 And CIT425 <= 100 Then
                Q1 = 5 * 3
            ElseIf CIT425 >= 60 And CIT425 <= 69 Then
                Q1 = 4 * 3
            ElseIf CIT425 >= 50 And CIT425 <= 59 Then
                Q1 = 3 * 3
            ElseIf CIT425 >= 45 And CIT425 <= 49 Then
                Q1 = 2 * 3
            ElseIf CIT425 >= 40 And CIT425 <= 44 Then
                Q1 = 1 * 3
            Else
                Q1 = 0 * 3
            End If
            Console.WriteLine()


            CIT474 = cit474_txt.Text
            If CIT474 >= 70 And CIT474 <= 100 Then
                Q2 = 5 * 2
            ElseIf CIT474 >= 60 And CIT474 <= 69 Then
                Q2 = 4 * 2
            ElseIf CIT474 >= 50 And CIT474 <= 59 Then
                Q2 = 3 * 2
            ElseIf CIT474 >= 45 And CIT474 <= 49 Then
                Q2 = 2 * 2
            ElseIf CIT474 >= 40 And CIT474 <= 44 Then
                Q2 = 1 * 2
            Else
                Q2 = 0 * 2
            End If
            Console.WriteLine()


            CIT478 = cit474_txt.Text
            If CIT478 >= 70 And CIT478 <= 100 Then
                Q3 = 5 * 2
            ElseIf CIT478 >= 60 And CIT478 <= 69 Then
                Q3 = 4 * 2
            ElseIf CIT478 >= 50 And CIT478 <= 59 Then
                Q3 = 3 * 2
            ElseIf CIT478 >= 45 And CIT478 <= 49 Then
                Q3 = 2 * 2
            ElseIf CIT478 >= 40 And CIT478 <= 44 Then
                Q3 = 1 * 2
            Else
                Q3 = 0 * 2
            End If
            Console.WriteLine()


            CIT484 = cit484_txt.Text
            If CIT484 >= 70 And CIT484 <= 100 Then
                Q4 = 5 * 3
            ElseIf CIT484 >= 60 And CIT484 <= 69 Then
                Q4 = 4 * 3
            ElseIf CIT484 >= 50 And CIT484 <= 59 Then
                Q4 = 3 * 3
            ElseIf CIT484 >= 45 And CIT484 <= 49 Then
                Q4 = 2 * 3
            ElseIf CIT484 >= 40 And CIT484 <= 44 Then
                Q4 = 1 * 3
            Else
                Q4 = 0 * 3
            End If
            Console.WriteLine()


            CIT499 = cit499_txt.Text
            If CIT499 >= 70 And CIT499 <= 100 Then
                Q5 = 5 * 6
            ElseIf CIT499 >= 60 And CIT499 <= 69 Then
                Q5 = 4 * 6
            ElseIf CIT499 >= 50 And CIT499 <= 59 Then
                Q5 = 3 * 6
            ElseIf CIT499 >= 45 And CIT499 <= 49 Then
                Q5 = 2 * 6
            ElseIf CIT499 >= 40 And CIT499 <= 44 Then
                Q5 = 1 * 6
            Else
                Q5 = 0 * 6
            End If
            Console.WriteLine()


            DAM461 = dam461_txt.Text
            If DAM461 >= 70 And DAM461 <= 100 Then
                Q6 = 5 * 3
            ElseIf DAM461 >= 60 And DAM461 <= 69 Then
                Q6 = 4 * 3
            ElseIf DAM461 >= 50 And DAM461 <= 59 Then
                Q6 = 3 * 3
            ElseIf DAM461 >= 45 And DAM461 <= 49 Then
                Q6 = 2 * 3
            ElseIf DAM461 >= 40 And DAM461 <= 44 Then
                Q6 = 1 * 3
            Else
                Q6 = 0 * 3
            End If
            Console.WriteLine()

            gp8 = Q1 + Q2 + Q3 + Q4 + Q5 + Q6
            cgpa8 = gp8 / 19
            gpa_second_smt_four_hrd_lvl_txt.Text = gp8
            cgpa_second_smt_four_hrd_lvl_txt.Text = cgpa8.ToString("N2")

            If (cgpa8 >= 3.6) And (cgpa8 <= 5.0) Then
                grade_second_smt_four_hrd_lvl_lbl.Text = "First Class"

            ElseIf (cgpa8 >= 3.0) And (cgpa8 <= 3.5) Then
                grade_second_smt_four_hrd_lvl_lbl.Text = "Seconds Class Upper"

            ElseIf (cgpa8 >= 2.5) And (cgpa8 <= 2.99) Then
                grade_second_smt_four_hrd_lvl_lbl.Text = "Second Class Lower"

            ElseIf (cgpa8 >= 2.0) And (cgpa8 <= 2.49) Then
                grade_second_smt_four_hrd_lvl_lbl.Text = "Pass"

            Else
                grade_second_smt_four_hrd_lvl_lbl.Text = "Fair"
            End If

        End If
    End Sub


   
    ' CIT322_txt.KeyPress, CIT341_txt.KeyPress, CIT371_txt.KeyPress, DAM344_txt.KeyPress, PHY208_txt.KeyPress,

    Private Sub gst101_txt_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gst101_txt.KeyPress, bio101_txt.KeyPress, chm101_txt.KeyPress, phy101_txt.KeyPress, gst103_txt.KeyPress, gst107_txt.KeyPress, chm103_txt.KeyPress, mth101_txt.KeyPress, mth103_txt.KeyPress, bio191_txt.KeyPress, cit143_txt.KeyPress, gst102_txt.KeyPress,
        chm103_txt.KeyPress, cit143_txt.KeyPress, mth101_txt.KeyPress, mth103_txt.KeyPress, phy192_txt.KeyPress, bio191_txt.KeyPress, chm191_txt.KeyPress, phy191_txt.KeyPress, phy101_txt.KeyPress, gst102_txt.KeyPress, gst104_txt.KeyPress, chm102_txt.KeyPress, cit102_txt.KeyPress, cit104_txt.KeyPress,
         stt102_txt.KeyPress, mth102_txt.KeyPress, bio102_txt.KeyPress, bio192_txt.KeyPress, chm192_txt.KeyPress, phy102_txt.KeyPress, gst201_txt.KeyPress, gst203_txt.KeyPress, cit211_txt.KeyPress, cit215_txt.KeyPress, cit237_txt.KeyPress, mth211_txt.KeyPress, mth213_txt.KeyPress, mth281_txt.KeyPress,
     gst202_txt.KeyPress, gst204_txt.KeyPress, cit212_txt.KeyPress, cit236_txt.KeyPress, cit292_txt.KeyPress, cit208_txt.KeyPress, mth212_txt.KeyPress, mth232_txt.KeyPress, mth282_txt.KeyPress, cit392_txt.KeyPress, dam301_txt.KeyPress, dam364_txt.KeyPress, dam382_txt.KeyPress,
     cit303_txt.KeyPress, cit305_txt.KeyPress, cit309_txt.KeyPress, cit311_txt.KeyPress, cit381_txt.KeyPress, cit389_txt.KeyPress, gst302_txt.KeyPress, cit342_txt.KeyPress, cit344_txt.KeyPress, cit425_txt.KeyPress, cit474_txt.KeyPress, cit478_txt.KeyPress, cit484_txt.KeyPress, cit499_txt.KeyPress, dam461_txt.KeyPress,
     cit403_txt.KeyPress, cit411_txt.KeyPress, cit415_txt.KeyPress, cit427_txt.KeyPress, cit445_txt.KeyPress, cit461_txt.KeyPress, cit463_txt.KeyPress, cit465_txt.KeyPress




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


    Private Sub hundred_lvl_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hundred_lvl_btn.Click
        home_pnl.Hide()
        hundred_lvl_pnl.Show()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
    End Sub

    Private Sub twohutnndred_lvl_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles twohutnndred_lvl_b.Click
        home_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Show()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
    End Sub

    Private Sub threehutnndred_lvl_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles threehutnndred_lvl_b.Click
        home_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Show()
        four_hundred_lvl_pnl.Hide()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
    End Sub

    Private Sub fourhutnndred_lvl_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fourhutnndred_lvl_b.Click
        home_pnl.Hide()
        hundred_lvl_pnl.Hide()
        two_hundred_lvl_pnl.Hide()
        three_hundred_lvl_pnl.Hide()
        four_hundred_lvl_pnl.Show()
        first_smt_hundred_pnl.Hide()
        second_smt_hundred_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_threehundred_lvl_pnl.Hide()
        second_smt_threehundred_lvl_pnl.Hide()
        second_smt_twohred_lvl_pnl.Hide()
        first_smt_two_hred_lvl_pnl.Hide()
        first_smt_four_hrd_lvl_pnl.Hide()
        second_smt_four_hrd_lvl_pnl.Hide()
    End Sub


End Class