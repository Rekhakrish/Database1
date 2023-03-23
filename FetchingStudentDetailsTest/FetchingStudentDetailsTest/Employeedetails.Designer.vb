<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employeedetails
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
        ButtonSalary = New Button()
        ButtonGroupBy = New Button()
        DataGridView1 = New DataGridView()
        labelHeading = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonSalary
        ' 
        ButtonSalary.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonSalary.Location = New Point(209, 164)
        ButtonSalary.Name = "ButtonSalary"
        ButtonSalary.Size = New Size(109, 32)
        ButtonSalary.TabIndex = 0
        ButtonSalary.Text = "Salary Order by"
        ButtonSalary.UseVisualStyleBackColor = True
        ' 
        ' ButtonGroupBy
        ' 
        ButtonGroupBy.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonGroupBy.Location = New Point(420, 164)
        ButtonGroupBy.Name = "ButtonGroupBy"
        ButtonGroupBy.Size = New Size(88, 32)
        ButtonGroupBy.TabIndex = 1
        ButtonGroupBy.Text = "Group By"
        ButtonGroupBy.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(55, 267)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(707, 150)
        DataGridView1.TabIndex = 2
        ' 
        ' labelHeading
        ' 
        labelHeading.AutoSize = True
        labelHeading.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        labelHeading.Location = New Point(313, 65)
        labelHeading.Name = "labelHeading"
        labelHeading.Size = New Size(101, 17)
        labelHeading.TabIndex = 3
        labelHeading.Text = "Employee Data" ' 
        ' Employeedetails
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.co51
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(labelHeading)
        Controls.Add(DataGridView1)
        Controls.Add(ButtonGroupBy)
        Controls.Add(ButtonSalary)
        Name = "Employeedetails"
        Text = "Employeedetails"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonSalary As Button
    Friend WithEvents ButtonGroupBy As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labelHeading As Label
End Class
