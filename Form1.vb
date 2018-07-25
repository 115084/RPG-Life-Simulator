Public Class Form1
    Dim currentexp As Integer
    Dim exp As Integer
    Dim lvl As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentexp = 0
        exp = 0





    End Sub
    Private Sub btnHomework_Click(sender As Object, e As EventArgs) Handles btnHomework.Click
        currentexp = currentexp + 1
        TextBox1.Text = currentexp
        lvl = 10 * Math.Sqrt(currentexp)
        TextBox2.Text = lvl
    End Sub

    Private Sub btnStudy_Click(sender As Object, e As EventArgs) Handles btnStudy.Click
        currentexp = currentexp + 1
        TextBox1.Text = currentexp
        lvl = Math.Sqrt(currentexp)
        TextBox2.Text = lvl
    End Sub

    Private Sub btnExercise_Click(sender As Object, e As EventArgs) Handles btnExercise.Click
        currentexp = currentexp + 1
        TextBox1.Text = currentexp
        lvl = 10 * Math.Sqrt(currentexp)
        TextBox2.Text = lvl
    End Sub

End Class
