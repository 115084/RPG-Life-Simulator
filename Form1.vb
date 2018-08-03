Public Class Form1
    Dim currentexp As Integer = 0
    Dim lvl As Single
    Dim displayLvl As Integer
    Dim levelingSystem As String
    Dim calculator As Calculations = New Calculations()
    Dim sb As String
    Dim FILE_NAME As String = My.Application.Info.DirectoryPath + "\db.txt"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(FILE_NAME) = True Then
            'this code will 
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(FILE_NAME)
            Dim stringReader As String
            stringReader = fileReader.ReadLine(1)
            currentexp = stringReader
            fileReader.Close()
        Else
            'incase the user does not have the file, this will force them to create the file
            MessageBox.Show("Exp file does not exist, please create db.txt in bin")

        End If
        If System.IO.File.Exists(FILE_NAME) = True Then
            'this code will 
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(FILE_NAME)
            Dim lvlReader As String
            lvlReader = fileReader.ReadLine(2)
            lvl = lvlReader
            fileReader.Close()
        Else
            'incase the user does not have the file, this will force them to create the file
            MessageBox.Show("Exp file does not exist, please create db.txt in bin")

        End If
    End Sub

    Private Sub btnHomework_Click_1(sender As Object, e As EventArgs) Handles btnHomework.Click
        currentexp = currentexp + 1 'each time this button is pressed add 1exp
        txtCurrentExp.Text = currentexp 'displaying the exp on the form
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2)) 'the level will equal 0.75 and will round up due to using integer, so i used some round down code
        progressBar.Value = currentexp 'setting the progress bar to the current value of exp
        calculator.updateProgressBar(lvl) 'sends the lvl to the calculations class, then it will work out how much is need
        txtLevel.Text = lvl 'display lvl on form

        ImgTro.Visible = True 'this is showing the img for when you press this button
        imgExc.Visible = False
        imgEye.Visible = False

        If System.IO.File.Exists(FILE_NAME) = True Then
            'this code will write to the db.txt file
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write(currentexp)
            objWriter.Write(lvl)
            objWriter.Close()

        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub


    Private Sub btnStudy_Click_1(sender As Object, e As EventArgs) Handles btnStudy.Click
        currentexp = currentexp + 1 'the code is the same here as is for btnHomework_Click_1
        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        progressBar.Value = currentexp
        calculator.updateProgressBar(lvl)
        txtLevel.Text = lvl

        ImgTro.Visible = False
        imgExc.Visible = True 'this is showing the img for when you press this button
        imgEye.Visible = False

        If System.IO.File.Exists(FILE_NAME) = True Then
            'this code will write to the db.txt file
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write(txtCurrentExp.Text)
            objWriter.Close()

        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub


    Private Sub btnExercise_Click_1(sender As Object, e As EventArgs) Handles btnExercise.Click
        currentexp = currentexp + 1 'the code is the same here as is for btnHomework_Click_1
        txtCurrentExp.Text = currentexp
        lvl = Math.Floor((Math.Sqrt(currentexp) / 2))
        progressBar.Value = currentexp
        calculator.updateProgressBar(lvl)
        txtLevel.Text = lvl

        ImgTro.Visible = False
        imgExc.Visible = False
        imgEye.Visible = True 'this is showing the img for when you press this button

        If System.IO.File.Exists(FILE_NAME) = True Then
            'this code will write to the db.txt file
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write(txtCurrentExp.Text)
            objWriter.Close()

        Else
            'in case the user does not have db.txt, this is a second counter measure, making the program very hard to use without it
            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write("0")
            objWriter.Close()
            Me.Close()
        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

End Class
