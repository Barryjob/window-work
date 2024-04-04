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
        Me.a_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.b_txt = New System.Windows.Forms.TextBox()
        Me.c_txt = New System.Windows.Forms.TextBox()
        Me.result_txt = New System.Windows.Forms.Label()
        Me.calculate_txt = New System.Windows.Forms.Button()
        Me.clear_txt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUADRATIC EQUATION CACULATOR"
        '
        'a_txt
        '
        Me.a_txt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.a_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.a_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_txt.Location = New System.Drawing.Point(91, 72)
        Me.a_txt.Multiline = True
        Me.a_txt.Name = "a_txt"
        Me.a_txt.Size = New System.Drawing.Size(129, 39)
        Me.a_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "INPUT VALUE OF A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "INPUT VALUE OF B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(409, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "INPUT VALUE OF C"
        '
        'b_txt
        '
        Me.b_txt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.b_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.b_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_txt.Location = New System.Drawing.Point(247, 72)
        Me.b_txt.Multiline = True
        Me.b_txt.Name = "b_txt"
        Me.b_txt.Size = New System.Drawing.Size(122, 39)
        Me.b_txt.TabIndex = 1
        '
        'c_txt
        '
        Me.c_txt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.c_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_txt.Location = New System.Drawing.Point(410, 72)
        Me.c_txt.Multiline = True
        Me.c_txt.Name = "c_txt"
        Me.c_txt.Size = New System.Drawing.Size(128, 39)
        Me.c_txt.TabIndex = 1
        '
        'result_txt
        '
        Me.result_txt.AutoSize = True
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(93, 139)
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(449, 18)
        Me.result_txt.TabIndex = 0
        Me.result_txt.Text = "THE ROOTS OF THE EQUATION ARE: ............................"
        '
        'calculate_txt
        '
        Me.calculate_txt.BackColor = System.Drawing.Color.Gray
        Me.calculate_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calculate_txt.FlatAppearance.BorderSize = 0
        Me.calculate_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_txt.ForeColor = System.Drawing.Color.White
        Me.calculate_txt.Location = New System.Drawing.Point(96, 183)
        Me.calculate_txt.Name = "calculate_txt"
        Me.calculate_txt.Size = New System.Drawing.Size(124, 41)
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
        Me.clear_txt.Location = New System.Drawing.Point(259, 183)
        Me.clear_txt.Name = "clear_txt"
        Me.clear_txt.Size = New System.Drawing.Size(116, 41)
        Me.clear_txt.TabIndex = 2
        Me.clear_txt.Text = "CLEAR"
        Me.clear_txt.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(619, 279)
        Me.Controls.Add(Me.clear_txt)
        Me.Controls.Add(Me.calculate_txt)
        Me.Controls.Add(Me.c_txt)
        Me.Controls.Add(Me.b_txt)
        Me.Controls.Add(Me.a_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "QADRATIC EQUATION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents a_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents b_txt As System.Windows.Forms.TextBox
    Friend WithEvents c_txt As System.Windows.Forms.TextBox
    Friend WithEvents result_txt As System.Windows.Forms.Label
    Friend WithEvents calculate_txt As System.Windows.Forms.Button
    Friend WithEvents clear_txt As System.Windows.Forms.Button

End Class
