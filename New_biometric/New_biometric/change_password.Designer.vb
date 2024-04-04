<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.change_password_exit_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.change_password_submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.change_password_close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.current_pass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.new_pass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.comfirm_pass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.change_password_exit_btn)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 44)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Password"
        '
        'change_password_exit_btn
        '
        Me.change_password_exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.change_password_exit_btn.FlatAppearance.BorderSize = 0
        Me.change_password_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.change_password_exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_password_exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.change_password_exit_btn.Location = New System.Drawing.Point(489, 5)
        Me.change_password_exit_btn.Name = "change_password_exit_btn"
        Me.change_password_exit_btn.Size = New System.Drawing.Size(35, 35)
        Me.change_password_exit_btn.TabIndex = 0
        Me.change_password_exit_btn.Text = "X"
        Me.change_password_exit_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Current Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Confirm Password"
        '
        'change_password_submit_btn
        '
        Me.change_password_submit_btn.BorderRadius = 4
        Me.change_password_submit_btn.CheckedState.Parent = Me.change_password_submit_btn
        Me.change_password_submit_btn.CustomImages.Parent = Me.change_password_submit_btn
        Me.change_password_submit_btn.FillColor = System.Drawing.Color.DarkCyan
        Me.change_password_submit_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.change_password_submit_btn.ForeColor = System.Drawing.Color.White
        Me.change_password_submit_btn.HoverState.Parent = Me.change_password_submit_btn
        Me.change_password_submit_btn.Location = New System.Drawing.Point(19, 328)
        Me.change_password_submit_btn.Name = "change_password_submit_btn"
        Me.change_password_submit_btn.ShadowDecoration.Parent = Me.change_password_submit_btn
        Me.change_password_submit_btn.Size = New System.Drawing.Size(190, 43)
        Me.change_password_submit_btn.TabIndex = 18
        Me.change_password_submit_btn.Text = "Submit"
        '
        'change_password_close_btn
        '
        Me.change_password_close_btn.BorderRadius = 4
        Me.change_password_close_btn.CheckedState.Parent = Me.change_password_close_btn
        Me.change_password_close_btn.CustomImages.Parent = Me.change_password_close_btn
        Me.change_password_close_btn.FillColor = System.Drawing.Color.Maroon
        Me.change_password_close_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.change_password_close_btn.ForeColor = System.Drawing.Color.White
        Me.change_password_close_btn.HoverState.Parent = Me.change_password_close_btn
        Me.change_password_close_btn.Location = New System.Drawing.Point(335, 328)
        Me.change_password_close_btn.Name = "change_password_close_btn"
        Me.change_password_close_btn.ShadowDecoration.Parent = Me.change_password_close_btn
        Me.change_password_close_btn.Size = New System.Drawing.Size(190, 43)
        Me.change_password_close_btn.TabIndex = 18
        Me.change_password_close_btn.Text = "Close"
        '
        'current_pass_txt
        '
        Me.current_pass_txt.BorderRadius = 5
        Me.current_pass_txt.BorderThickness = 0
        Me.current_pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.current_pass_txt.DefaultText = ""
        Me.current_pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.current_pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.current_pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.current_pass_txt.DisabledState.Parent = Me.current_pass_txt
        Me.current_pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.current_pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.current_pass_txt.FocusedState.Parent = Me.current_pass_txt
        Me.current_pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.current_pass_txt.HoverState.Parent = Me.current_pass_txt
        Me.current_pass_txt.Location = New System.Drawing.Point(21, 89)
        Me.current_pass_txt.Name = "current_pass_txt"
        Me.current_pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.current_pass_txt.PlaceholderText = ""
        Me.current_pass_txt.SelectedText = ""
        Me.current_pass_txt.ShadowDecoration.Parent = Me.current_pass_txt
        Me.current_pass_txt.Size = New System.Drawing.Size(504, 46)
        Me.current_pass_txt.TabIndex = 19
        '
        'new_pass_txt
        '
        Me.new_pass_txt.BorderRadius = 5
        Me.new_pass_txt.BorderThickness = 0
        Me.new_pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.new_pass_txt.DefaultText = ""
        Me.new_pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.new_pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.new_pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_pass_txt.DisabledState.Parent = Me.new_pass_txt
        Me.new_pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_pass_txt.FocusedState.Parent = Me.new_pass_txt
        Me.new_pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_pass_txt.HoverState.Parent = Me.new_pass_txt
        Me.new_pass_txt.Location = New System.Drawing.Point(21, 171)
        Me.new_pass_txt.Name = "new_pass_txt"
        Me.new_pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.new_pass_txt.PlaceholderText = ""
        Me.new_pass_txt.SelectedText = ""
        Me.new_pass_txt.ShadowDecoration.Parent = Me.new_pass_txt
        Me.new_pass_txt.Size = New System.Drawing.Size(504, 46)
        Me.new_pass_txt.TabIndex = 19
        '
        'comfirm_pass_txt
        '
        Me.comfirm_pass_txt.BorderRadius = 5
        Me.comfirm_pass_txt.BorderThickness = 0
        Me.comfirm_pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.comfirm_pass_txt.DefaultText = ""
        Me.comfirm_pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.comfirm_pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.comfirm_pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.comfirm_pass_txt.DisabledState.Parent = Me.comfirm_pass_txt
        Me.comfirm_pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.comfirm_pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comfirm_pass_txt.FocusedState.Parent = Me.comfirm_pass_txt
        Me.comfirm_pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comfirm_pass_txt.HoverState.Parent = Me.comfirm_pass_txt
        Me.comfirm_pass_txt.Location = New System.Drawing.Point(21, 266)
        Me.comfirm_pass_txt.Name = "comfirm_pass_txt"
        Me.comfirm_pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.comfirm_pass_txt.PlaceholderText = ""
        Me.comfirm_pass_txt.SelectedText = ""
        Me.comfirm_pass_txt.ShadowDecoration.Parent = Me.comfirm_pass_txt
        Me.comfirm_pass_txt.Size = New System.Drawing.Size(504, 46)
        Me.comfirm_pass_txt.TabIndex = 19
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.BackgroundImage = Global.New_biometric.My.Resources.Resources.pngwing_com
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(476, 100)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(34, 26)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = " "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.BackColor = System.Drawing.Color.White
        Me.CheckBox2.BackgroundImage = Global.New_biometric.My.Resources.Resources.pngwing_com
        Me.CheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.BorderSize = 0
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(476, 181)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(34, 26)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = " "
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.BackColor = System.Drawing.Color.White
        Me.CheckBox3.BackgroundImage = Global.New_biometric.My.Resources.Resources.pngwing_com
        Me.CheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.BorderSize = 0
        Me.CheckBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(476, 276)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(34, 26)
        Me.CheckBox3.TabIndex = 20
        Me.CheckBox3.Text = " "
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 383)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.comfirm_pass_txt)
        Me.Controls.Add(Me.new_pass_txt)
        Me.Controls.Add(Me.current_pass_txt)
        Me.Controls.Add(Me.change_password_close_btn)
        Me.Controls.Add(Me.change_password_submit_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "change_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "change_password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents change_password_exit_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents change_password_submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents change_password_close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents current_pass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents new_pass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents comfirm_pass_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
End Class
