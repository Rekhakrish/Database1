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
        Me.LblNum1 = New System.Windows.Forms.Label()
        Me.LblNum2 = New System.Windows.Forms.Label()
        Me.Txtnum1 = New System.Windows.Forms.TextBox()
        Me.Txtnum2 = New System.Windows.Forms.TextBox()
        Me.butRes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNum1
        '
        Me.LblNum1.AutoSize = True
        Me.LblNum1.Location = New System.Drawing.Point(213, 66)
        Me.LblNum1.Name = "LblNum1"
        Me.LblNum1.Size = New System.Drawing.Size(57, 15)
        Me.LblNum1.TabIndex = 0
        Me.LblNum1.Text = "Number1"
        '
        'LblNum2
        '
        Me.LblNum2.AutoSize = True
        Me.LblNum2.Location = New System.Drawing.Point(210, 123)
        Me.LblNum2.Name = "LblNum2"
        Me.LblNum2.Size = New System.Drawing.Size(60, 15)
        Me.LblNum2.TabIndex = 1
        Me.LblNum2.Text = "Number 2"
        '
        'Txtnum1
        '
        Me.Txtnum1.Location = New System.Drawing.Point(347, 66)
        Me.Txtnum1.Name = "Txtnum1"
        Me.Txtnum1.Size = New System.Drawing.Size(75, 23)
        Me.Txtnum1.TabIndex = 2
        '
        'Txtnum2
        '
        Me.Txtnum2.Location = New System.Drawing.Point(347, 115)
        Me.Txtnum2.Name = "Txtnum2"
        Me.Txtnum2.Size = New System.Drawing.Size(75, 23)
        Me.Txtnum2.TabIndex = 3
        '
        'butRes
        '
        Me.butRes.Location = New System.Drawing.Point(273, 172)
        Me.butRes.Name = "butRes"
        Me.butRes.Size = New System.Drawing.Size(75, 23)
        Me.butRes.TabIndex = 4
        Me.butRes.Text = "Result"
        Me.butRes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.butRes)
        Me.Controls.Add(Me.Txtnum2)
        Me.Controls.Add(Me.Txtnum1)
        Me.Controls.Add(Me.LblNum2)
        Me.Controls.Add(Me.LblNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNum1 As Label
    Friend WithEvents LblNum2 As Label
    Friend WithEvents Txtnum1 As TextBox
    Friend WithEvents Txtnum2 As TextBox
    Friend WithEvents butRes As Button
End Class
