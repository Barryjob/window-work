<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGECALCULATOR
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.clear_txt = New System.Windows.Forms.Button()
        Me.calculate_txt = New System.Windows.Forms.Button()
        Me.birthyear_txt = New System.Windows.Forms.TextBox()
        Me.birthmonth_txt = New System.Windows.Forms.TextBox()
        Me.todaysdate_txt = New System.Windows.Forms.TextBox()
        Me.birthday_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.clear_txt)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.calculate_txt)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.birthyear_txt)
        Me.Panel1.Controls.Add(Me.birthmonth_txt)
        Me.Panel1.Controls.Add(Me.todaysdate_txt)
        Me.Panel1.Controls.Add(Me.birthday_txt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 354)
        Me.Panel1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(366, 232)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 40)
        Me.TextBox3.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(227, 232)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 40)
        Me.TextBox2.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(80, 232)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 40)
        Me.TextBox1.TabIndex = 22
        '
        'clear_txt
        '
        Me.clear_txt.BackColor = System.Drawing.Color.Red
        Me.clear_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_txt.FlatAppearance.BorderSize = 0
        Me.clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clear_txt.Location = New System.Drawing.Point(226, 297)
        Me.clear_txt.Name = "clear_txt"
        Me.clear_txt.Size = New System.Drawing.Size(149, 45)
        Me.clear_txt.TabIndex = 20
        Me.clear_txt.Text = "CLEAR"
        Me.clear_txt.UseVisualStyleBackColor = False
        '
        'calculate_txt
        '
        Me.calculate_txt.BackColor = System.Drawing.Color.MediumTurquoise
        Me.calculate_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculate_txt.FlatAppearance.BorderSize = 0
        Me.calculate_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_txt.ForeColor = System.Drawing.Color.White
        Me.calculate_txt.Location = New System.Drawing.Point(57, 297)
        Me.calculate_txt.Name = "calculate_txt"
        Me.calculate_txt.Size = New System.Drawing.Size(149, 45)
        Me.calculate_txt.TabIndex = 21
        Me.calculate_txt.Text = "CALCULATE"
        Me.calculate_txt.UseVisualStyleBackColor = False
        '
        'birthyear_txt
        '
        Me.birthyear_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.birthyear_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthyear_txt.Location = New System.Drawing.Point(438, 154)
        Me.birthyear_txt.Multiline = True
        Me.birthyear_txt.Name = "birthyear_txt"
        Me.birthyear_txt.Size = New System.Drawing.Size(124, 40)
        Me.birthyear_txt.TabIndex = 17
        '
        'birthmonth_txt
        '
        Me.birthmonth_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.birthmonth_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthmonth_txt.Location = New System.Drawing.Point(220, 154)
        Me.birthmonth_txt.Multiline = True
        Me.birthmonth_txt.Name = "birthmonth_txt"
        Me.birthmonth_txt.Size = New System.Drawing.Size(141, 40)
        Me.birthmonth_txt.TabIndex = 16
        '
        'todaysdate_txt
        '
        Me.todaysdate_txt.BackColor = System.Drawing.Color.DarkTurquoise
        Me.todaysdate_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.todaysdate_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.todaysdate_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.todaysdate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todaysdate_txt.ForeColor = System.Drawing.Color.Transparent
        Me.todaysdate_txt.Location = New System.Drawing.Point(416, 77)
        Me.todaysdate_txt.Multiline = True
        Me.todaysdate_txt.Name = "todaysdate_txt"
        Me.todaysdate_txt.Size = New System.Drawing.Size(146, 32)
        Me.todaysdate_txt.TabIndex = 19
        Me.todaysdate_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'birthday_txt
        '
        Me.birthday_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.birthday_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday_txt.Location = New System.Drawing.Point(57, 154)
        Me.birthday_txt.Multiline = True
        Me.birthday_txt.Name = "birthday_txt"
        Me.birthday_txt.Size = New System.Drawing.Size(88, 40)
        Me.birthday_txt.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(429, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "YEAR OF BIRTH"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "MONTH OF BIRTH"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 29)
        Me.Label5.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(215, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 24)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TODAY'S DATE IS :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "BIRTHDAY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "AGE CALCULATOR"
        '
        'AGECALCULATOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(731, 399)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AGECALCULATOR"
        Me.Text = "AGE CALCULATOR"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents clear_txt As System.Windows.Forms.Button
    Friend WithEvents calculate_txt As System.Windows.Forms.Button
    Friend WithEvents birthyear_txt As System.Windows.Forms.TextBox
    Friend WithEvents birthmonth_txt As System.Windows.Forms.TextBox
    Friend WithEvents todaysdate_txt As System.Windows.Forms.TextBox
    Friend WithEvents birthday_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
