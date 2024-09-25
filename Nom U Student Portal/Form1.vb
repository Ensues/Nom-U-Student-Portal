Imports Nom_U_Student_Portal.Form1

Public Class Form1
    Public listStudent As New List(Of Student)
    Public strCurrentUser As Student
    Public Sub New()
        InitializeComponent()

        Dim stud1 As New Student("Jose", "1234", 74, 75, 80)
        Dim stud2 As New Student("Juana", "abcd", 90, 95, 90)
        Dim stud3 As New Student("Cardo", "juana", 70, 70, 70)

        listStudent.Add(stud1)
        listStudent.Add(stud2)
        listStudent.Add(stud3)
    End Sub

    Class Student
        Private strName As String
        Private strPass As String
        Private dblEGrade As Double
        Private dblMGrade As Double
        Private dblSGrade As Double

        Public Sub New(ByVal strTempName As String, ByVal strTempPass As String, ByVal dblEnglish As Double, ByVal dblMath As Double, ByVal dblScience As Double)
            strName = strTempName
            strPass = strTempPass
            dblEGrade = dblEnglish
            dblMGrade = dblMath
            dblSGrade = dblScience
        End Sub
        Public Sub New()

        End Sub

        Public Sub setUserCredentials(ByVal strTempName As String, ByVal strTempPass As String)
            strName = strTempName
            strPass = strTempPass
        End Sub

        Public Sub setGrades(ByVal dblEnglish As Double, ByVal dblMath As Double, ByVal dblScience As Double)
            dblEGrade = dblEnglish
            dblMGrade = dblMath
            dblSGrade = dblScience
        End Sub

        Public Function getName() As String
            Return strName
        End Function

        Public Function getPass() As String
            Return strPass
        End Function

        Public Function GetGrades() As Array
            Dim arrayGrades(3) As Double

            arrayGrades(0) = dblEGrade
            arrayGrades(1) = dblMGrade
            arrayGrades(2) = dblSGrade

            Return arrayGrades
        End Function
    End Class


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCounter = 0
        Do While intCounter < listStudent.Count
            If txtUN.Text = listStudent(intCounter).getName() And txtP.Text = listStudent(intCounter).getPass Then
                MsgBox("Logged In Successfully!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Womp Womp")

                Form2.Show()
                Me.Hide()

                strCurrentUser = listStudent(intCounter)
            End If
            intCounter += 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

End Class
