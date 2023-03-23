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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnchckFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFolder = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Btntextfile = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Txttemaddress = New System.Windows.Forms.TextBox()
        Me.TxtPhnNum = New System.Windows.Forms.TextBox()
        Me.Txtemail = New System.Windows.Forms.TextBox()
        Me.TxtPcode2 = New System.Windows.Forms.TextBox()
        Me.TxtPerAddress = New System.Windows.Forms.TextBox()
        Me.Txtpcode = New System.Windows.Forms.TextBox()
        Me.TxtaNum = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(52, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(437, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "......."
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(556, 59)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(93, 23)
        Me.BtnCheck.TabIndex = 3
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(52, 180)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(333, 23)
        Me.TextBox2.TabIndex = 4
        '
        'BtnchckFile
        '
        Me.BtnchckFile.Location = New System.Drawing.Point(565, 180)
        Me.BtnchckFile.Name = "BtnchckFile"
        Me.BtnchckFile.Size = New System.Drawing.Size(93, 23)
        Me.BtnchckFile.TabIndex = 5
        Me.BtnchckFile.Text = "Check File"
        Me.BtnchckFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "How to check File or Directory exist in Path"
        '
        'BtnFolder
        '
        Me.BtnFolder.Location = New System.Drawing.Point(565, 240)
        Me.BtnFolder.Name = "BtnFolder"
        Me.BtnFolder.Size = New System.Drawing.Size(93, 23)
        Me.BtnFolder.TabIndex = 8
        Me.BtnFolder.Text = "Check Folder"
        Me.BtnFolder.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(52, 240)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(333, 23)
        Me.TextBox3.TabIndex = 7
        '
        'Btntextfile
        '
        Me.Btntextfile.Location = New System.Drawing.Point(389, 289)
        Me.Btntextfile.Name = "Btntextfile"
        Me.Btntextfile.Size = New System.Drawing.Size(177, 38)
        Me.Btntextfile.TabIndex = 10
        Me.Btntextfile.Text = "Open Text File"
        Me.Btntextfile.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(52, 363)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(445, 146)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(729, 566)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 12
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(625, 348)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(120, 23)
        Me.TxtId.TabIndex = 13
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(625, 426)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(120, 23)
        Me.TxtName.TabIndex = 14
        '
        'Txttemaddress
        '
        Me.Txttemaddress.Location = New System.Drawing.Point(625, 502)
        Me.Txttemaddress.Name = "Txttemaddress"
        Me.Txttemaddress.Size = New System.Drawing.Size(120, 23)
        Me.Txttemaddress.TabIndex = 16
        '
        'TxtPhnNum
        '
        Me.TxtPhnNum.Location = New System.Drawing.Point(1004, 348)
        Me.TxtPhnNum.Name = "TxtPhnNum"
        Me.TxtPhnNum.Size = New System.Drawing.Size(143, 23)
        Me.TxtPhnNum.TabIndex = 17
        '
        'Txtemail
        '
        Me.Txtemail.Location = New System.Drawing.Point(799, 426)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(128, 23)
        Me.Txtemail.TabIndex = 18
        '
        'TxtPcode2
        '
        Me.TxtPcode2.Location = New System.Drawing.Point(799, 502)
        Me.TxtPcode2.Name = "TxtPcode2"
        Me.TxtPcode2.Size = New System.Drawing.Size(128, 23)
        Me.TxtPcode2.TabIndex = 19
        '
        'TxtPerAddress
        '
        Me.TxtPerAddress.Location = New System.Drawing.Point(1004, 426)
        Me.TxtPerAddress.Name = "TxtPerAddress"
        Me.TxtPerAddress.Size = New System.Drawing.Size(143, 23)
        Me.TxtPerAddress.TabIndex = 20
        '
        'Txtpcode
        '
        Me.Txtpcode.Location = New System.Drawing.Point(1004, 502)
        Me.Txtpcode.Name = "Txtpcode"
        Me.Txtpcode.Size = New System.Drawing.Size(143, 23)
        Me.Txtpcode.TabIndex = 21
        '
        'TxtaNum
        '
        Me.TxtaNum.Location = New System.Drawing.Point(799, 348)
        Me.TxtaNum.Name = "TxtaNum"
        Me.TxtaNum.Size = New System.Drawing.Size(128, 23)
        Me.TxtaNum.TabIndex = 22
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(854, 570)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 19)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Split Text"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(32, 585)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(659, 150)
        Me.DataGridView2.TabIndex = 24
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(977, 567)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 25
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(1124, 566)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1307, 747)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtaNum)
        Me.Controls.Add(Me.Txtpcode)
        Me.Controls.Add(Me.TxtPerAddress)
        Me.Controls.Add(Me.TxtPcode2)
        Me.Controls.Add(Me.Txtemail)
        Me.Controls.Add(Me.TxtPhnNum)
        Me.Controls.Add(Me.Txttemaddress)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.Btntextfile)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnFolder)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnchckFile)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCheck As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnchckFile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFolder As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Btntextfile As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnInsert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Txttemaddress As TextBox
    Friend WithEvents TxtPhnNum As TextBox
    Friend WithEvents Txtemail As TextBox
    Friend WithEvents TxtPcode2 As TextBox
    Friend WithEvents TxtPerAddress As TextBox
    Friend WithEvents Txtpcode As TextBox
    Friend WithEvents TxtaNum As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
End Class
