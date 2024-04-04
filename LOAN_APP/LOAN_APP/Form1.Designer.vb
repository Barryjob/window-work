<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.list_view_txt = New System.Windows.Forms.ListBox()
        Me.clear_txt = New System.Windows.Forms.Button()
        Me.calculate_txt = New System.Windows.Forms.Button()
        Me.interest_txt = New System.Windows.Forms.TextBox()
        Me.duration_txt = New System.Windows.Forms.TextBox()
        Me.loan_amount_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total_repayment_txt = New System.Windows.Forms.Label()
        Me.total_interest_txt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.list_view_txt)
        Me.Panel1.Controls.Add(Me.clear_txt)
        Me.Panel1.Controls.Add(Me.calculate_txt)
        Me.Panel1.Controls.Add(Me.interest_txt)
        Me.Panel1.Controls.Add(Me.duration_txt)
        Me.Panel1.Controls.Add(Me.loan_amount_txt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.total_repayment_txt)
        Me.Panel1.Controls.Add(Me.total_interest_txt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 499)
        Me.Panel1.TabIndex = 0
        '
        'list_view_txt
        '
        Me.list_view_txt.BackColor = System.Drawing.SystemColors.Window
        Me.list_view_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_view_txt.Enabled = False
        Me.list_view_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_view_txt.FormattingEnabled = True
        Me.list_view_txt.ItemHeight = 16
        Me.list_view_txt.Items.AddRange(New Object() {"DURATION                          AMOUNT                             INTEREST    " & _
                        "                       REPAYMENT"})
        Me.list_view_txt.Location = New System.Drawing.Point(64, 205)
        Me.list_view_txt.Name = "list_view_txt"
        Me.list_view_txt.Size = New System.Drawing.Size(593, 208)
        Me.list_view_txt.TabIndex = 3
        '
        'clear_txt
        '
        Me.clear_txt.BackColor = System.Drawing.Color.Red
        Me.clear_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_txt.FlatAppearance.BorderSize = 0
        Me.clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_txt.ForeColor = System.Drawing.Color.White
        Me.clear_txt.Location = New System.Drawing.Point(522, 114)
        Me.clear_txt.Name = "clear_txt"
        Me.clear_txt.Size = New System.Drawing.Size(135, 49)
        Me.clear_txt.TabIndex = 2
        Me.clear_txt.Text = "CLEAR"
        Me.clear_txt.UseVisualStyleBackColor = False
        '
        'calculate_txt
        '
        Me.calculate_txt.BackColor = System.Drawing.Color.DarkGray
        Me.calculate_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculate_txt.FlatAppearance.BorderSize = 0
        Me.calculate_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_txt.ForeColor = System.Drawing.Color.White
        Me.calculate_txt.Location = New System.Drawing.Point(522, 56)
        Me.calculate_txt.Name = "calculate_txt"
        Me.calculate_txt.Size = New System.Drawing.Size(135, 49)
        Me.calculate_txt.TabIndex = 2
        Me.calculate_txt.Text = "CALCULATE"
        Me.calculate_txt.UseVisualStyleBackColor = False
        '
        'interest_txt
        '
        Me.interest_txt.BackColor = System.Drawing.Color.White
        Me.interest_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.interest_txt.Enabled = False
        Me.interest_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.interest_txt.Location = New System.Drawing.Point(280, 134)
        Me.interest_txt.Multiline = True
        Me.interest_txt.Name = "interest_txt"
        Me.interest_txt.Size = New System.Drawing.Size(145, 29)
        Me.interest_txt.TabIndex = 1
        '
        'duration_txt
        '
        Me.duration_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.duration_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duration_txt.Location = New System.Drawing.Point(280, 96)
        Me.duration_txt.Multiline = True
        Me.duration_txt.Name = "duration_txt"
        Me.duration_txt.Size = New System.Drawing.Size(145, 29)
        Me.duration_txt.TabIndex = 1
        '
        'loan_amount_txt
        '
        Me.loan_amount_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.loan_amount_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loan_amount_txt.Location = New System.Drawing.Point(280, 56)
        Me.loan_amount_txt.Multiline = True
        Me.loan_amount_txt.Name = "loan_amount_txt"
        Me.loan_amount_txt.Size = New System.Drawing.Size(145, 29)
        Me.loan_amount_txt.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "INTEREST RATE (%): "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ENTER DURATION (M):"
        '
        'total_repayment_txt
        '
        Me.total_repayment_txt.AutoSize = True
        Me.total_repayment_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_repayment_txt.Location = New System.Drawing.Point(61, 461)
        Me.total_repayment_txt.Name = "total_repayment_txt"
        Me.total_repayment_txt.Size = New System.Drawing.Size(131, 13)
        Me.total_repayment_txt.TabIndex = 0
        Me.total_repayment_txt.Text = "TOTAL REPAYMENT:"
        '
        'total_interest_txt
        '
        Me.total_interest_txt.AutoSize = True
        Me.total_interest_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_interest_txt.Location = New System.Drawing.Point(61, 441)
        Me.total_interest_txt.Name = "total_interest_txt"
        Me.total_interest_txt.Size = New System.Drawing.Size(117, 13)
        Me.total_interest_txt.TabIndex = 0
        Me.total_interest_txt.Text = "TOTAL INTEREST:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ENTER LOAN AMOUNT(#):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOAN CALCULATOR"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(522, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(522, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 49)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(268, 56)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 29)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(268, 96)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(108, 29)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(268, 134)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(66, 29)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(65, 181)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(513, 257)
        Me.TextBox4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TOTAL INTEREST:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "TOTAL REPAYMENT:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(761, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents interest_txt As System.Windows.Forms.TextBox
    Friend WithEvents duration_txt As System.Windows.Forms.TextBox
    Friend WithEvents loan_amount_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_txt As System.Windows.Forms.Button
    Friend WithEvents calculate_txt As System.Windows.Forms.Button
    Friend WithEvents total_repayment_txt As System.Windows.Forms.Label
    Friend WithEvents total_interest_txt As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents list_view_txt As System.Windows.Forms.ListBox

End Class
