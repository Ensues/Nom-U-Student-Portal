<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.txtS = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 45)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "English Grade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Math Grade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 45)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Science Grade:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!)
        Me.Button1.Location = New System.Drawing.Point(133, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 103)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Show Grades"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!)
        Me.Button2.Location = New System.Drawing.Point(321, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 103)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Log Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtM
        '
        Me.txtM.Enabled = False
        Me.txtM.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM.Location = New System.Drawing.Point(321, 261)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(253, 50)
        Me.txtM.TabIndex = 10
        Me.txtM.Visible = False
        '
        'txtE
        '
        Me.txtE.Enabled = False
        Me.txtE.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE.Location = New System.Drawing.Point(321, 180)
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(253, 50)
        Me.txtE.TabIndex = 9
        Me.txtE.Visible = False
        '
        'txtN
        '
        Me.txtN.Enabled = False
        Me.txtN.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtN.Location = New System.Drawing.Point(321, 99)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(253, 50)
        Me.txtN.TabIndex = 11
        Me.txtN.Visible = False
        '
        'txtS
        '
        Me.txtS.Enabled = False
        Me.txtS.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtS.Location = New System.Drawing.Point(321, 351)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(253, 50)
        Me.txtS.TabIndex = 12
        Me.txtS.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 644)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.txtM)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtM As TextBox
    Friend WithEvents txtE As TextBox
    Friend WithEvents txtN As TextBox
    Friend WithEvents txtS As TextBox
End Class
