Public Class Form1
    Dim currentexp As Integer
    Dim exp As Integer
    Dim lvl As Single
    Dim displayLvl As Integer
    Dim levelingSystem As String
    Dim calculator As Calculations = New Calculations()
    Dim sb As String



    Private Sub Form1_Load(sender As Object, e As EventArgs)
        currentexp = 0
        exp = 0

    End Sub
    Private Sub btnHomework_Click_1(sender As Object, e As EventArgs) Handles btnHomework.Click
        currentexp = currentexp + 1
        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        progressBar.Value = currentexp
        calculator.updateProgressBar(lvl)
        txtLevel.Text = lvl

        imgTro.Visible = True
        imgExc.Visible = False
        imgEye.Visible = False


    End Sub

    Private Sub btnStudy_Click_1(sender As Object, e As EventArgs) Handles btnStudy.Click
        currentexp = currentexp + 1
        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        progressBar.Value = currentexp
        calculator.updateProgressBar(lvl)
        txtLevel.Text = lvl

        imgTro.Visible = False
        imgExc.Visible = True
        imgEye.Visible = False

    End Sub

    Private Sub btnExercise_Click_1(sender As Object, e As EventArgs) Handles btnExercise.Click
        currentexp = currentexp + 1
        txtCurrentExp.Text = currentexp
        progressBar.Value = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        txtLevel.Text = lvl

        imgTro.Visible = False
        imgExc.Visible = False
        imgEye.Visible = True

    End Sub

    Private Sub clistTime_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
