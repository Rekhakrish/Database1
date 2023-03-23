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
        Label1 = New Label()
        TextBoxstudentname = New TextBox()
        Buttonsummit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(99, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 0
        Label1.Text = "Student Name"' 
        ' TextBoxstudentname
        ' 
        TextBoxstudentname.Location = New Point(264, 79)
        TextBoxstudentname.Name = "TextBoxstudentname"
        TextBoxstudentname.Size = New Size(100, 23)
        TextBoxstudentname.TabIndex = 1
        ' 
        ' Buttonsummit
        ' 
        Buttonsummit.Location = New Point(176, 172)
        Buttonsummit.Name = "Buttonsummit"
        Buttonsummit.Size = New Size(75, 23)
        Buttonsummit.TabIndex = 2
        Buttonsummit.Text = "Summit"
        Buttonsummit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Buttonsummit)
        Controls.Add(TextBoxstudentname)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Buttonsummit As Button
    Public WithEvents TextBoxstudentname As TextBox
End Class
