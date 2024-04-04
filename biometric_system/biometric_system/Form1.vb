Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        input_reg_pnl.Show()
        reg_pnl.Show()
        enrollment_pnl.Hide()
        scan_pnl.Hide()
        date_pnl.Show()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time_lbl.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub enrollment_pnl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles enrollment_pnl.Paint

    End Sub

    Private Sub input_reg_pnl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles input_reg_pnl.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), input_reg_pnl.ClientRectangle)
    End Sub

    Private Sub input_reg_pnl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles input_reg_pnl.Resize
        input_reg_pnl.Invalidate()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        user_biometric_enrollment.Show()
        input_reg_pnl.Hide()
       
        date_pnl.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clockin.Show()
        user_biometric_enrollment.Hide()
        input_reg_pnl.Hide()
        date_pnl.Hide()
    End Sub
End Class
