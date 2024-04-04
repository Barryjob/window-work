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
        Me.op_lbn = New System.Windows.Forms.Label()
        Me.multiply_btn = New System.Windows.Forms.Button()
        Me.divide_btn = New System.Windows.Forms.Button()
        Me.minus_btn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.calculate_txt = New System.Windows.Forms.Button()
        Me.plus_btn = New System.Windows.Forms.Button()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.second_no_txt = New System.Windows.Forms.TextBox()
        Me.first_no_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.op_lbn)
        Me.Panel1.Controls.Add(Me.multiply_btn)
        Me.Panel1.Controls.Add(Me.divide_btn)
        Me.Panel1.Controls.Add(Me.minus_btn)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.calculate_txt)
        Me.Panel1.Controls.Add(Me.plus_btn)
        Me.Panel1.Controls.Add(Me.result_txt)
        Me.Panel1.Controls.Add(Me.second_no_txt)
        Me.Panel1.Controls.Add(Me.first_no_txt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(124, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 445)
        Me.Panel1.TabIndex = 0
        '
        'op_lbn
        '
        Me.op_lbn.AllowDrop = True
        Me.op_lbn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.op_lbn.AutoSize = True
        Me.op_lbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.op_lbn.Location = New System.Drawing.Point(295, 172)
        Me.op_lbn.Name = "op_lbn"
        Me.op_lbn.Size = New System.Drawing.Size(0, 24)
        Me.op_lbn.TabIndex = 31
        '
        'multiply_btn
        '
        Me.multiply_btn.BackColor = System.Drawing.Color.SlateGray
        Me.multiply_btn.ForeColor = System.Drawing.Color.White
        Me.multiply_btn.Location = New System.Drawing.Point(347, 233)
        Me.multiply_btn.Name = "multiply_btn"
        Me.multiply_btn.Size = New System.Drawing.Size(38, 31)
        Me.multiply_btn.TabIndex = 27
        Me.multiply_btn.Text = "*"
        Me.multiply_btn.UseVisualStyleBackColor = False
        '
        'divide_btn
        '
        Me.divide_btn.BackColor = System.Drawing.Color.SlateGray
        Me.divide_btn.ForeColor = System.Drawing.Color.White
        Me.divide_btn.Location = New System.Drawing.Point(347, 186)
        Me.divide_btn.Name = "divide_btn"
        Me.divide_btn.Size = New System.Drawing.Size(38, 32)
        Me.divide_btn.TabIndex = 26
        Me.divide_btn.Text = "/"
        Me.divide_btn.UseVisualStyleBackColor = False
        '
        'minus_btn
        '
        Me.minus_btn.BackColor = System.Drawing.Color.SlateGray
        Me.minus_btn.ForeColor = System.Drawing.Color.White
        Me.minus_btn.Location = New System.Drawing.Point(347, 144)
        Me.minus_btn.Name = "minus_btn"
        Me.minus_btn.Size = New System.Drawing.Size(38, 30)
        Me.minus_btn.TabIndex = 25
        Me.minus_btn.Text = "-"
        Me.minus_btn.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(265, 377)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 40)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "CLEAR"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'calculate_txt
        '
        Me.calculate_txt.BackColor = System.Drawing.Color.SlateGray
        Me.calculate_txt.FlatAppearance.BorderSize = 0
        Me.calculate_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_txt.ForeColor = System.Drawing.Color.White
        Me.calculate_txt.Location = New System.Drawing.Point(50, 377)
        Me.calculate_txt.Name = "calculate_txt"
        Me.calculate_txt.Size = New System.Drawing.Size(172, 40)
        Me.calculate_txt.TabIndex = 29
        Me.calculate_txt.Text = "CALCULATE"
        Me.calculate_txt.UseVisualStyleBackColor = False
        '
        'plus_btn
        '
        Me.plus_btn.BackColor = System.Drawing.Color.SlateGray
        Me.plus_btn.ForeColor = System.Drawing.Color.White
        Me.plus_btn.Location = New System.Drawing.Point(347, 106)
        Me.plus_btn.Name = "plus_btn"
        Me.plus_btn.Size = New System.Drawing.Size(36, 30)
        Me.plus_btn.TabIndex = 28
        Me.plus_btn.Text = "+"
        Me.plus_btn.UseVisualStyleBackColor = False
        '
        'result_txt
        '
        Me.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(55, 308)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(330, 41)
        Me.result_txt.TabIndex = 24
        '
        'second_no_txt
        '
        Me.second_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.second_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_no_txt.Location = New System.Drawing.Point(50, 223)
        Me.second_no_txt.Multiline = True
        Me.second_no_txt.Name = "second_no_txt"
        Me.second_no_txt.Size = New System.Drawing.Size(200, 41)
        Me.second_no_txt.TabIndex = 22
        '
        'first_no_txt
        '
        Me.first_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.first_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_no_txt.Location = New System.Drawing.Point(50, 122)
        Me.first_no_txt.Multiline = True
        Me.first_no_txt.Name = "first_no_txt"
        Me.first_no_txt.Size = New System.Drawing.Size(200, 41)
        Me.first_no_txt.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "RESULT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ENTER SECOND NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ENTER FIRST NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "SIMPLE-CALCULATOR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents op_lbn As System.Windows.Forms.Label
    Friend WithEvents multiply_btn As System.Windows.Forms.Button
    Friend WithEvents divide_btn As System.Windows.Forms.Button
    Friend WithEvents minus_btn As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents calculate_txt As System.Windows.Forms.Button
    Friend WithEvents plus_btn As System.Windows.Forms.Button
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents second_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents first_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
