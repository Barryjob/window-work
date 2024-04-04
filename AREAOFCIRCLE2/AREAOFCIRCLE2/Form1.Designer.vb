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
        Me.radius_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.calculate_txt = New System.Windows.Forms.Button()
        Me.clear_txt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AREA OF CIRCLE"
        '
        'radius_txt
        '
        Me.radius_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.radius_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radius_txt.Location = New System.Drawing.Point(42, 153)
        Me.radius_txt.Multiline = True
        Me.radius_txt.Name = "radius_txt"
        Me.radius_txt.Size = New System.Drawing.Size(142, 40)
        Me.radius_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ENTER RADIUS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " OF CIRCLE (m)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TAKING PIE:  3.142"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 36)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "AREA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OF CIRCLE: (m^2)"
        '
        'result_txt
        '
        Me.result_txt.BackColor = System.Drawing.Color.White
        Me.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(241, 153)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(142, 40)
        Me.result_txt.TabIndex = 1
        '
        'calculate_txt
        '
        Me.calculate_txt.BackColor = System.Drawing.Color.DarkGray
        Me.calculate_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculate_txt.FlatAppearance.BorderSize = 0
        Me.calculate_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_txt.ForeColor = System.Drawing.Color.White
        Me.calculate_txt.Location = New System.Drawing.Point(42, 240)
        Me.calculate_txt.Name = "calculate_txt"
        Me.calculate_txt.Size = New System.Drawing.Size(141, 39)
        Me.calculate_txt.TabIndex = 2
        Me.calculate_txt.Text = "CALCULATE"
        Me.calculate_txt.UseVisualStyleBackColor = False
        '
        'clear_txt
        '
        Me.clear_txt.BackColor = System.Drawing.Color.Red
        Me.clear_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_txt.FlatAppearance.BorderSize = 0
        Me.clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_txt.ForeColor = System.Drawing.Color.White
        Me.clear_txt.Location = New System.Drawing.Point(242, 240)
        Me.clear_txt.Name = "clear_txt"
        Me.clear_txt.Size = New System.Drawing.Size(141, 39)
        Me.clear_txt.TabIndex = 2
        Me.clear_txt.Text = "CLEAR"
        Me.clear_txt.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(443, 337)
        Me.Controls.Add(Me.clear_txt)
        Me.Controls.Add(Me.calculate_txt)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.radius_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AREA OF CIRCLE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radius_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents calculate_txt As System.Windows.Forms.Button
    Friend WithEvents clear_txt As System.Windows.Forms.Button

End Class
