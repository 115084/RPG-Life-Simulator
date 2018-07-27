Public Class Form1
    Dim currentexp As Integer
    Dim exp As Integer
    Dim lvl As Single
    Dim displayLvl As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentexp = 0
        exp = 0
    End Sub
    Private Sub btnHomework_Click(sender As Object, e As EventArgs) Handles btnHomework.Click, progressBar.Click
        currentexp = currentexp + 1
        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        txtLevel.Text = lvl
        progressBar.Value = currentexp


    End Sub

    Private Sub btnStudy_Click(sender As Object, e As EventArgs) Handles btnStudy.Click
        currentexp = currentexp + 1
        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        txtLevel.Text = lvl
        progressBar.Value = currentexp


    End Sub

    Private Sub btnExercise_Click(sender As Object, e As EventArgs) Handles btnExercise.Click


        currentexp = currentexp + 1
        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        txtLevel.Text = lvl
        progressBar.Value = currentexp

    End Sub

    Private Sub progressBar_MouseClick(sender As Object, e As EventArgs) Handles progressBar.MouseClick
        If lvl = 0 Then
            progressBar.Minimum = 0
            progressBar.Maximum = 4
        End If
        If lvl = 1 Then
            progressBar.Minimum = 4
            progressBar.Maximum = 16
        End If
        If lvl = 2 Then
            progressBar.Minimum = 16
            progressBar.Maximum = 36
        End If
        If lvl = 3 Then
            progressBar.Minimum = 36
            progressBar.Maximum = 64
            progressBar.Value = currentexp
        End If
        If lvl = 4 Then
            progressBar.Minimum = 64
            progressBar.Maximum = 100
            progressBar.Value = currentexp
        End If
        If lvl = 5 Then
            progressBar.Minimum = 100
            progressBar.Maximum = 144
            progressBar.Value = currentexp
        End If
        If lvl = 6 Then
            progressBar.Minimum = 144
            progressBar.Maximum = 196
            progressBar.Value = currentexp
        End If
        If lvl > 6 Then
            progressBar.Minimum = 196
            progressBar.Maximum = 250
            progressBar.Value = currentexp
        End If
    End Sub

    Private Sub btnLevelUp_Click(sender As Object, e As EventArgs) Handles btnLevelUp.Click


    End Sub
End Class
