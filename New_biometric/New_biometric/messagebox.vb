﻿Public Class messagebox
    Dim count As Integer

    Private Sub EmptyMBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToParent()

        For counter = 0 To 80 Step 10
            count = counter
            Me.Opacity = count / 70
            Me.Refresh()
            Threading.Thread.Sleep(30)
        Next counter

    End Sub
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        ' Threading.Thread.Sleep(1000)
        For counters = 80 To 0 Step -10
            count = counters
            Me.Opacity = count / 70
            Me.Refresh()
            Threading.Thread.Sleep(30)
        Next counters
        'Me.Dispose()
        Me.Close()
    End Sub
End Class