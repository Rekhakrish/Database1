<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Studentdetails
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
        Labelheading = New Label()
        LabelStudentId = New Label()
        DataGridView1 = New DataGridView()
        ComboBoxstudentid = New ComboBox()
        ButtonGetData = New Button()
        ButtonNext = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Labelheading
        ' 
        Labelheading.AutoSize = True
        Labelheading.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Labelheading.Location = New Point(305, 44)
        Labelheading.Name = "Labelheading"
        Labelheading.Size = New Size(85, 17)
        Labelheading.TabIndex = 0
        Labelheading.Text = "StudentData"' 
        ' LabelStudentId
        ' 
        LabelStudentId.AutoSize = True
        LabelStudentId.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LabelStudentId.Location = New Point(226, 117)
        LabelStudentId.Name = "LabelStudentId"
        LabelStudentId.Size = New Size(68, 17)
        LabelStudentId.TabIndex = 1
        LabelStudentId.Text = "StudentId"' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(32, 264)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(781, 204)
        DataGridView1.TabIndex = 2
        ' 
        ' ComboBoxstudentid
        ' 
        ComboBoxstudentid.FormattingEnabled = True
        ComboBoxstudentid.Items.AddRange(New Object() {"101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", ""})
        ComboBoxstudentid.Location = New Point(397, 111)
        ComboBoxstudentid.Name = "ComboBoxstudentid"
        ComboBoxstudentid.Size = New Size(121, 23)
        ComboBoxstudentid.TabIndex = 3
        ' 
        ' ButtonGetData
        ' 
        ButtonGetData.BackColor = SystemColors.ButtonHighlight
        ButtonGetData.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonGetData.Location = New Point(189, 187)
        ButtonGetData.Name = "ButtonGetData"
        ButtonGetData.Size = New Size(164, 37)
        ButtonGetData.TabIndex = 4
        ButtonGetData.Text = "Get Employee Details"
        ButtonGetData.UseVisualStyleBackColor = False
        ' 
        ' ButtonNext
        ' 
        ButtonNext.BackColor = SystemColors.ButtonHighlight
        ButtonNext.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonNext.ForeColor = SystemColors.ActiveCaptionText
        ButtonNext.Location = New Point(446, 187)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(89, 37)
        ButtonNext.TabIndex = 5
        ButtonNext.Text = "Next"
        ButtonNext.UseVisualStyleBackColor = False
        ' 
        ' Studentdetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.co5
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(862, 513)
        Controls.Add(ButtonNext)
        Controls.Add(ButtonGetData)
        Controls.Add(ComboBoxstudentid)
        Controls.Add(DataGridView1)
        Controls.Add(LabelStudentId)
        Controls.Add(Labelheading)
        Name = "Studentdetails"
        Text = "Studentdetails"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Labelheading As Label
    Friend WithEvents LabelStudentId As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBoxstudentid As ComboBox
    Friend WithEvents ButtonGetData As Button
    Friend WithEvents ButtonNext As Button
End Class
