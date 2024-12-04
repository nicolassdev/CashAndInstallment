<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCash
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.idpicture = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbItemInfo = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDisPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.idpicture1 = New System.Windows.Forms.PictureBox()
        Me.txtPath1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgCusInfo = New System.Windows.Forms.DataGridView()
        Me.dgItemInfo = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSearchCust = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSearchItem = New System.Windows.Forms.TextBox()
        Me.gbCustomerInfo.SuspendLayout()
        CType(Me.idpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemInfo.SuspendLayout()
        CType(Me.idpicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCusInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgItemInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1223, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(53, 43)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "X"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(36, 53)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(139, 20)
        Me.txtID.TabIndex = 25
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Location = New System.Drawing.Point(36, 102)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(93, 20)
        Me.txtFname.TabIndex = 26
        '
        'txtMname
        '
        Me.txtMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMname.Location = New System.Drawing.Point(146, 102)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(93, 20)
        Me.txtMname.TabIndex = 27
        '
        'txtLname
        '
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLname.Location = New System.Drawing.Point(260, 102)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(93, 20)
        Me.txtLname.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(485, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 39)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "CASH BASIS ENTRY"
        '
        'gbCustomerInfo
        '
        Me.gbCustomerInfo.Controls.Add(Me.Label9)
        Me.gbCustomerInfo.Controls.Add(Me.txtEmail)
        Me.gbCustomerInfo.Controls.Add(Me.Label8)
        Me.gbCustomerInfo.Controls.Add(Me.txtPath)
        Me.gbCustomerInfo.Controls.Add(Me.idpicture)
        Me.gbCustomerInfo.Controls.Add(Me.Label7)
        Me.gbCustomerInfo.Controls.Add(Me.txtPhone)
        Me.gbCustomerInfo.Controls.Add(Me.Label6)
        Me.gbCustomerInfo.Controls.Add(Me.Label5)
        Me.gbCustomerInfo.Controls.Add(Me.Label4)
        Me.gbCustomerInfo.Controls.Add(Me.Label3)
        Me.gbCustomerInfo.Controls.Add(Me.txtAddress)
        Me.gbCustomerInfo.Controls.Add(Me.Label2)
        Me.gbCustomerInfo.Controls.Add(Me.txtLname)
        Me.gbCustomerInfo.Controls.Add(Me.txtMname)
        Me.gbCustomerInfo.Controls.Add(Me.txtFname)
        Me.gbCustomerInfo.Controls.Add(Me.txtID)
        Me.gbCustomerInfo.Location = New System.Drawing.Point(27, 75)
        Me.gbCustomerInfo.Name = "gbCustomerInfo"
        Me.gbCustomerInfo.Size = New System.Drawing.Size(583, 202)
        Me.gbCustomerInfo.TabIndex = 30
        Me.gbCustomerInfo.TabStop = False
        Me.gbCustomerInfo.Text = "Customer Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(156, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(156, 149)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(114, 20)
        Me.txtEmail.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(459, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "PROFILE"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(61, 178)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(177, 20)
        Me.txtPath.TabIndex = 38
        Me.txtPath.Visible = False
        '
        'idpicture
        '
        Me.idpicture.BackColor = System.Drawing.Color.White
        Me.idpicture.Location = New System.Drawing.Point(414, 19)
        Me.idpicture.Name = "idpicture"
        Me.idpicture.Size = New System.Drawing.Size(143, 136)
        Me.idpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpicture.TabIndex = 37
        Me.idpicture.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Address"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(276, 149)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(114, 20)
        Me.txtPhone.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Last name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Middle name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "First name"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(36, 149)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(114, 20)
        Me.txtAddress.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Customer ID"
        '
        'gbItemInfo
        '
        Me.gbItemInfo.Controls.Add(Me.txtDate)
        Me.gbItemInfo.Controls.Add(Me.Label20)
        Me.gbItemInfo.Controls.Add(Me.txtDisPrice)
        Me.gbItemInfo.Controls.Add(Me.txtDiscount)
        Me.gbItemInfo.Controls.Add(Me.txtTotalPrice)
        Me.gbItemInfo.Controls.Add(Me.Label19)
        Me.gbItemInfo.Controls.Add(Me.Label18)
        Me.gbItemInfo.Controls.Add(Me.Label17)
        Me.gbItemInfo.Controls.Add(Me.Label16)
        Me.gbItemInfo.Controls.Add(Me.txtPayment)
        Me.gbItemInfo.Controls.Add(Me.Label15)
        Me.gbItemInfo.Controls.Add(Me.txtQty)
        Me.gbItemInfo.Controls.Add(Me.Label14)
        Me.gbItemInfo.Controls.Add(Me.idpicture1)
        Me.gbItemInfo.Controls.Add(Me.txtPath1)
        Me.gbItemInfo.Controls.Add(Me.Label13)
        Me.gbItemInfo.Controls.Add(Me.txtDesc)
        Me.gbItemInfo.Controls.Add(Me.Label12)
        Me.gbItemInfo.Controls.Add(Me.Label11)
        Me.gbItemInfo.Controls.Add(Me.txtPrice)
        Me.gbItemInfo.Controls.Add(Me.txtItemName)
        Me.gbItemInfo.Controls.Add(Me.txtItemID)
        Me.gbItemInfo.Controls.Add(Me.Label10)
        Me.gbItemInfo.Location = New System.Drawing.Point(649, 85)
        Me.gbItemInfo.Name = "gbItemInfo"
        Me.gbItemInfo.Size = New System.Drawing.Size(598, 294)
        Me.gbItemInfo.TabIndex = 31
        Me.gbItemInfo.TabStop = False
        Me.gbItemInfo.Text = "Item Information"
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Location = New System.Drawing.Point(40, 259)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(141, 20)
        Me.txtDate.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(37, 244)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Date and Time"
        '
        'txtDisPrice
        '
        Me.txtDisPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisPrice.Location = New System.Drawing.Point(348, 214)
        Me.txtDisPrice.Name = "txtDisPrice"
        Me.txtDisPrice.Size = New System.Drawing.Size(148, 20)
        Me.txtDisPrice.TabIndex = 21
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Location = New System.Drawing.Point(194, 214)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(148, 20)
        Me.txtDiscount.TabIndex = 20
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPrice.Location = New System.Drawing.Point(40, 214)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(148, 20)
        Me.txtTotalPrice.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(37, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Payment"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(345, 198)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Discounted Price"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(191, 198)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Discount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(37, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Total Price"
        '
        'txtPayment
        '
        Me.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPayment.Location = New System.Drawing.Point(40, 151)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(148, 20)
        Me.txtPayment.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Quantity"
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Location = New System.Drawing.Point(40, 109)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(148, 20)
        Me.txtQty.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(464, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "ITEM PICTURE"
        '
        'idpicture1
        '
        Me.idpicture1.BackColor = System.Drawing.Color.White
        Me.idpicture1.Location = New System.Drawing.Point(429, 29)
        Me.idpicture1.Name = "idpicture1"
        Me.idpicture1.Size = New System.Drawing.Size(150, 142)
        Me.idpicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpicture1.TabIndex = 10
        Me.idpicture1.TabStop = False
        '
        'txtPath1
        '
        Me.txtPath1.Location = New System.Drawing.Point(429, 274)
        Me.txtPath1.Multiline = True
        Me.txtPath1.Name = "txtPath1"
        Me.txtPath1.Size = New System.Drawing.Size(161, 14)
        Me.txtPath1.TabIndex = 9
        Me.txtPath1.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(204, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Item Description"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(207, 108)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(200, 63)
        Me.txtDesc.TabIndex = 7
        Me.txtDesc.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(296, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Item Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(168, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Item Name"
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(299, 53)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(108, 20)
        Me.txtPrice.TabIndex = 3
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Location = New System.Drawing.Point(171, 53)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(108, 20)
        Me.txtItemName.TabIndex = 2
        '
        'txtItemID
        '
        Me.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemID.Location = New System.Drawing.Point(40, 53)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(108, 20)
        Me.txtItemID.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Item ID"
        '
        'dgCusInfo
        '
        Me.dgCusInfo.AllowUserToAddRows = False
        Me.dgCusInfo.AllowUserToDeleteRows = False
        Me.dgCusInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCusInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgCusInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCusInfo.Location = New System.Drawing.Point(38, 319)
        Me.dgCusInfo.Name = "dgCusInfo"
        Me.dgCusInfo.ReadOnly = True
        Me.dgCusInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCusInfo.Size = New System.Drawing.Size(572, 128)
        Me.dgCusInfo.TabIndex = 32
        '
        'dgItemInfo
        '
        Me.dgItemInfo.AllowUserToAddRows = False
        Me.dgItemInfo.AllowUserToDeleteRows = False
        Me.dgItemInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgItemInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemInfo.Location = New System.Drawing.Point(649, 431)
        Me.dgItemInfo.Name = "dgItemInfo"
        Me.dgItemInfo.ReadOnly = True
        Me.dgItemInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemInfo.Size = New System.Drawing.Size(423, 86)
        Me.dgItemInfo.TabIndex = 33
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(347, 485)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 43)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(489, 485)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 43)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSearchCust
        '
        Me.txtSearchCust.Location = New System.Drawing.Point(123, 283)
        Me.txtSearchCust.Multiline = True
        Me.txtSearchCust.Name = "txtSearchCust"
        Me.txtSearchCust.Size = New System.Drawing.Size(217, 25)
        Me.txtSearchCust.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(35, 290)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Search Customer"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(646, 399)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Search Item"
        '
        'txtSearchItem
        '
        Me.txtSearchItem.Location = New System.Drawing.Point(711, 396)
        Me.txtSearchItem.Multiline = True
        Me.txtSearchItem.Name = "txtSearchItem"
        Me.txtSearchItem.Size = New System.Drawing.Size(217, 25)
        Me.txtSearchItem.TabIndex = 39
        '
        'frmCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearchItem)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtSearchCust)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgItemInfo)
        Me.Controls.Add(Me.dgCusInfo)
        Me.Controls.Add(Me.gbItemInfo)
        Me.Controls.Add(Me.gbCustomerInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmCash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbCustomerInfo.ResumeLayout(False)
        Me.gbCustomerInfo.PerformLayout()
        CType(Me.idpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemInfo.ResumeLayout(False)
        Me.gbItemInfo.PerformLayout()
        CType(Me.idpicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCusInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgItemInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents idpicture As System.Windows.Forms.PictureBox
    Friend WithEvents dgCusInfo As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents dgItemInfo As System.Windows.Forms.DataGridView
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPath1 As System.Windows.Forms.TextBox
    Friend WithEvents idpicture1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDisPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSearchCust As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSearchItem As System.Windows.Forms.TextBox
End Class
