<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.dashboard_pnl = New System.Windows.Forms.Panel()
        Me.timec_lbl = New System.Windows.Forms.Label()
        Me.attendance_btn = New System.Windows.Forms.Button()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClockInClockOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.log_out_btn = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Button()
        Me.Admin_btn = New System.Windows.Forms.Button()
        Me.verification_btn = New System.Windows.Forms.Button()
        Me.enrollment_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewsEditUsersRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEditStaffRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Circleavatar1 = New New_biometric.circleavatar()
        Me.dashboard_pnl.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.Circleavatar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashboard_pnl
        '
        Me.dashboard_pnl.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.dashboard_pnl.Controls.Add(Me.Circleavatar1)
        Me.dashboard_pnl.Controls.Add(Me.timec_lbl)
        Me.dashboard_pnl.Controls.Add(Me.attendance_btn)
        Me.dashboard_pnl.Controls.Add(Me.log_out_btn)
        Me.dashboard_pnl.Controls.Add(Me.settings)
        Me.dashboard_pnl.Controls.Add(Me.Admin_btn)
        Me.dashboard_pnl.Controls.Add(Me.verification_btn)
        Me.dashboard_pnl.Controls.Add(Me.enrollment_btn)
        Me.dashboard_pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboard_pnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboard_pnl.Name = "dashboard_pnl"
        Me.dashboard_pnl.Size = New System.Drawing.Size(958, 88)
        Me.dashboard_pnl.TabIndex = 0
        '
        'timec_lbl
        '
        Me.timec_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timec_lbl.AutoSize = True
        Me.timec_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timec_lbl.ForeColor = System.Drawing.Color.DarkRed
        Me.timec_lbl.Location = New System.Drawing.Point(650, 30)
        Me.timec_lbl.Name = "timec_lbl"
        Me.timec_lbl.Size = New System.Drawing.Size(226, 13)
        Me.timec_lbl.TabIndex = 1
        Me.timec_lbl.Text = "Time 00:00:00 PM Date 00 mmm, 0000"
        '
        'attendance_btn
        '
        Me.attendance_btn.BackColor = System.Drawing.Color.Transparent
        Me.attendance_btn.ContextMenuStrip = Me.ContextMenuStrip3
        Me.attendance_btn.FlatAppearance.BorderSize = 0
        Me.attendance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.attendance_btn.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendance_btn.Image = CType(resources.GetObject("attendance_btn.Image"), System.Drawing.Image)
        Me.attendance_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.attendance_btn.Location = New System.Drawing.Point(406, 4)
        Me.attendance_btn.Name = "attendance_btn"
        Me.attendance_btn.Size = New System.Drawing.Size(93, 63)
        Me.attendance_btn.TabIndex = 0
        Me.attendance_btn.Text = "Attendance"
        Me.attendance_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.attendance_btn.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClockInClockOutToolStripMenuItem, Me.AttendanceReportToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(182, 48)
        '
        'ClockInClockOutToolStripMenuItem
        '
        Me.ClockInClockOutToolStripMenuItem.Name = "ClockInClockOutToolStripMenuItem"
        Me.ClockInClockOutToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ClockInClockOutToolStripMenuItem.Text = "Clock In / Clock Out"
        '
        'AttendanceReportToolStripMenuItem
        '
        Me.AttendanceReportToolStripMenuItem.Name = "AttendanceReportToolStripMenuItem"
        Me.AttendanceReportToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AttendanceReportToolStripMenuItem.Text = "Attendance Report"
        '
        'log_out_btn
        '
        Me.log_out_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.log_out_btn.BackColor = System.Drawing.Color.Transparent
        Me.log_out_btn.FlatAppearance.BorderSize = 0
        Me.log_out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.log_out_btn.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_out_btn.Image = CType(resources.GetObject("log_out_btn.Image"), System.Drawing.Image)
        Me.log_out_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.log_out_btn.Location = New System.Drawing.Point(873, 4)
        Me.log_out_btn.Name = "log_out_btn"
        Me.log_out_btn.Size = New System.Drawing.Size(93, 63)
        Me.log_out_btn.TabIndex = 0
        Me.log_out_btn.Text = "Log-Out"
        Me.log_out_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.log_out_btn.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.settings.BackColor = System.Drawing.Color.Transparent
        Me.settings.FlatAppearance.BorderSize = 0
        Me.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings.Image = CType(resources.GetObject("settings.Image"), System.Drawing.Image)
        Me.settings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.settings.Location = New System.Drawing.Point(307, 4)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(93, 63)
        Me.settings.TabIndex = 0
        Me.settings.Text = "Settings"
        Me.settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.settings.UseVisualStyleBackColor = False
        '
        'Admin_btn
        '
        Me.Admin_btn.BackColor = System.Drawing.Color.Transparent
        Me.Admin_btn.FlatAppearance.BorderSize = 0
        Me.Admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Admin_btn.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_btn.Image = CType(resources.GetObject("Admin_btn.Image"), System.Drawing.Image)
        Me.Admin_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Admin_btn.Location = New System.Drawing.Point(213, 4)
        Me.Admin_btn.Name = "Admin_btn"
        Me.Admin_btn.Size = New System.Drawing.Size(93, 63)
        Me.Admin_btn.TabIndex = 0
        Me.Admin_btn.Text = "Admin"
        Me.Admin_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Admin_btn.UseVisualStyleBackColor = False
        '
        'verification_btn
        '
        Me.verification_btn.BackColor = System.Drawing.Color.Transparent
        Me.verification_btn.FlatAppearance.BorderSize = 0
        Me.verification_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.verification_btn.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verification_btn.Image = CType(resources.GetObject("verification_btn.Image"), System.Drawing.Image)
        Me.verification_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.verification_btn.Location = New System.Drawing.Point(114, 4)
        Me.verification_btn.Name = "verification_btn"
        Me.verification_btn.Size = New System.Drawing.Size(93, 63)
        Me.verification_btn.TabIndex = 0
        Me.verification_btn.Text = "Verification"
        Me.verification_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.verification_btn.UseVisualStyleBackColor = False
        '
        'enrollment_btn
        '
        Me.enrollment_btn.BackColor = System.Drawing.Color.Transparent
        Me.enrollment_btn.FlatAppearance.BorderSize = 0
        Me.enrollment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enrollment_btn.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollment_btn.Image = CType(resources.GetObject("enrollment_btn.Image"), System.Drawing.Image)
        Me.enrollment_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.enrollment_btn.Location = New System.Drawing.Point(15, 4)
        Me.enrollment_btn.Name = "enrollment_btn"
        Me.enrollment_btn.Size = New System.Drawing.Size(93, 63)
        Me.enrollment_btn.TabIndex = 0
        Me.enrollment_btn.Text = "Enrollment"
        Me.enrollment_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.enrollment_btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-1, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(964, 413)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 373)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 40)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(128, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(153, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logged In As :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(964, 413)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RToolStripMenuItem, Me.ViewsEditUsersRecordToolStripMenuItem, Me.ViewEditStaffRecordToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(207, 70)
        '
        'RToolStripMenuItem
        '
        Me.RToolStripMenuItem.Name = "RToolStripMenuItem"
        Me.RToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RToolStripMenuItem.Text = "Register New Staff"
        '
        'ViewsEditUsersRecordToolStripMenuItem
        '
        Me.ViewsEditUsersRecordToolStripMenuItem.Name = "ViewsEditUsersRecordToolStripMenuItem"
        Me.ViewsEditUsersRecordToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ViewsEditUsersRecordToolStripMenuItem.Text = "Views / Edit Users Record"
        '
        'ViewEditStaffRecordToolStripMenuItem
        '
        Me.ViewEditStaffRecordToolStripMenuItem.Name = "ViewEditStaffRecordToolStripMenuItem"
        Me.ViewEditStaffRecordToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ViewEditStaffRecordToolStripMenuItem.Text = "View / Edit Staff Record"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(196, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem1.Text = "Change New Password"
        '
        'Circleavatar1
        '
        Me.Circleavatar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Circleavatar1.Image = CType(resources.GetObject("Circleavatar1.Image"), System.Drawing.Image)
        Me.Circleavatar1.Location = New System.Drawing.Point(619, 27)
        Me.Circleavatar1.Name = "Circleavatar1"
        Me.Circleavatar1.Size = New System.Drawing.Size(25, 25)
        Me.Circleavatar1.TabIndex = 2
        Me.Circleavatar1.TabStop = False
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 484)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dashboard_pnl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dashboard"
        Me.Text = "Biometric Finger Enrollment and Verification System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.dashboard_pnl.ResumeLayout(False)
        Me.dashboard_pnl.PerformLayout()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.Circleavatar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dashboard_pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents enrollment_btn As System.Windows.Forms.Button
    Friend WithEvents verification_btn As System.Windows.Forms.Button
    Friend WithEvents log_out_btn As System.Windows.Forms.Button
    Friend WithEvents settings As System.Windows.Forms.Button
    Friend WithEvents Admin_btn As System.Windows.Forms.Button
    Friend WithEvents timec_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewsEditUsersRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEditStaffRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Circleavatar1 As New_biometric.circleavatar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClockInClockOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents attendance_btn As System.Windows.Forms.Button
End Class
