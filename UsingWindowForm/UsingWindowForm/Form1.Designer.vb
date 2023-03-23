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
        Me.BtntoGo = New System.Windows.Forms.Button()
        Me.LblFirstname = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtntoGo
        '
        Me.BtntoGo.Location = New System.Drawing.Point(283, 257)
        Me.BtntoGo.Name = "BtntoGo"
        Me.BtntoGo.Size = New System.Drawing.Size(160, 59)
        Me.BtntoGo.TabIndex = 0
        Me.BtntoGo.Text = "Go"
        Me.BtntoGo.UseVisualStyleBackColor = True
        '
        'LblFirstname
        '
        Me.LblFirstname.AutoSize = True
        Me.LblFirstname.Location = New System.Drawing.Point(245, 50)
        Me.LblFirstname.Name = "LblFirstname"
        Me.LblFirstname.Size = New System.Drawing.Size(54, 13)
        Me.LblFirstname.TabIndex = 1
        Me.LblFirstname.Text = "FirstName"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Location = New System.Drawing.Point(245, 104)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(55, 13)
        Me.lbllastname.TabIndex = 2
        Me.lbllastname.Text = "LastName"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(245, 178)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(42, 13)
        Me.lblgender.TabIndex = 3
        Me.lblgender.Text = "Gender"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(381, 43)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstname.TabIndex = 4
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(381, 97)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 20)
        Me.txtlastname.TabIndex = 5
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(381, 175)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(100, 20)
        Me.txtgender.TabIndex = 6
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.Items.AddRange(New Object() {"Teacher", "Doctor", "Engineer", "Fashion Designer", "House Wife", "Agriculture"})
        Me.lstOccupation.Location = New System.Drawing.Point(602, 74)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(120, 95)
        Me.lstOccupation.TabIndex = 7
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(599, 43)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(62, 13)
        Me.lblOccupation.TabIndex = 8
        Me.lblOccupation.Text = "Occupation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lbllastname)
        Me.Controls.Add(Me.LblFirstname)
        Me.Controls.Add(Me.BtntoGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtntoGo As Button
    Friend WithEvents LblFirstname As Label
    Friend WithEvents lbllastname As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtgender As TextBox
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
End Class
