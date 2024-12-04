<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItem
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPath1 = New System.Windows.Forms.TextBox()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.idpicture1 = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnSaveItem = New System.Windows.Forms.Button()
        Me.gridviewinfo = New System.Windows.Forms.DataGridView()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.gbItem.SuspendLayout()
        CType(Me.idpicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridviewinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(983, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtItemID
        '
        Me.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemID.Location = New System.Drawing.Point(103, 47)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(163, 22)
        Me.txtItemID.TabIndex = 0
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(103, 99)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(163, 22)
        Me.txtItemName.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(103, 145)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(163, 22)
        Me.txtPrice.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Name"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(104, 193)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(162, 57)
        Me.txtDesc.TabIndex = 3
        Me.txtDesc.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Item Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Description"
        '
        'txtPath1
        '
        Me.txtPath1.Location = New System.Drawing.Point(14, 416)
        Me.txtPath1.Name = "txtPath1"
        Me.txtPath1.Size = New System.Drawing.Size(396, 20)
        Me.txtPath1.TabIndex = 9
        Me.txtPath1.Visible = False
        '
        'gbItem
        '
        Me.gbItem.Controls.Add(Me.Lbl)
        Me.gbItem.Controls.Add(Me.Label4)
        Me.gbItem.Controls.Add(Me.Label3)
        Me.gbItem.Controls.Add(Me.txtDesc)
        Me.gbItem.Controls.Add(Me.Label2)
        Me.gbItem.Controls.Add(Me.Label1)
        Me.gbItem.Controls.Add(Me.txtPrice)
        Me.gbItem.Controls.Add(Me.txtItemName)
        Me.gbItem.Controls.Add(Me.txtItemID)
        Me.gbItem.Location = New System.Drawing.Point(14, 85)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(306, 305)
        Me.gbItem.TabIndex = 10
        Me.gbItem.TabStop = False
        Me.gbItem.Text = "Add / Update Item"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.ForeColor = System.Drawing.Color.Red
        Me.Lbl.Location = New System.Drawing.Point(108, 15)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(152, 18)
        Me.Lbl.TabIndex = 23
        Me.Lbl.Text = "                                    "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'idpicture1
        '
        Me.idpicture1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.idpicture1.Location = New System.Drawing.Point(332, 100)
        Me.idpicture1.Name = "idpicture1"
        Me.idpicture1.Size = New System.Drawing.Size(175, 172)
        Me.idpicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.idpicture1.TabIndex = 11
        Me.idpicture1.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(355, 281)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(123, 46)
        Me.btnUpload.TabIndex = 16
        Me.btnUpload.Text = "Upload Item"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(667, 281)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(123, 46)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddItem
        '
        Me.btnAddItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(524, 281)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(123, 46)
        Me.btnAddItem.TabIndex = 22
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
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
        'btnSaveItem
        '
        Me.btnSaveItem.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSaveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveItem.Location = New System.Drawing.Point(809, 282)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Size = New System.Drawing.Size(123, 45)
        Me.btnSaveItem.TabIndex = 23
        Me.btnSaveItem.Text = "Save"
        Me.btnSaveItem.UseVisualStyleBackColor = True
        '
        'gridviewinfo
        '
        Me.gridviewinfo.AllowUserToAddRows = False
        Me.gridviewinfo.AllowUserToDeleteRows = False
        Me.gridviewinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridviewinfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridviewinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridviewinfo.Location = New System.Drawing.Point(524, 100)
        Me.gridviewinfo.Name = "gridviewinfo"
        Me.gridviewinfo.ReadOnly = True
        Me.gridviewinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridviewinfo.Size = New System.Drawing.Size(516, 135)
        Me.gridviewinfo.TabIndex = 18
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(348, 29)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(391, 42)
        Me.lbl1.TabIndex = 24
        Me.lbl1.Text = "ITEM INFORMATION"
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnSaveItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.gridviewinfo)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.idpicture1)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.txtPath1)
        Me.Controls.Add(Me.Button1)
        Me.MinimizeBox = False
        Me.Name = "frmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        CType(Me.idpicture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridviewinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPath1 As System.Windows.Forms.TextBox
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents idpicture1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSaveItem As System.Windows.Forms.Button
    Friend WithEvents gridviewinfo As System.Windows.Forms.DataGridView
    Friend WithEvents lbl1 As System.Windows.Forms.Label
End Class
