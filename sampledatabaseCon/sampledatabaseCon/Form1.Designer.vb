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
        Me.TxtProductId = New System.Windows.Forms.TextBox()
        Me.TxtProductName = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.lblCRUD = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDesign = New System.Windows.Forms.TextBox()
        Me.ComColor = New System.Windows.Forms.ComboBox()
        Me.InsertDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioAllowed = New System.Windows.Forms.RadioButton()
        Me.RadioNotAllowed = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtProductId
        '
        Me.TxtProductId.Location = New System.Drawing.Point(304, 96)
        Me.TxtProductId.Name = "TxtProductId"
        Me.TxtProductId.Size = New System.Drawing.Size(111, 23)
        Me.TxtProductId.TabIndex = 0
        '
        'TxtProductName
        '
        Me.TxtProductName.Location = New System.Drawing.Point(304, 139)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(111, 23)
        Me.TxtProductName.TabIndex = 1
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblId.Location = New System.Drawing.Point(153, 96)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(79, 19)
        Me.LblId.TabIndex = 2
        Me.LblId.Text = "Product Id"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblName.Location = New System.Drawing.Point(153, 147)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(83, 19)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "Item Name"
        '
        'BtnInsert
        '
        Me.BtnInsert.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnInsert.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnInsert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnInsert.Location = New System.Drawing.Point(96, 379)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnInsert.Size = New System.Drawing.Size(111, 35)
        Me.BtnInsert.TabIndex = 4
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = False
        '
        'lblCRUD
        '
        Me.lblCRUD.AutoSize = True
        Me.lblCRUD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCRUD.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCRUD.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblCRUD.Location = New System.Drawing.Point(222, 36)
        Me.lblCRUD.Name = "lblCRUD"
        Me.lblCRUD.Size = New System.Drawing.Size(141, 19)
        Me.lblCRUD.TabIndex = 5
        Me.lblCRUD.Text = "CRUD Tutorial Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(153, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Design"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(153, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(153, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Insert Date"
        '
        'TxtDesign
        '
        Me.TxtDesign.Location = New System.Drawing.Point(304, 189)
        Me.TxtDesign.Name = "TxtDesign"
        Me.TxtDesign.Size = New System.Drawing.Size(111, 23)
        Me.TxtDesign.TabIndex = 9
        '
        'ComColor
        '
        Me.ComColor.FormattingEnabled = True
        Me.ComColor.Items.AddRange(New Object() {"Black", "Blue", "Red", "White", "Pink", "Violet"})
        Me.ComColor.Location = New System.Drawing.Point(304, 238)
        Me.ComColor.Name = "ComColor"
        Me.ComColor.Size = New System.Drawing.Size(111, 23)
        Me.ComColor.TabIndex = 10
        '
        'InsertDate
        '
        Me.InsertDate.Location = New System.Drawing.Point(304, 282)
        Me.InsertDate.Name = "InsertDate"
        Me.InsertDate.Size = New System.Drawing.Size(111, 23)
        Me.InsertDate.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(153, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Warranty Type"
        '
        'RadioAllowed
        '
        Me.RadioAllowed.AutoSize = True
        Me.RadioAllowed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioAllowed.Location = New System.Drawing.Point(304, 326)
        Me.RadioAllowed.Name = "RadioAllowed"
        Me.RadioAllowed.Size = New System.Drawing.Size(82, 23)
        Me.RadioAllowed.TabIndex = 13
        Me.RadioAllowed.TabStop = True
        Me.RadioAllowed.Text = "Allowed"
        Me.RadioAllowed.UseVisualStyleBackColor = True
        '
        'RadioNotAllowed
        '
        Me.RadioNotAllowed.AutoSize = True
        Me.RadioNotAllowed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioNotAllowed.Location = New System.Drawing.Point(392, 324)
        Me.RadioNotAllowed.Name = "RadioNotAllowed"
        Me.RadioNotAllowed.Size = New System.Drawing.Size(111, 23)
        Me.RadioNotAllowed.TabIndex = 14
        Me.RadioNotAllowed.TabStop = True
        Me.RadioNotAllowed.Text = "Not Allowed"
        Me.RadioNotAllowed.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 468)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(652, 161)
        Me.DataGridView1.TabIndex = 15
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnUpdate.Location = New System.Drawing.Point(252, 379)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnUpdate.Size = New System.Drawing.Size(111, 35)
        Me.BtnUpdate.TabIndex = 16
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDelete.Location = New System.Drawing.Point(403, 379)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDelete.Size = New System.Drawing.Size(111, 35)
        Me.BtnDelete.TabIndex = 17
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSearch.Location = New System.Drawing.Point(553, 379)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSearch.Size = New System.Drawing.Size(111, 35)
        Me.BtnSearch.TabIndex = 18
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(694, 640)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioNotAllowed)
        Me.Controls.Add(Me.RadioAllowed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InsertDate)
        Me.Controls.Add(Me.ComColor)
        Me.Controls.Add(Me.TxtDesign)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCRUD)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtProductName)
        Me.Controls.Add(Me.TxtProductId)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtProductId As TextBox
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents LblName As Label
    Friend WithEvents BtnInsert As Button
    Friend WithEvents lblCRUD As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDesign As TextBox
    Friend WithEvents ComColor As ComboBox
    Friend WithEvents InsertDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioAllowed As RadioButton
    Friend WithEvents RadioNotAllowed As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSearch As Button
End Class
