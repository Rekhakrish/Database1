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
        Me.components = New System.ComponentModel.Container()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblEmpId = New System.Windows.Forms.Label()
        Me.LblEmpName = New System.Windows.Forms.Label()
        Me.LblNofPresent = New System.Windows.Forms.Label()
        Me.LblBasicpay = New System.Windows.Forms.Label()
        Me.LblHra = New System.Windows.Forms.Label()
        Me.TxtEmpId = New System.Windows.Forms.TextBox()
        Me.TxtEmpName = New System.Windows.Forms.TextBox()
        Me.TxtNofPresent = New System.Windows.Forms.TextBox()
        Me.TxtBasicpay = New System.Windows.Forms.TextBox()
        Me.TxtHra = New System.Windows.Forms.TextBox()
        Me.TxtOtherAll = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btngross = New System.Windows.Forms.Button()
        Me.LblOtherAll = New System.Windows.Forms.Label()
        Me.Lblgross = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblTax = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblNetSal = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BtnTax = New System.Windows.Forms.Button()
        Me.BtnNetSalary = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LblTitle.Location = New System.Drawing.Point(282, 22)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(157, 19)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Employee Information"
        '
        'LblEmpId
        '
        Me.LblEmpId.AutoSize = True
        Me.LblEmpId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEmpId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblEmpId.Location = New System.Drawing.Point(152, 85)
        Me.LblEmpId.Name = "LblEmpId"
        Me.LblEmpId.Size = New System.Drawing.Size(68, 15)
        Me.LblEmpId.TabIndex = 1
        Me.LblEmpId.Text = "EmployeeId"
        '
        'LblEmpName
        '
        Me.LblEmpName.AutoSize = True
        Me.LblEmpName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblEmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblEmpName.Location = New System.Drawing.Point(152, 132)
        Me.LblEmpName.Name = "LblEmpName"
        Me.LblEmpName.Size = New System.Drawing.Size(89, 15)
        Me.LblEmpName.TabIndex = 2
        Me.LblEmpName.Text = "EmployeeName"
        '
        'LblNofPresent
        '
        Me.LblNofPresent.AutoSize = True
        Me.LblNofPresent.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNofPresent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNofPresent.Location = New System.Drawing.Point(152, 187)
        Me.LblNofPresent.Name = "LblNofPresent"
        Me.LblNofPresent.Size = New System.Drawing.Size(140, 15)
        Me.LblNofPresent.TabIndex = 3
        Me.LblNofPresent.Text = "Number of Days Present"
        '
        'LblBasicpay
        '
        Me.LblBasicpay.AutoSize = True
        Me.LblBasicpay.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblBasicpay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblBasicpay.Location = New System.Drawing.Point(152, 248)
        Me.LblBasicpay.Name = "LblBasicpay"
        Me.LblBasicpay.Size = New System.Drawing.Size(61, 15)
        Me.LblBasicpay.TabIndex = 4
        Me.LblBasicpay.Text = "Basic Pay"
        '
        'LblHra
        '
        Me.LblHra.AutoSize = True
        Me.LblHra.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblHra.Location = New System.Drawing.Point(152, 310)
        Me.LblHra.Name = "LblHra"
        Me.LblHra.Size = New System.Drawing.Size(34, 15)
        Me.LblHra.TabIndex = 6
        Me.LblHra.Text = "HRA"
        '
        'TxtEmpId
        '
        Me.TxtEmpId.Location = New System.Drawing.Point(371, 77)
        Me.TxtEmpId.Name = "TxtEmpId"
        Me.TxtEmpId.Size = New System.Drawing.Size(100, 23)
        Me.TxtEmpId.TabIndex = 8
        '
        'TxtEmpName
        '
        Me.TxtEmpName.Location = New System.Drawing.Point(371, 129)
        Me.TxtEmpName.Name = "TxtEmpName"
        Me.TxtEmpName.Size = New System.Drawing.Size(100, 23)
        Me.TxtEmpName.TabIndex = 9
        '
        'TxtNofPresent
        '
        Me.TxtNofPresent.Location = New System.Drawing.Point(371, 187)
        Me.TxtNofPresent.Name = "TxtNofPresent"
        Me.TxtNofPresent.Size = New System.Drawing.Size(100, 23)
        Me.TxtNofPresent.TabIndex = 10
        '
        'TxtBasicpay
        '
        Me.TxtBasicpay.Location = New System.Drawing.Point(371, 248)
        Me.TxtBasicpay.Name = "TxtBasicpay"
        Me.TxtBasicpay.Size = New System.Drawing.Size(100, 23)
        Me.TxtBasicpay.TabIndex = 11
        '
        'TxtHra
        '
        Me.TxtHra.Location = New System.Drawing.Point(371, 302)
        Me.TxtHra.Name = "TxtHra"
        Me.TxtHra.Size = New System.Drawing.Size(100, 23)
        Me.TxtHra.TabIndex = 12
        '
        'TxtOtherAll
        '
        Me.TxtOtherAll.Location = New System.Drawing.Point(371, 364)
        Me.TxtOtherAll.Name = "TxtOtherAll"
        Me.TxtOtherAll.Size = New System.Drawing.Size(100, 23)
        Me.TxtOtherAll.TabIndex = 13
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAdd.Location = New System.Drawing.Point(295, 492)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(64, 32)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 540)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1044, 207)
        Me.DataGridView1.TabIndex = 16
        '
        'Btngross
        '
        Me.Btngross.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btngross.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btngross.Location = New System.Drawing.Point(282, 446)
        Me.Btngross.Name = "Btngross"
        Me.Btngross.Size = New System.Drawing.Size(89, 35)
        Me.Btngross.TabIndex = 17
        Me.Btngross.Text = "Gross Salary"
        Me.Btngross.UseVisualStyleBackColor = True
        '
        'LblOtherAll
        '
        Me.LblOtherAll.AutoSize = True
        Me.LblOtherAll.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblOtherAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblOtherAll.Location = New System.Drawing.Point(152, 372)
        Me.LblOtherAll.Name = "LblOtherAll"
        Me.LblOtherAll.Size = New System.Drawing.Size(104, 15)
        Me.LblOtherAll.TabIndex = 5
        Me.LblOtherAll.Text = "Other Allowances"
        '
        'Lblgross
        '
        Me.Lblgross.AutoSize = True
        Me.Lblgross.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lblgross.Location = New System.Drawing.Point(152, 419)
        Me.Lblgross.Name = "Lblgross"
        Me.Lblgross.Size = New System.Drawing.Size(82, 15)
        Me.Lblgross.TabIndex = 18
        Me.Lblgross.Text = "TotalgrossPay"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(371, 416)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 19
        '
        'LblTax
        '
        Me.LblTax.AutoSize = True
        Me.LblTax.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTax.Location = New System.Drawing.Point(651, 77)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(26, 15)
        Me.LblTax.TabIndex = 20
        Me.LblTax.Text = "Tax"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(797, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 21
        '
        'LblNetSal
        '
        Me.LblNetSal.AutoSize = True
        Me.LblNetSal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNetSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNetSal.Location = New System.Drawing.Point(651, 132)
        Me.LblNetSal.Name = "LblNetSal"
        Me.LblNetSal.Size = New System.Drawing.Size(65, 15)
        Me.LblNetSal.TabIndex = 22
        Me.LblNetSal.Text = "Net Salary"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(797, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 23)
        Me.TextBox3.TabIndex = 23
        '
        'BtnTax
        '
        Me.BtnTax.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnTax.Location = New System.Drawing.Point(516, 446)
        Me.BtnTax.Name = "BtnTax"
        Me.BtnTax.Size = New System.Drawing.Size(101, 35)
        Me.BtnTax.TabIndex = 24
        Me.BtnTax.Text = "Tax"
        Me.BtnTax.UseVisualStyleBackColor = True
        '
        'BtnNetSalary
        '
        Me.BtnNetSalary.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnNetSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNetSalary.Location = New System.Drawing.Point(757, 446)
        Me.BtnNetSalary.Name = "BtnNetSalary"
        Me.BtnNetSalary.Size = New System.Drawing.Size(101, 35)
        Me.BtnNetSalary.TabIndex = 25
        Me.BtnNetSalary.Text = "Net Salary"
        Me.BtnNetSalary.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUpdate.Location = New System.Drawing.Point(440, 492)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(64, 32)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDelete.Location = New System.Drawing.Point(613, 492)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(64, 32)
        Me.BtnDelete.TabIndex = 27
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSearch.Location = New System.Drawing.Point(784, 492)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(64, 32)
        Me.BtnSearch.TabIndex = 28
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(1068, 775)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnNetSalary)
        Me.Controls.Add(Me.BtnTax)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LblNetSal)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblTax)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lblgross)
        Me.Controls.Add(Me.Btngross)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtOtherAll)
        Me.Controls.Add(Me.TxtHra)
        Me.Controls.Add(Me.TxtBasicpay)
        Me.Controls.Add(Me.TxtNofPresent)
        Me.Controls.Add(Me.TxtEmpName)
        Me.Controls.Add(Me.TxtEmpId)
        Me.Controls.Add(Me.LblHra)
        Me.Controls.Add(Me.LblOtherAll)
        Me.Controls.Add(Me.LblBasicpay)
        Me.Controls.Add(Me.LblNofPresent)
        Me.Controls.Add(Me.LblEmpName)
        Me.Controls.Add(Me.LblEmpId)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblEmpId As Label
    Friend WithEvents LblEmpName As Label
    Friend WithEvents LblNofPresent As Label
    Friend WithEvents LblBasicpay As Label
    Friend WithEvents LblHra As Label
    Friend WithEvents TxtEmpId As TextBox
    Friend WithEvents TxtEmpName As TextBox
    Friend WithEvents TxtNofPresent As TextBox
    Friend WithEvents TxtBasicpay As TextBox
    Friend WithEvents TxtHra As TextBox
    Friend WithEvents TxtOtherAll As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btngross As Button
    Friend WithEvents LblOtherAll As Label
    Friend WithEvents Lblgross As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblTax As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblNetSal As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BtnTax As Button
    Friend WithEvents BtnNetSalary As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
