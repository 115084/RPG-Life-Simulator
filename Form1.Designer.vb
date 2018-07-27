<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCurrentExp = New System.Windows.Forms.TextBox()
        Me.btnHomework = New System.Windows.Forms.Button()
        Me.btnStudy = New System.Windows.Forms.Button()
        Me.btnExercise = New System.Windows.Forms.Button()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCurrentExp
        '
        Me.txtCurrentExp.Location = New System.Drawing.Point(54, 114)
        Me.txtCurrentExp.Name = "txtCurrentExp"
        Me.txtCurrentExp.ReadOnly = True
        Me.txtCurrentExp.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentExp.TabIndex = 0
        '
        'btnHomework
        '
        Me.btnHomework.Location = New System.Drawing.Point(280, 111)
        Me.btnHomework.Name = "btnHomework"
        Me.btnHomework.Size = New System.Drawing.Size(75, 23)
        Me.btnHomework.TabIndex = 1
        Me.btnHomework.Text = "Homework"
        Me.btnHomework.UseVisualStyleBackColor = True
        '
        'btnStudy
        '
        Me.btnStudy.Location = New System.Drawing.Point(280, 154)
        Me.btnStudy.Name = "btnStudy"
        Me.btnStudy.Size = New System.Drawing.Size(75, 23)
        Me.btnStudy.TabIndex = 2
        Me.btnStudy.Text = "Study"
        Me.btnStudy.UseVisualStyleBackColor = True
        '
        'btnExercise
        '
        Me.btnExercise.Location = New System.Drawing.Point(280, 200)
        Me.btnExercise.Name = "btnExercise"
        Me.btnExercise.Size = New System.Drawing.Size(75, 23)
        Me.btnExercise.TabIndex = 3
        Me.btnExercise.Text = "Exercise"
        Me.btnExercise.UseVisualStyleBackColor = True
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(54, 190)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.ReadOnly = True
        Me.txtLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtLevel.TabIndex = 4
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(54, 258)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(100, 23)
        Me.progressBar.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BnBProject2018.My.Resources.Resources.Unranked
        Me.PictureBox1.Location = New System.Drawing.Point(54, 287)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 406)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.btnExercise)
        Me.Controls.Add(Me.btnStudy)
        Me.Controls.Add(Me.btnHomework)
        Me.Controls.Add(Me.txtCurrentExp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCurrentExp As TextBox
    Friend WithEvents btnHomework As Button
    Friend WithEvents btnStudy As Button
    Friend WithEvents btnExercise As Button
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
End Class
