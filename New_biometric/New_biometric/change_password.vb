Public Class change_password

    Private Sub Guna2Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change_password_submit_btn.Click

    End Sub

    Private Sub change_password_exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change_password_exit_btn.Click
        Me.Close()
        verificationm_form.Hide()
        Biometric_Enrollment_form.Hide()
        log_in_form.Hide()
        dashboard.Show()
    End Sub

    Private Sub change_password_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change_password_close_btn.Click
        Me.Close()
        dashboard.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            current_pass_txt.UseSystemPasswordChar = True
            CheckBox1.BackgroundImage = My.Resources.eye5
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch
        Else
            current_pass_txt.UseSystemPasswordChar = False
            CheckBox1.BackgroundImage = My.Resources.pngwing_com
            CheckBox1.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            new_pass_txt.UseSystemPasswordChar = True
            CheckBox2.BackgroundImage = My.Resources.eye5
            CheckBox2.BackgroundImageLayout = ImageLayout.Stretch
        Else
            new_pass_txt.UseSystemPasswordChar = False
            CheckBox2.BackgroundImage = My.Resources.pngwing_com
            CheckBox2.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            comfirm_pass_txt.UseSystemPasswordChar = True
            CheckBox3.BackgroundImage = My.Resources.eye5
            CheckBox3.BackgroundImageLayout = ImageLayout.Stretch
        Else
            comfirm_pass_txt.UseSystemPasswordChar = False
            CheckBox3.BackgroundImage = My.Resources.pngwing_com
            CheckBox3.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub change_password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class