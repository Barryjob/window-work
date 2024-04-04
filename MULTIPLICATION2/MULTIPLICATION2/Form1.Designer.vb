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
        Me.calculatem_txt = New System.Windows.Forms.Button()
        Me.resultm_txt = New System.Windows.Forms.TextBox()
        Me.second_nom_txt = New System.Windows.Forms.TextBox()
        Me.first_nom_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FIRST = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.calculatem_txt)
        Me.Panel1.Controls.Add(Me.resultm_txt)
        Me.Panel1.Controls.Add(Me.second_nom_txt)
        Me.Panel1.Controls.Add(Me.first_nom_txt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.FIRST)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 331)
        Me.Panel1.TabIndex = 0
        '
        'calculatem_txt
        '
        Me.calculatem_txt.Location = New System.Drawing.Point(85, 211)
        Me.calculatem_txt.Name = "calculatem_txt"
        Me.calculatem_txt.Size = New System.Drawing.Size(150, 25)
        Me.calculatem_txt.TabIndex = 18
        Me.calculatem_txt.Text = "CALCULATE"
        Me.calculatem_txt.UseVisualStyleBackColor = True
        '
        'resultm_txt
        '
        Me.resultm_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultm_txt.Location = New System.Drawing.Point(85, 269)
        Me.resultm_txt.Multiline = True
        Me.resultm_txt.Name = "resultm_txt"
        Me.resultm_txt.Size = New System.Drawing.Size(150, 39)
        Me.resultm_txt.TabIndex = 15
        '
        'second_nom_txt
        '
        Me.second_nom_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_nom_txt.Location = New System.Drawing.Point(85, 151)
        Me.second_nom_txt.Multiline = True
        Me.second_nom_txt.Name = "second_nom_txt"
        Me.second_nom_txt.Size = New System.Drawing.Size(150, 39)
        Me.second_nom_txt.TabIndex = 16
        '
        'first_nom_txt
        '
        Me.first_nom_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_nom_txt.Location = New System.Drawing.Point(85, 71)
        Me.first_nom_txt.Multiline = True
        Me.first_nom_txt.Name = "first_nom_txt"
        Me.first_nom_txt.Size = New System.Drawing.Size(150, 39)
        Me.first_nom_txt.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "RESULT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ENTER THE SECOND NUMBER"
        '
        'FIRST
        '
        Me.FIRST.AutoSize = True
        Me.FIRST.Location = New System.Drawing.Point(82, 55)
        Me.FIRST.Name = "FIRST"
        Me.FIRST.Size = New System.Drawing.Size(153, 13)
        Me.FIRST.TabIndex = 14
        Me.FIRST.Text = "ENTER THE FIRST NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MULTIPLICATION OF TWO NUMBERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 330)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents calculatem_txt As System.Windows.Forms.Button
    Friend WithEvents resultm_txt As System.Windows.Forms.TextBox
    Friend WithEvents second_nom_txt As System.Windows.Forms.TextBox
    Friend WithEvents first_nom_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FIRST As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
