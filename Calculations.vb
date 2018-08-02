Public Class Calculations

    Public Sub Calculations()
    End Sub

    Public Sub updateProgressBar(ByVal lvl As Single)


        If lvl = 0 Then
            Form1.progressBar.Minimum = 0
            Form1.progressBar.Maximum = 4
            Form1.imgUnr.Visible = True
        End If
        If lvl = 1 Then
            Form1.progressBar.Minimum = 4
            Form1.progressBar.Maximum = 16
        End If
        If lvl = 2 Then
            Form1.progressBar.Minimum = 16
            Form1.progressBar.Maximum = 36
            Form1.imgUnr.Visible = False
            Form1.imgBro.Visible = True
        End If
        If lvl = 3 Then
            Form1.progressBar.Minimum = 36
            Form1.progressBar.Maximum = 64
        End If
        If lvl = 4 Then
            Form1.progressBar.Minimum = 64
            Form1.progressBar.Maximum = 100
            Form1.imgBro.Visible = False
            Form1.imgSil.Visible = True
        End If
        If lvl = 5 Then
            Form1.progressBar.Minimum = 100
            Form1.progressBar.Maximum = 144
            Form1.imgSil.Visible = False
            Form1.imgGol.Visible = True
        End If
        If lvl = 6 Then
            Form1.progressBar.Minimum = 144
            Form1.progressBar.Maximum = 196
            Form1.imgGol.Visible = False
            Form1.imgPla.Visible = True
        End If
        If lvl > 6 Then
            Form1.progressBar.Minimum = 196
            Form1.progressBar.Maximum = 250
        End If
    End Sub
End Class
