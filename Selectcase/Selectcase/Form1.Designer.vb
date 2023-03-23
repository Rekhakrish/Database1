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
        Me.Btntemp = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btniteration = New System.Windows.Forms.Button()
        Me.BtnOddOrEven = New System.Windows.Forms.Button()
        Me.Btndowhile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btntemp
        '
        Me.Btntemp.Location = New System.Drawing.Point(297, 139)
        Me.Btntemp.Name = "Btntemp"
        Me.Btntemp.Size = New System.Drawing.Size(113, 58)
        Me.Btntemp.TabIndex = 1
        Me.Btntemp.Text = "Check Temperature" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btntemp.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(272, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Btniteration
        '
        Me.Btniteration.Location = New System.Drawing.Point(297, 250)
        Me.Btniteration.Name = "Btniteration"
        Me.Btniteration.Size = New System.Drawing.Size(113, 36)
        Me.Btniteration.TabIndex = 3
        Me.Btniteration.Text = "Go iteration"
        Me.Btniteration.UseVisualStyleBackColor = True
        '
        'BtnOddOrEven
        '
        Me.BtnOddOrEven.Location = New System.Drawing.Point(297, 350)
        Me.BtnOddOrEven.Name = "BtnOddOrEven"
        Me.BtnOddOrEven.Size = New System.Drawing.Size(135, 36)
        Me.BtnOddOrEven.TabIndex = 4
        Me.BtnOddOrEven.Text = "Count Up Odd or Even"
        Me.BtnOddOrEven.UseVisualStyleBackColor = True
        '
        'Btndowhile
        '
        Me.Btndowhile.Location = New System.Drawing.Point(572, 139)
        Me.Btndowhile.Name = "Btndowhile"
        Me.Btndowhile.Size = New System.Drawing.Size(135, 36)
        Me.Btndowhile.TabIndex = 5
        Me.Btndowhile.Text = "Do while"
        Me.Btndowhile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btndowhile)
        Me.Controls.Add(Me.BtnOddOrEven)
        Me.Controls.Add(Me.Btniteration)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btntemp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btntemp As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btniteration As Button
    Friend WithEvents BtnOddOrEven As Button
    Friend WithEvents Btndowhile As Button
End Class
