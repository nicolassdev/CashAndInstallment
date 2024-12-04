<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomer
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
        Me.components = New System.ComponentModel.Container()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.idpicture = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Lbl = New System.Windows.Forms.Label()
        Me.gbCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.dgCusInfo = New System.Windows.Forms.DataGridView()
        CType(Me.idpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCustomerInfo.SuspendLayout()
        CType(Me.dgCusInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(28, 69)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(218, 20)
        Me.txtID.TabIndex = 0
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Location = New System.Drawing.Point(28, 122)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(218, 20)
        Me.txtFname.TabIndex = 1
        '
        'txtMname
        '
        Me.txtMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMname.Location = New System.Drawing.Point(28, 185)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(218, 20)
        Me.txtMname.TabIndex = 2
        '
        'txtLname
        '
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLname.Location = New System.Drawing.Point(28, 245)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(218, 20)
        Me.txtLname.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(28, 296)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(218, 43)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = ""
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(28, 374)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(218, 20)
        Me.txtEmail.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "First name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Middle name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email Address"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(29, 426)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(218, 20)
        Me.txtPhone.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CP number"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(339, 565)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(255, 20)
        Me.txtPath.TabIndex = 13
        Me.txtPath.Visible = False
        '
        'idpicture
        '
        Me.idpicture.BackColor = System.Drawing.Color.White
        Me.idpicture.Location = New System.Drawing.Point(349, 120)
        Me.idpicture.Name = "idpicture"
        Me.idpicture.Size = New System.Drawing.Size(198, 178)
        Me.idpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpicture.TabIndex = 14
        Me.idpicture.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(388, 305)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(123, 46)
        Me.btnUpload.TabIndex = 15
        Me.btnUpload.Text = "Upload Image"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.Location = New System.Drawing.Point(580, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 41)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save "
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnEdit.Location = New System.Drawing.Point(871, 212)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(121, 43)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.Location = New System.Drawing.Point(580, 287)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 43)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.ForeColor = System.Drawing.Color.Red
        Me.Lbl.Location = New System.Drawing.Point(70, 24)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(152, 18)
        Me.Lbl.TabIndex = 19
        Me.Lbl.Text = "                                    "
        '
        'gbCustomerInfo
        '
        Me.gbCustomerInfo.Controls.Add(Me.Label7)
        Me.gbCustomerInfo.Controls.Add(Me.txtPhone)
        Me.gbCustomerInfo.Controls.Add(Me.Label6)
        Me.gbCustomerInfo.Controls.Add(Me.Label5)
        Me.gbCustomerInfo.Controls.Add(Me.Label4)
        Me.gbCustomerInfo.Controls.Add(Me.Lbl)
        Me.gbCustomerInfo.Controls.Add(Me.Label3)
        Me.gbCustomerInfo.Controls.Add(Me.Label2)
        Me.gbCustomerInfo.Controls.Add(Me.Label1)
        Me.gbCustomerInfo.Controls.Add(Me.txtEmail)
        Me.gbCustomerInfo.Controls.Add(Me.txtAddress)
        Me.gbCustomerInfo.Controls.Add(Me.txtLname)
        Me.gbCustomerInfo.Controls.Add(Me.txtMname)
        Me.gbCustomerInfo.Controls.Add(Me.txtFname)
        Me.gbCustomerInfo.Controls.Add(Me.txtID)
        Me.gbCustomerInfo.Location = New System.Drawing.Point(27, 102)
        Me.gbCustomerInfo.Name = "gbCustomerInfo"
        Me.gbCustomerInfo.Size = New System.Drawing.Size(277, 472)
        Me.gbCustomerInfo.TabIndex = 20
        Me.gbCustomerInfo.TabStop = False
        Me.gbCustomerInfo.Text = "Add/Update Customer"
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnAdd.Location = New System.Drawing.Point(725, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 41)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add Customer"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.btnDelete.Location = New System.Drawing.Point(727, 287)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 43)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(957, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 43)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "X"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(249, 19)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(521, 42)
        Me.lbl1.TabIndex = 25
        Me.lbl1.Text = "CUSTOMER INFORMATION"
        '
        'dgCusInfo
        '
        Me.dgCusInfo.AllowUserToAddRows = False
        Me.dgCusInfo.AllowUserToDeleteRows = False
        Me.dgCusInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCusInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgCusInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCusInfo.Location = New System.Drawing.Point(324, 387)
        Me.dgCusInfo.Name = "dgCusInfo"
        Me.dgCusInfo.ReadOnly = True
        Me.dgCusInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCusInfo.Size = New System.Drawing.Size(668, 161)
        Me.dgCusInfo.TabIndex = 26
        '
        'frmAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1012, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgCusInfo)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gbCustomerInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.idpicture)
        Me.Controls.Add(Me.txtPath)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.idpicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCustomerInfo.ResumeLayout(False)
        Me.gbCustomerInfo.PerformLayout()
        CType(Me.dgCusInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents idpicture As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider4 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider5 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider6 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents gbCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents dgCusInfo As System.Windows.Forms.DataGridView
End Class
