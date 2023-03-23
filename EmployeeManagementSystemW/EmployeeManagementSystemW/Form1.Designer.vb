<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormofEmp
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
        Me.Employeemanagementsystem = New System.Windows.Forms.Label()
        Me.LblEmpID = New System.Windows.Forms.Label()
        Me.LblEmpName = New System.Windows.Forms.Label()
        Me.LblBasicpay = New System.Windows.Forms.Label()
        Me.Lblsalary = New System.Windows.Forms.Label()
        Me.LblHra = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Btncreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnViewAll = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Btnsavecsv = New System.Windows.Forms.Button()
        Me.BtnSaveAsJson = New System.Windows.Forms.Button()
        Me.BtnSaveasXml = New System.Windows.Forms.Button()
        Me.empIdtxt = New System.Windows.Forms.TextBox()
        Me.txtempname = New System.Windows.Forms.TextBox()
        Me.Txtbasic = New System.Windows.Forms.TextBox()
        Me.Txtsalary = New System.Windows.Forms.TextBox()
        Me.TxtHra = New System.Windows.Forms.TextBox()
        Me.Btnloadcsv = New System.Windows.Forms.Button()
        Me.BtnLoadJson = New System.Windows.Forms.Button()
        Me.BtnLoasXml = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Employeemanagementsystem
        '
        Me.Employeemanagementsystem.AutoSize = True
        Me.Employeemanagementsystem.BackColor = System.Drawing.SystemColors.Control
        Me.Employeemanagementsystem.Location = New System.Drawing.Point(244, 28)
        Me.Employeemanagementsystem.Name = "Employeemanagementsystem"
        Me.Employeemanagementsystem.Size = New System.Drawing.Size(174, 15)
        Me.Employeemanagementsystem.TabIndex = 0
        Me.Employeemanagementsystem.Text = "Employee Management System"
        '
        'LblEmpID
        '
        Me.LblEmpID.AutoSize = True
        Me.LblEmpID.Location = New System.Drawing.Point(72, 76)
        Me.LblEmpID.Name = "LblEmpID"
        Me.LblEmpID.Size = New System.Drawing.Size(72, 15)
        Me.LblEmpID.TabIndex = 1
        Me.LblEmpID.Text = "Employee Id"
        '
        'LblEmpName
        '
        Me.LblEmpName.AutoSize = True
        Me.LblEmpName.Location = New System.Drawing.Point(72, 131)
        Me.LblEmpName.Name = "LblEmpName"
        Me.LblEmpName.Size = New System.Drawing.Size(94, 15)
        Me.LblEmpName.TabIndex = 2
        Me.LblEmpName.Text = "Employee Name"
        '
        'LblBasicpay
        '
        Me.LblBasicpay.AutoSize = True
        Me.LblBasicpay.Location = New System.Drawing.Point(72, 191)
        Me.LblBasicpay.Name = "LblBasicpay"
        Me.LblBasicpay.Size = New System.Drawing.Size(53, 15)
        Me.LblBasicpay.TabIndex = 3
        Me.LblBasicpay.Text = "BasicPay"
        '
        'Lblsalary
        '
        Me.Lblsalary.AutoSize = True
        Me.Lblsalary.Location = New System.Drawing.Point(72, 251)
        Me.Lblsalary.Name = "Lblsalary"
        Me.Lblsalary.Size = New System.Drawing.Size(38, 15)
        Me.Lblsalary.TabIndex = 4
        Me.Lblsalary.Text = "Salary"
        '
        'LblHra
        '
        Me.LblHra.AutoSize = True
        Me.LblHra.Location = New System.Drawing.Point(444, 76)
        Me.LblHra.Name = "LblHra"
        Me.LblHra.Size = New System.Drawing.Size(31, 15)
        Me.LblHra.TabIndex = 5
        Me.LblHra.Text = "HRA"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(444, 129)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 19)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Active"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(537, 127)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(68, 19)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "InActive"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Btncreate
        '
        Me.Btncreate.Location = New System.Drawing.Point(50, 313)
        Me.Btncreate.Name = "Btncreate"
        Me.Btncreate.Size = New System.Drawing.Size(75, 23)
        Me.Btncreate.TabIndex = 8
        Me.Btncreate.Text = "Create"
        Me.Btncreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(160, 313)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(277, 313)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 10
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(390, 313)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 11
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnViewAll
        '
        Me.BtnViewAll.Location = New System.Drawing.Point(512, 313)
        Me.BtnViewAll.Name = "BtnViewAll"
        Me.BtnViewAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnViewAll.TabIndex = 12
        Me.BtnViewAll.Text = "ViewAll"
        Me.BtnViewAll.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(50, 381)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(474, 182)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Btnsavecsv
        '
        Me.Btnsavecsv.Location = New System.Drawing.Point(596, 380)
        Me.Btnsavecsv.Name = "Btnsavecsv"
        Me.Btnsavecsv.Size = New System.Drawing.Size(91, 23)
        Me.Btnsavecsv.TabIndex = 14
        Me.Btnsavecsv.Text = "SaveAsCSV"
        Me.Btnsavecsv.UseVisualStyleBackColor = True
        '
        'BtnSaveAsJson
        '
        Me.BtnSaveAsJson.Location = New System.Drawing.Point(596, 441)
        Me.BtnSaveAsJson.Name = "BtnSaveAsJson"
        Me.BtnSaveAsJson.Size = New System.Drawing.Size(91, 23)
        Me.BtnSaveAsJson.TabIndex = 15
        Me.BtnSaveAsJson.Text = "SaveAsJSON"
        Me.BtnSaveAsJson.UseVisualStyleBackColor = True
        '
        'BtnSaveasXml
        '
        Me.BtnSaveasXml.Location = New System.Drawing.Point(596, 507)
        Me.BtnSaveasXml.Name = "BtnSaveasXml"
        Me.BtnSaveasXml.Size = New System.Drawing.Size(91, 23)
        Me.BtnSaveasXml.TabIndex = 16
        Me.BtnSaveasXml.Text = "SaveAsXML"
        Me.BtnSaveasXml.UseVisualStyleBackColor = True
        '
        'empIdtxt
        '
        Me.empIdtxt.Location = New System.Drawing.Point(277, 68)
        Me.empIdtxt.Name = "empIdtxt"
        Me.empIdtxt.Size = New System.Drawing.Size(100, 23)
        Me.empIdtxt.TabIndex = 17
        '
        'txtempname
        '
        Me.txtempname.Location = New System.Drawing.Point(277, 123)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.Size = New System.Drawing.Size(100, 23)
        Me.txtempname.TabIndex = 18
        '
        'Txtbasic
        '
        Me.Txtbasic.Location = New System.Drawing.Point(277, 183)
        Me.Txtbasic.Name = "Txtbasic"
        Me.Txtbasic.Size = New System.Drawing.Size(100, 23)
        Me.Txtbasic.TabIndex = 19
        '
        'Txtsalary
        '
        Me.Txtsalary.Location = New System.Drawing.Point(277, 243)
        Me.Txtsalary.Name = "Txtsalary"
        Me.Txtsalary.Size = New System.Drawing.Size(100, 23)
        Me.Txtsalary.TabIndex = 20
        '
        'TxtHra
        '
        Me.TxtHra.Location = New System.Drawing.Point(628, 68)
        Me.TxtHra.Name = "TxtHra"
        Me.TxtHra.Size = New System.Drawing.Size(100, 23)
        Me.TxtHra.TabIndex = 21
        '
        'Btnloadcsv
        '
        Me.Btnloadcsv.Location = New System.Drawing.Point(744, 381)
        Me.Btnloadcsv.Name = "Btnloadcsv"
        Me.Btnloadcsv.Size = New System.Drawing.Size(75, 23)
        Me.Btnloadcsv.TabIndex = 22
        Me.Btnloadcsv.Text = "LoadAsCsv"
        Me.Btnloadcsv.UseVisualStyleBackColor = True
        '
        'BtnLoadJson
        '
        Me.BtnLoadJson.Location = New System.Drawing.Point(744, 441)
        Me.BtnLoadJson.Name = "BtnLoadJson"
        Me.BtnLoadJson.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoadJson.TabIndex = 23
        Me.BtnLoadJson.Text = "LoasAsJson"
        Me.BtnLoadJson.UseVisualStyleBackColor = True
        '
        'BtnLoasXml
        '
        Me.BtnLoasXml.Location = New System.Drawing.Point(744, 507)
        Me.BtnLoasXml.Name = "BtnLoasXml"
        Me.BtnLoasXml.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoasXml.TabIndex = 24
        Me.BtnLoasXml.Text = "LoadAsXML"
        Me.BtnLoasXml.UseVisualStyleBackColor = True
        '
        'FormofEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(876, 619)
        Me.Controls.Add(Me.BtnLoasXml)
        Me.Controls.Add(Me.BtnLoadJson)
        Me.Controls.Add(Me.Btnloadcsv)
        Me.Controls.Add(Me.TxtHra)
        Me.Controls.Add(Me.Txtsalary)
        Me.Controls.Add(Me.Txtbasic)
        Me.Controls.Add(Me.txtempname)
        Me.Controls.Add(Me.empIdtxt)
        Me.Controls.Add(Me.BtnSaveasXml)
        Me.Controls.Add(Me.BtnSaveAsJson)
        Me.Controls.Add(Me.Btnsavecsv)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnViewAll)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Btncreate)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LblHra)
        Me.Controls.Add(Me.Lblsalary)
        Me.Controls.Add(Me.LblBasicpay)
        Me.Controls.Add(Me.LblEmpName)
        Me.Controls.Add(Me.LblEmpID)
        Me.Controls.Add(Me.Employeemanagementsystem)
        Me.Name = "FormofEmp"
        Me.Text = "EmployeeManagementSystem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Employeemanagementsystem As Label
    Friend WithEvents LblEmpID As Label
    Friend WithEvents LblEmpName As Label
    Friend WithEvents LblBasicpay As Label
    Friend WithEvents Lblsalary As Label
    Friend WithEvents LblHra As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Btncreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnView As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnViewAll As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Btnsavecsv As Button
    Friend WithEvents BtnSaveAsJson As Button
    Friend WithEvents BtnSaveasXml As Button
    Friend WithEvents empIdtxt As TextBox
    Friend WithEvents txtempname As TextBox
    Friend WithEvents Txtbasic As TextBox
    Friend WithEvents Txtsalary As TextBox
    Friend WithEvents TxtHra As TextBox
    Friend WithEvents Btnloadcsv As Button
    Friend WithEvents BtnLoadJson As Button
    Friend WithEvents BtnLoasXml As Button
End Class
