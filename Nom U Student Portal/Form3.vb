Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newStudent As New Form1.Student()

        newStudent.setUserCredentials(txtUN.Text, txtP.Text)
        newStudent.setGrades(Val(txtE.Text), Val(txtM.Text), Val(txtS.Text))
        Form1.listStudent.Add(newStudent)

        txtUN.Clear()
        txtP.Clear()
        txtE.Clear()
        txtM.Clear()
        txtS.Clear()

        Me.Close()
    End Sub

End Class