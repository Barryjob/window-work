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
        Me.label1 = New System.Windows.Forms.Label()
        Me.first_noh_txt = New System.Windows.Forms.TextBox()
        Me.calculate__txt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.second_noh_txt = New System.Windows.Forms.TextBox()
        Me.resulth_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(51, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(255, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "HIGHEST OF TWO NUMBERS"
        '
        'first_noh_txt
        '
        Me.first_noh_txt.Location = New System.Drawing.Point(28, 86)
        Me.first_noh_txt.Multiline = True
        Me.first_noh_txt.Name = "first_noh_txt"
        Me.first_noh_txt.Size = New System.Drawing.Size(150, 39)
        Me.first_noh_txt.TabIndex = 1
        '
        'calculate__txt
        '
        Me.calculate__txt.Location = New System.Drawing.Point(113, 164)
        Me.calculate__txt.Name = "calculate__txt"
        Me.calculate__txt.Size = New System.Drawing.Size(150, 39)
        Me.calculate__txt.TabIndex = 2
        Me.calculate__txt.Text = "CALCULATE"
        Me.calculate__txt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ENTER THE FIRST NUMBER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ENTER THE SECOND NUMBER"
        '
        'second_noh_txt
        '
        Me.second_noh_txt.Location = New System.Drawing.Point(211, 86)
        Me.second_noh_txt.Multiline = True
        Me.second_noh_txt.Name = "second_noh_txt"
        Me.second_noh_txt.Size = New System.Drawing.Size(150, 39)
        Me.second_noh_txt.TabIndex = 1
        '
        'resulth_txt
        '
        Me.resulth_txt.Location = New System.Drawing.Point(70, 249)
        Me.resulth_txt.Multiline = True
        Me.resulth_txt.Name = "resulth_txt"
        Me.resulth_txt.Size = New System.Drawing.Size(236, 38)
        Me.resulth_txt.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RESULT"
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(27, 326)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(123, 52)
        Me.clear_btn.TabIndex = 2
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(211, 325)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(126, 52)
        Me.exit_btn.TabIndex = 2
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.calculate__txt)
        Me.Controls.Add(Me.resulth_txt)
        Me.Controls.Add(Me.second_noh_txt)
        Me.Controls.Add(Me.first_noh_txt)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "HIGHEST TWO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents first_noh_txt As System.Windows.Forms.TextBox
    Friend WithEvents calculate__txt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents second_noh_txt As System.Windows.Forms.TextBox
    Friend WithEvents resulth_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button

End Class
