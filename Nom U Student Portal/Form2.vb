Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempGrades() As Double = Form1.strCurrentUser.GetGrades

        txtN.Text = Form1.strCurrentUser.getName
        txtE.Text = tempGrades(0)
        txtM.Text = tempGrades(1)
        txtS.Text = tempGrades(2)
        txtN.Visible = True
        txtE.Visible = True
        txtM.Visible = True
        txtS.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class