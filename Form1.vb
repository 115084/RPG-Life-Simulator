Public Class Form1
    Dim currentexp As Integer
    Dim exp As Integer
    Dim lvl As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Str()
    End Sub

    Private Sub btnHomework_Click(sender As Object, e As EventArgs) Handles btnHomework.Click
        currentExp = currentexp + 1
    End Sub

    Private Sub btnStudy_Click(sender As Object, e As EventArgs) Handles btnStudy.Click
        currentExp = currentexp + 1
    End Sub

    Private Sub btnExercise_Click(sender As Object, e As EventArgs) Handles btnExercise.Click
        currentexp = currentexp + 1
    End Sub
End Class
