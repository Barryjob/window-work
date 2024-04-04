Public Class dashboard

    

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timec_lbl.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enrollment_btn.Click
        Biometric_Enrollment_form.ShowDialog()
        log_in_form.Hide()
        Me.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verification_btn.Click
        verificationm_form.ShowDialog()
        Biometric_Enrollment_form.Hide()
        log_in_form.Hide()
        Me.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Admin_btn.Click
        ContextMenuStrip1.Show(Admin_btn, New Point(0, Admin_btn.Height))
    End Sub



    Private Sub RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RToolStripMenuItem.Click
        Dim formodal As New Form
        Try
            Dim modal As New staff_registeration
            formodal.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            staff_registeration.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub log_out_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log_out_btn.Click
        verificationm_form.Hide()
        Biometric_Enrollment_form.Hide()
        log_in_form.Hide()
        clockIn_clockOut.Hide()
        log_out.ShowDialog()
        Me.Show()
    End Sub

    Private Sub settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.Click
        ContextMenuStrip2.Show(settings, New Point(0, settings.Height))
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim formodal As New Form
        Try
            Dim modal As New change_password
            formodal.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            change_password.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

    Private Sub ViewsEditUsersRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewsEditUsersRecordToolStripMenuItem.Click
        Dim formodal As New Form
        Try
            Dim modal As New report_reg
            formodal.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            report_reg.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub


    Private Sub Circleavatar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Circleavatar1.Click
        staff_details.ShowDialog()
        log_out.Hide()
        verificationm_form.Hide()
        Biometric_Enrollment_form.Hide()
        log_in_form.Hide()
        Me.Show()
       
            

    End Sub

    Private Sub attendance_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attendance_btn.Click
        ContextMenuStrip3.Show(attendance_btn, New Point(0, attendance_btn.Height))
    End Sub

    Private Sub ClockInClockOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockInClockOutToolStripMenuItem.Click
        Dim formodal As New Form
        Try
            Dim modal As New clockIn_clockOut
            formodal.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            formodal.Opacity = 0.5
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Show()
            modal.Owner = formodal

            clockIn_clockOut.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub

  
    Private Sub timec_lbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timec_lbl.Click

    End Sub
End Class