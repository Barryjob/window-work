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
        Me.velocity_txt = New System.Windows.Forms.TextBox()
        Me.time_txt = New System.Windows.Forms.TextBox()
        Me.displacement_txt = New System.Windows.Forms.TextBox()
        Me.clear_txt = New System.Windows.Forms.Button()
        Me.calculate_txt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.velocity_txt)
        Me.Panel1.Controls.Add(Me.time_txt)
        Me.Panel1.Controls.Add(Me.displacement_txt)
        Me.Panel1.Controls.Add(Me.clear_txt)
        Me.Panel1.Controls.Add(Me.calculate_txt)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(19, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 328)
        Me.Panel1.TabIndex = 0
        '
        'velocity_txt
        '
        Me.velocity_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.velocity_txt.Enabled = False
        Me.velocity_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velocity_txt.Location = New System.Drawing.Point(186, 186)
        Me.velocity_txt.Multiline = True
        Me.velocity_txt.Name = "velocity_txt"
        Me.velocity_txt.Size = New System.Drawing.Size(134, 37)
        Me.velocity_txt.TabIndex = 2
        Me.velocity_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'time_txt
        '
        Me.time_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.time_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_txt.Location = New System.Drawing.Point(186, 117)
        Me.time_txt.Multiline = True
        Me.time_txt.Name = "time_txt"
        Me.time_txt.Size = New System.Drawing.Size(134, 37)
        Me.time_txt.TabIndex = 2
        '
        'displacement_txt
        '
        Me.displacement_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.displacement_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displacement_txt.Location = New System.Drawing.Point(186, 56)
        Me.displacement_txt.Multiline = True
        Me.displacement_txt.Name = "displacement_txt"
        Me.displacement_txt.Size = New System.Drawing.Size(134, 37)
        Me.displacement_txt.TabIndex = 2
        '
        'clear_txt
        '
        Me.clear_txt.BackColor = System.Drawing.Color.Red
        Me.clear_txt.FlatAppearance.BorderSize = 0
        Me.clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_txt.ForeColor = System.Drawing.Color.White
        Me.clear_txt.Location = New System.Drawing.Point(186, 253)
        Me.clear_txt.Name = "clear_txt"
        Me.clear_txt.Size = New System.Drawing.Size(134, 36)
        Me.clear_txt.TabIndex = 1
        Me.clear_txt.Text = "CLEAR"
        Me.clear_txt.UseVisualStyleBackColor = False
        '
        'calculate_txt
        '
        Me.calculate_txt.BackColor = System.Drawing.Color.Gainsboro
        Me.calculate_txt.FlatAppearance.BorderSize = 0
        Me.calculate_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_txt.ForeColor = System.Drawing.Color.White
        Me.calculate_txt.Location = New System.Drawing.Point(31, 253)
        Me.calculate_txt.Name = "calculate_txt"
        Me.calculate_txt.Size = New System.Drawing.Size(112, 36)
        Me.calculate_txt.TabIndex = 1
        Me.calculate_txt.Text = "CALCULATE"
        Me.calculate_txt.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "VELOCITY(m/s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TIME(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DISPLACEMENT(m):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VELOCITY CALCULATOR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(400, 354)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "VELOCIT CALCULATOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents calculate_txt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents time_txt As System.Windows.Forms.TextBox
    Friend WithEvents displacement_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_txt As System.Windows.Forms.Button
    Friend WithEvents velocity_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
