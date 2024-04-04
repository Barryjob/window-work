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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clear_btn1 = New System.Windows.Forms.Button()
        Me.calculate__txt = New System.Windows.Forms.Button()
        Me.resulth_txt = New System.Windows.Forms.TextBox()
        Me.second_noh_txt = New System.Windows.Forms.TextBox()
        Me.first_noh_txt = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.third_noh_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "RESULT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ENTER THE SECOND NUMBER"
        '
        'exit_btn
        '
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(290, 325)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(126, 52)
        Me.exit_btn.TabIndex = 9
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ENTER THE FIRST NUMBER"
        '
        'clear_btn1
        '
        Me.clear_btn1.BackColor = System.Drawing.Color.Gainsboro
        Me.clear_btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn1.Location = New System.Drawing.Point(62, 325)
        Me.clear_btn1.Name = "clear_btn1"
        Me.clear_btn1.Size = New System.Drawing.Size(123, 52)
        Me.clear_btn1.TabIndex = 10
        Me.clear_btn1.Text = "CLEAR"
        Me.clear_btn1.UseVisualStyleBackColor = False
        '
        'calculate__txt
        '
        Me.calculate__txt.Location = New System.Drawing.Point(62, 211)
        Me.calculate__txt.Name = "calculate__txt"
        Me.calculate__txt.Size = New System.Drawing.Size(150, 39)
        Me.calculate__txt.TabIndex = 8
        Me.calculate__txt.Text = "CALCULATE"
        Me.calculate__txt.UseVisualStyleBackColor = True
        '
        'resulth_txt
        '
        Me.resulth_txt.Location = New System.Drawing.Point(290, 212)
        Me.resulth_txt.Multiline = True
        Me.resulth_txt.Name = "resulth_txt"
        Me.resulth_txt.Size = New System.Drawing.Size(236, 38)
        Me.resulth_txt.TabIndex = 5
        '
        'second_noh_txt
        '
        Me.second_noh_txt.Location = New System.Drawing.Point(262, 113)
        Me.second_noh_txt.Multiline = True
        Me.second_noh_txt.Name = "second_noh_txt"
        Me.second_noh_txt.Size = New System.Drawing.Size(150, 39)
        Me.second_noh_txt.TabIndex = 6
        '
        'first_noh_txt
        '
        Me.first_noh_txt.Location = New System.Drawing.Point(62, 113)
        Me.first_noh_txt.Multiline = True
        Me.first_noh_txt.Name = "first_noh_txt"
        Me.first_noh_txt.Size = New System.Drawing.Size(150, 39)
        Me.first_noh_txt.TabIndex = 7
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(171, 36)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(255, 20)
        Me.label1.TabIndex = 4
        Me.label1.Text = "HIGHEST OF TWO NUMBERS"
        '
        'third_noh_txt
        '
        Me.third_noh_txt.Location = New System.Drawing.Point(466, 113)
        Me.third_noh_txt.Multiline = True
        Me.third_noh_txt.Name = "third_noh_txt"
        Me.third_noh_txt.Size = New System.Drawing.Size(150, 39)
        Me.third_noh_txt.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(463, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ENTER THE THIRD NUMBER"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 440)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clear_btn1)
        Me.Controls.Add(Me.calculate__txt)
        Me.Controls.Add(Me.resulth_txt)
        Me.Controls.Add(Me.third_noh_txt)
        Me.Controls.Add(Me.second_noh_txt)
        Me.Controls.Add(Me.first_noh_txt)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clear_btn1 As System.Windows.Forms.Button
    Friend WithEvents calculate__txt As System.Windows.Forms.Button
    Friend WithEvents resulth_txt As System.Windows.Forms.TextBox
    Friend WithEvents second_noh_txt As System.Windows.Forms.TextBox
    Friend WithEvents first_noh_txt As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents third_noh_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
