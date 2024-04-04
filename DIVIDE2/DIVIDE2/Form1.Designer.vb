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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.first_noa_txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FIRST = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.second_noa_txt = New System.Windows.Forms.TextBox()
        Me.resulta_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FRACTION OF TWO NUMBERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'first_noa_txt
        '
        Me.first_noa_txt.Location = New System.Drawing.Point(81, 75)
        Me.first_noa_txt.Multiline = True
        Me.first_noa_txt.Name = "first_noa_txt"
        Me.first_noa_txt.Size = New System.Drawing.Size(150, 39)
        Me.first_noa_txt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FIRST
        '
        Me.FIRST.AutoSize = True
        Me.FIRST.Location = New System.Drawing.Point(78, 59)
        Me.FIRST.Name = "FIRST"
        Me.FIRST.Size = New System.Drawing.Size(153, 13)
        Me.FIRST.TabIndex = 0
        Me.FIRST.Text = "ENTER THE FIRST NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ENTER THE SECOND NUMBER"
        '
        'second_noa_txt
        '
        Me.second_noa_txt.Location = New System.Drawing.Point(81, 155)
        Me.second_noa_txt.Multiline = True
        Me.second_noa_txt.Name = "second_noa_txt"
        Me.second_noa_txt.Size = New System.Drawing.Size(150, 39)
        Me.second_noa_txt.TabIndex = 1
        '
        'resulta_txt
        '
        Me.resulta_txt.BackColor = System.Drawing.Color.White
        Me.resulta_txt.Enabled = False
        Me.resulta_txt.Location = New System.Drawing.Point(81, 273)
        Me.resulta_txt.Multiline = True
        Me.resulta_txt.Name = "resulta_txt"
        Me.resulta_txt.Size = New System.Drawing.Size(150, 39)
        Me.resulta_txt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RESULT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 324)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.resulta_txt)
        Me.Controls.Add(Me.second_noa_txt)
        Me.Controls.Add(Me.first_noa_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FIRST)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "FRACTION OF TWO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents first_noa_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FIRST As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents second_noa_txt As System.Windows.Forms.TextBox
    Friend WithEvents resulta_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
