Public Class clockIn_clockOut

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles clockinandout.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), clockinandout.ClientRectangle)
    End Sub

    Private Sub clockinandout_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles clockinandout.Resize
        clockinandout.Invalidate()
    End Sub

    Private Sub clockIn_clockOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        timec_lbl.Text = "Time " & TimeOfDay & " Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub
End Class