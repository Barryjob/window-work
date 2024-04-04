<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_registeration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff_registeration))
        Me.sta_reg_close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.select_passport_staff_reg_btn = New System.Windows.Forms.Button()
        Me.passport = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.status_txt = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.staff_role_txt = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.address_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.phone_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fullname_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sta_reg_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.veri_exit_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.submit_staff_reg_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sta_reg_close_btn
        '
        Me.sta_reg_close_btn.BorderRadius = 4
        Me.sta_reg_close_btn.CheckedState.Parent = Me.sta_reg_close_btn
        Me.sta_reg_close_btn.CustomImages.Parent = Me.sta_reg_close_btn
        Me.sta_reg_close_btn.FillColor = System.Drawing.Color.Maroon
        Me.sta_reg_close_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sta_reg_close_btn.ForeColor = System.Drawing.Color.White
        Me.sta_reg_close_btn.HoverState.Parent = Me.sta_reg_close_btn
        Me.sta_reg_close_btn.Location = New System.Drawing.Point(20, 115)
        Me.sta_reg_close_btn.Name = "sta_reg_close_btn"
        Me.sta_reg_close_btn.ShadowDecoration.Parent = Me.sta_reg_close_btn
        Me.sta_reg_close_btn.Size = New System.Drawing.Size(164, 43)
        Me.sta_reg_close_btn.TabIndex = 16
        Me.sta_reg_close_btn.Text = "Close"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.select_passport_staff_reg_btn)
        Me.GroupBox3.Controls.Add(Me.passport)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(525, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 242)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Passport"
        '
        'select_passport_staff_reg_btn
        '
        Me.select_passport_staff_reg_btn.BackColor = System.Drawing.Color.MediumTurquoise
        Me.select_passport_staff_reg_btn.FlatAppearance.BorderSize = 0
        Me.select_passport_staff_reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.select_passport_staff_reg_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_passport_staff_reg_btn.Location = New System.Drawing.Point(20, 190)
        Me.select_passport_staff_reg_btn.Name = "select_passport_staff_reg_btn"
        Me.select_passport_staff_reg_btn.Size = New System.Drawing.Size(164, 37)
        Me.select_passport_staff_reg_btn.TabIndex = 2
        Me.select_passport_staff_reg_btn.Text = "SELECT PASSPORT"
        Me.select_passport_staff_reg_btn.UseVisualStyleBackColor = False
        '
        'passport
        '
        Me.passport.Image = CType(resources.GetObject("passport.Image"), System.Drawing.Image)
        Me.passport.Location = New System.Drawing.Point(20, 20)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(164, 164)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 1
        Me.passport.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.status_txt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.staff_role_txt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.address_txt)
        Me.GroupBox2.Controls.Add(Me.phone_txt)
        Me.GroupBox2.Controls.Add(Me.email_txt)
        Me.GroupBox2.Controls.Add(Me.fullname_txt)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(485, 472)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff Information"
        '
        'status_txt
        '
        Me.status_txt.BackColor = System.Drawing.Color.Transparent
        Me.status_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.status_txt.BorderRadius = 4
        Me.status_txt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.status_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_txt.FocusedColor = System.Drawing.Color.Empty
        Me.status_txt.FocusedState.Parent = Me.status_txt
        Me.status_txt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.status_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.status_txt.FormattingEnabled = True
        Me.status_txt.HoverState.Parent = Me.status_txt
        Me.status_txt.ItemHeight = 30
        Me.status_txt.Items.AddRange(New Object() {"ACTIVE", "SUSPEND"})
        Me.status_txt.ItemsAppearance.Parent = Me.status_txt
        Me.status_txt.Location = New System.Drawing.Point(20, 419)
        Me.status_txt.Name = "status_txt"
        Me.status_txt.ShadowDecoration.Parent = Me.status_txt
        Me.status_txt.Size = New System.Drawing.Size(442, 36)
        Me.status_txt.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Status"
        '
        'staff_role_txt
        '
        Me.staff_role_txt.BackColor = System.Drawing.Color.Transparent
        Me.staff_role_txt.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.staff_role_txt.BorderRadius = 4
        Me.staff_role_txt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.staff_role_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.staff_role_txt.FocusedColor = System.Drawing.Color.Empty
        Me.staff_role_txt.FocusedState.Parent = Me.staff_role_txt
        Me.staff_role_txt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.staff_role_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.staff_role_txt.FormattingEnabled = True
        Me.staff_role_txt.HoverState.Parent = Me.staff_role_txt
        Me.staff_role_txt.ItemHeight = 30
        Me.staff_role_txt.Items.AddRange(New Object() {"STAFF", "ADMIN", "SUPER ADMIN"})
        Me.staff_role_txt.ItemsAppearance.Parent = Me.staff_role_txt
        Me.staff_role_txt.Location = New System.Drawing.Point(20, 350)
        Me.staff_role_txt.Name = "staff_role_txt"
        Me.staff_role_txt.ShadowDecoration.Parent = Me.staff_role_txt
        Me.staff_role_txt.Size = New System.Drawing.Size(442, 36)
        Me.staff_role_txt.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Staff Role"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mobile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FullName"
        '
        'address_txt
        '
        Me.address_txt.BorderRadius = 4
        Me.address_txt.BorderThickness = 0
        Me.address_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address_txt.DefaultText = ""
        Me.address_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.address_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.address_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address_txt.DisabledState.Parent = Me.address_txt
        Me.address_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address_txt.FocusedState.Parent = Me.address_txt
        Me.address_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address_txt.HoverState.Parent = Me.address_txt
        Me.address_txt.Location = New System.Drawing.Point(20, 277)
        Me.address_txt.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.address_txt.PlaceholderText = ""
        Me.address_txt.SelectedText = ""
        Me.address_txt.ShadowDecoration.Parent = Me.address_txt
        Me.address_txt.Size = New System.Drawing.Size(442, 42)
        Me.address_txt.TabIndex = 0
        '
        'phone_txt
        '
        Me.phone_txt.BorderRadius = 4
        Me.phone_txt.BorderThickness = 0
        Me.phone_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phone_txt.DefaultText = ""
        Me.phone_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phone_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phone_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_txt.DisabledState.Parent = Me.phone_txt
        Me.phone_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phone_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_txt.FocusedState.Parent = Me.phone_txt
        Me.phone_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phone_txt.HoverState.Parent = Me.phone_txt
        Me.phone_txt.Location = New System.Drawing.Point(20, 200)
        Me.phone_txt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.phone_txt.Name = "phone_txt"
        Me.phone_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phone_txt.PlaceholderText = ""
        Me.phone_txt.SelectedText = ""
        Me.phone_txt.ShadowDecoration.Parent = Me.phone_txt
        Me.phone_txt.Size = New System.Drawing.Size(442, 42)
        Me.phone_txt.TabIndex = 0
        '
        'email_txt
        '
        Me.email_txt.BorderRadius = 4
        Me.email_txt.BorderThickness = 0
        Me.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_txt.DefaultText = ""
        Me.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.DisabledState.Parent = Me.email_txt
        Me.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.FocusedState.Parent = Me.email_txt
        Me.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_txt.HoverState.Parent = Me.email_txt
        Me.email_txt.Location = New System.Drawing.Point(20, 122)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_txt.PlaceholderText = ""
        Me.email_txt.SelectedText = ""
        Me.email_txt.ShadowDecoration.Parent = Me.email_txt
        Me.email_txt.Size = New System.Drawing.Size(442, 42)
        Me.email_txt.TabIndex = 0
        '
        'fullname_txt
        '
        Me.fullname_txt.BorderRadius = 4
        Me.fullname_txt.BorderThickness = 0
        Me.fullname_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname_txt.DefaultText = ""
        Me.fullname_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullname_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullname_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.DisabledState.Parent = Me.fullname_txt
        Me.fullname_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.FocusedState.Parent = Me.fullname_txt
        Me.fullname_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname_txt.HoverState.Parent = Me.fullname_txt
        Me.fullname_txt.Location = New System.Drawing.Point(20, 50)
        Me.fullname_txt.Name = "fullname_txt"
        Me.fullname_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname_txt.PlaceholderText = ""
        Me.fullname_txt.SelectedText = ""
        Me.fullname_txt.ShadowDecoration.Parent = Me.fullname_txt
        Me.fullname_txt.Size = New System.Drawing.Size(442, 42)
        Me.fullname_txt.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Controls.Add(Me.sta_reg_exit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.veri_exit_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 51)
        Me.Panel1.TabIndex = 13
        '
        'sta_reg_exit
        '
        Me.sta_reg_exit.BackColor = System.Drawing.Color.Transparent
        Me.sta_reg_exit.FlatAppearance.BorderSize = 0
        Me.sta_reg_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sta_reg_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sta_reg_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sta_reg_exit.Location = New System.Drawing.Point(693, 8)
        Me.sta_reg_exit.Name = "sta_reg_exit"
        Me.sta_reg_exit.Size = New System.Drawing.Size(35, 35)
        Me.sta_reg_exit.TabIndex = 2
        Me.sta_reg_exit.Text = "X"
        Me.sta_reg_exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Staff Registeration"
        '
        'veri_exit_btn
        '
        Me.veri_exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.veri_exit_btn.FlatAppearance.BorderSize = 0
        Me.veri_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.veri_exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.veri_exit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.veri_exit_btn.Location = New System.Drawing.Point(927, 9)
        Me.veri_exit_btn.Name = "veri_exit_btn"
        Me.veri_exit_btn.Size = New System.Drawing.Size(35, 35)
        Me.veri_exit_btn.TabIndex = 0
        Me.veri_exit_btn.Text = "X"
        Me.veri_exit_btn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.submit_staff_reg_btn)
        Me.GroupBox1.Controls.Add(Me.sta_reg_close_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(525, 370)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 175)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'submit_staff_reg_btn
        '
        Me.submit_staff_reg_btn.BorderRadius = 4
        Me.submit_staff_reg_btn.CheckedState.Parent = Me.submit_staff_reg_btn
        Me.submit_staff_reg_btn.CustomImages.Parent = Me.submit_staff_reg_btn
        Me.submit_staff_reg_btn.FillColor = System.Drawing.Color.DarkCyan
        Me.submit_staff_reg_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.submit_staff_reg_btn.ForeColor = System.Drawing.Color.White
        Me.submit_staff_reg_btn.HoverState.Parent = Me.submit_staff_reg_btn
        Me.submit_staff_reg_btn.Location = New System.Drawing.Point(20, 27)
        Me.submit_staff_reg_btn.Name = "submit_staff_reg_btn"
        Me.submit_staff_reg_btn.ShadowDecoration.Parent = Me.submit_staff_reg_btn
        Me.submit_staff_reg_btn.Size = New System.Drawing.Size(164, 43)
        Me.submit_staff_reg_btn.TabIndex = 16
        Me.submit_staff_reg_btn.Text = "Submit"
        '
        'staff_registeration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 570)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staff_registeration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staff_registeration"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sta_reg_close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents select_passport_staff_reg_btn As System.Windows.Forms.Button
    Friend WithEvents passport As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents staff_role_txt As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents address_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents phone_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fullname_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents veri_exit_btn As System.Windows.Forms.Button
    Friend WithEvents status_txt As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents submit_staff_reg_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents sta_reg_exit As System.Windows.Forms.Button
End Class
