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

        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        progressBar.Value = currentexp
        calculator.updateProgressBar(lvl)
        txtLevel.Text = lvl

        imgTro.Visible = True
        imgExc.Visible = False
        imgEye.Visible = False


        For Each item In clistTime.CheckedItems
            sb = (item.Substring(0, 2))
            Convert.ToInt32(sb)
        Next
        MessageBox.Show(sb.ToString())

        If sb = 15 Then
            currentexp = currentexp + 1
        End If
        If sb = 30 Then
            For exp As Integer = 1 To 2
                currentexp = currentexp + Math.Floor((exp / 2))
            Next
        End If
        If sb = 60 Then
            For exp As Integer = 1 To 3
                currentexp = currentexp + Math.Floor((exp / 2))
            Next
        End If
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

        For Each item In clistTime.CheckedItems
            sb = (item.Substring(0, 2))
        Next
        MessageBox.Show(sb.ToString())
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

        For Each item In clistTime.CheckedItems
            sb = (item.Substring(0, 2))
        Next
        MessageBox.Show(sb.ToString())
    End Sub

    Private Sub clistTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clistTime.SelectedIndexChanged
        
    End Sub
End Class
