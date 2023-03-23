<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcountry = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Lblscore = New System.Windows.Forms.Label()
        Me.Txtscore = New System.Windows.Forms.TextBox()
        Me.BtnGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which country you are from?"
        '
        'txtcountry
        '
        Me.txtcountry.Location = New System.Drawing.Point(266, 37)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(100, 23)
        Me.txtcountry.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(158, 119)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Lblscore
        '
        Me.Lblscore.AutoSize = True
        Me.Lblscore.Location = New System.Drawing.Point(43, 224)
        Me.Lblscore.Name = "Lblscore"
        Me.Lblscore.Size = New System.Drawing.Size(93, 15)
        Me.Lblscore.TabIndex = 3
        Me.Lblscore.Text = "Enter Your Score"
        '
        'Txtscore
        '
        Me.Txtscore.Location = New System.Drawing.Point(266, 216)
        Me.Txtscore.Name = "Txtscore"
        Me.Txtscore.Size = New System.Drawing.Size(100, 23)
        Me.Txtscore.TabIndex = 4
        '
        'BtnGrade
        '
        Me.BtnGrade.Location = New System.Drawing.Point(158, 281)
        Me.BtnGrade.Name = "BtnGrade"
        Me.BtnGrade.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrade.TabIndex = 5
        Me.BtnGrade.Text = "Grade"
        Me.BtnGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnGrade)
        Me.Controls.Add(Me.Txtscore)
        Me.Controls.Add(Me.Lblscore)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtcountry)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcountry As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Lblscore As Label
    Friend WithEvents Txtscore As TextBox
    Friend WithEvents BtnGrade As Button
End Class
