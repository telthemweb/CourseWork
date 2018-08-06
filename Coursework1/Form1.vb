Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtAssignment2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'a1 + a2 + t1+ t2 constitute 30% of the final exam
        'exam take 70% 
        Dim Assignment1 As Integer = txtAssignment1.Text
        Dim Assignment2 As Integer = txtAssignment2.Text
        Dim T1 As Integer = txtTest1.Text
        Dim T2 As Integer = txtTest2.Text
        Dim exam As Double = txtExam.Text
        Dim examf As Double = (exam / 100) * 70
        Dim TotalAT As Double
        Dim overalMark As Double

        'calculating total
        TotalAT = (Assignment1 + Assignment2) + (T1 + T2)

        Dim totalCoursework As Double
        totalCoursework = (TotalAT / 400) * 30

        'MsgBox(totalCoursework)

        'Final mark after adding coursework and final exam 30% + 70% = 100%
        overalMark = totalCoursework + examf
        txtOveral.Text = overalMark



        If overalMark >= 75 And overalMark <= 100 Then
            txtGrade.Text = "Distinction"

        ElseIf overalMark >= 70 And overalMark <= 74 Then
            txtGrade.Text = "Merit"
        ElseIf overalMark >= 60 And overalMark <= 69 Then
            txtGrade.Text = "Credit"

        ElseIf overalMark >= 50 And overalMark <= 59 Then
            txtGrade.Text = "Pass"
        Else

            txtGrade.Text = "F"
        End If







    End Sub
End Class
