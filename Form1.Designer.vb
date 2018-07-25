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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnHomework = New System.Windows.Forms.Button()
        Me.btnStudy = New System.Windows.Forms.Button()
        Me.btnExercise = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(54, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnHomework
        '
        Me.btnHomework.Location = New System.Drawing.Point(319, 112)
        Me.btnHomework.Name = "btnHomework"
        Me.btnHomework.Size = New System.Drawing.Size(75, 23)
        Me.btnHomework.TabIndex = 1
        Me.btnHomework.Text = "Homework"
        Me.btnHomework.UseVisualStyleBackColor = True
        '
        'btnStudy
        '
        Me.btnStudy.Location = New System.Drawing.Point(319, 156)
        Me.btnStudy.Name = "btnStudy"
        Me.btnStudy.Size = New System.Drawing.Size(75, 23)
        Me.btnStudy.TabIndex = 2
        Me.btnStudy.Text = "Study"
        Me.btnStudy.UseVisualStyleBackColor = True
        '
        'btnExercise
        '
        Me.btnExercise.Location = New System.Drawing.Point(319, 200)
        Me.btnExercise.Name = "btnExercise"
        Me.btnExercise.Size = New System.Drawing.Size(75, 23)
        Me.btnExercise.TabIndex = 3
        Me.btnExercise.Text = "Exercise"
        Me.btnExercise.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(54, 200)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 406)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnExercise)
        Me.Controls.Add(Me.btnStudy)
        Me.Controls.Add(Me.btnHomework)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnHomework As Button
    Friend WithEvents btnStudy As Button
    Friend WithEvents btnExercise As Button
    Friend WithEvents TextBox2 As TextBox
End Class
