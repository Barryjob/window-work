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
        Me.stake_home_salary_txt = New System.Windows.Forms.Label()
        Me.amount_deducted_txt = New System.Windows.Forms.Label()
        Me.calculate_txt = New System.Windows.Forms.Button()
        Me.clear_txt = New System.Windows.Forms.Button()
        Me.staff_salary_txt = New System.Windows.Forms.TextBox()
        Me.tax_rate_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.stake_home_salary_txt)
        Me.Panel1.Controls.Add(Me.amount_deducted_txt)
        Me.Panel1.Controls.Add(Me.calculate_txt)
        Me.Panel1.Controls.Add(Me.clear_txt)
        Me.Panel1.Controls.Add(Me.staff_salary_txt)
        Me.Panel1.Controls.Add(Me.tax_rate_txt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(15, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 318)
        Me.Panel1.TabIndex = 0
        '
        'stake_home_salary_txt
        '
        Me.stake_home_salary_txt.AutoSize = True
        Me.stake_home_salary_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stake_home_salary_txt.Location = New System.Drawing.Point(43, 268)
        Me.stake_home_salary_txt.Name = "stake_home_salary_txt"
        Me.stake_home_salary_txt.Size = New System.Drawing.Size(208, 13)
        Me.stake_home_salary_txt.TabIndex = 3
        Me.stake_home_salary_txt.Text = "SALARY AFTER TAX DEDUCTION:"
        '
        'amount_deducted_txt
        '
        Me.amount_deducted_txt.AutoSize = True
        Me.amount_deducted_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount_deducted_txt.Location = New System.Drawing.Point(43, 241)
        Me.amount_deducted_txt.Name = "amount_deducted_txt"
        Me.amount_deducted_txt.Size = New System.Drawing.Size(184, 13)
        Me.amount_deducted_txt.TabIndex = 3
        Me.amount_deducted_txt.Text = "AMOUNT DEDUCTED AS TAX:"
        '
        'calculate_txt
        '
        Me.calculate_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calculate_txt.FlatAppearance.BorderSize = 0
        Me.calculate_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_txt.ForeColor = System.Drawing.Color.White
        Me.calculate_txt.Location = New System.Drawing.Point(46, 164)
        Me.calculate_txt.Name = "calculate_txt"
        Me.calculate_txt.Size = New System.Drawing.Size(125, 39)
        Me.calculate_txt.TabIndex = 2
        Me.calculate_txt.Text = "CALCULATE"
        Me.calculate_txt.UseVisualStyleBackColor = False
        '
        'clear_txt
        '
        Me.clear_txt.BackColor = System.Drawing.Color.Red
        Me.clear_txt.FlatAppearance.BorderSize = 0
        Me.clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_txt.ForeColor = System.Drawing.Color.White
        Me.clear_txt.Location = New System.Drawing.Point(222, 164)
        Me.clear_txt.Name = "clear_txt"
        Me.clear_txt.Size = New System.Drawing.Size(131, 39)
        Me.clear_txt.TabIndex = 2
        Me.clear_txt.Text = "CLEAR"
        Me.clear_txt.UseVisualStyleBackColor = False
        '
        'staff_salary_txt
        '
        Me.staff_salary_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.staff_salary_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staff_salary_txt.Location = New System.Drawing.Point(46, 110)
        Me.staff_salary_txt.Multiline = True
        Me.staff_salary_txt.Name = "staff_salary_txt"
        Me.staff_salary_txt.Size = New System.Drawing.Size(125, 34)
        Me.staff_salary_txt.TabIndex = 1
        '
        'tax_rate_txt
        '
        Me.tax_rate_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tax_rate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tax_rate_txt.Location = New System.Drawing.Point(222, 110)
        Me.tax_rate_txt.Multiline = True
        Me.tax_rate_txt.Name = "tax_rate_txt"
        Me.tax_rate_txt.Size = New System.Drawing.Size(131, 34)
        Me.tax_rate_txt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TAX RATE IN (%)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "STAFF SALARY (#)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF SALARY TAX DEDUCTION"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(442, 349)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "STAFF SALARY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents staff_salary_txt As System.Windows.Forms.TextBox
    Friend WithEvents tax_rate_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stake_home_salary_txt As System.Windows.Forms.Label
    Friend WithEvents amount_deducted_txt As System.Windows.Forms.Label
    Friend WithEvents calculate_txt As System.Windows.Forms.Button
    Friend WithEvents clear_txt As System.Windows.Forms.Button

End Class
