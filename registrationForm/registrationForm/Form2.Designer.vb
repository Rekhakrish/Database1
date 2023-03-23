<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblPro = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Btnregister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPro
        '
        Me.lblPro.AutoSize = True
        Me.lblPro.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPro.Location = New System.Drawing.Point(57, 53)
        Me.lblPro.Name = "lblPro"
        Me.lblPro.Size = New System.Drawing.Size(112, 20)
        Me.lblPro.TabIndex = 0
        Me.lblPro.Text = "Rekha Project"
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogin.Location = New System.Drawing.Point(443, 50)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 31)
        Me.BtnLogin.TabIndex = 1
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Btnregister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegister.Location = New System.Drawing.Point(593, 50)
        Me.BtnRegister.Name = "Btnregister"
        Me.BtnRegister.Size = New System.Drawing.Size(75, 36)
        Me.BtnRegister.TabIndex = 2
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.lblPro)
        Me.Name = "Form1"
        Me.Text = "Welcome to Rekha Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPro As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Btnregister As Button
End Class
