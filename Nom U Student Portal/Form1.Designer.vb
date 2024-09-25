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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOM U Student Portal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 45)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'txtUN
        '
        Me.txtUN.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!)
        Me.txtUN.Location = New System.Drawing.Point(294, 242)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(342, 50)
        Me.txtUN.TabIndex = 3
        '
        'txtP
        '
        Me.txtP.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!)
        Me.txtP.Location = New System.Drawing.Point(294, 308)
        Me.txtP.Name = "txtP"
        Me.txtP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtP.Size = New System.Drawing.Size(342, 50)
        Me.txtP.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!)
        Me.Button1.Location = New System.Drawing.Point(122, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 113)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!)
        Me.Button2.Location = New System.Drawing.Point(335, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 113)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Add Student"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 605)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUN As TextBox
    Friend WithEvents txtP As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
