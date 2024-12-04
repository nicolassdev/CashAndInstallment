<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelect))
        Me.btnCustomerInfo = New System.Windows.Forms.Button()
        Me.btnInstallment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCustomerInfo
        '
        Me.btnCustomerInfo.BackColor = System.Drawing.SystemColors.WindowText
        Me.btnCustomerInfo.FlatAppearance.BorderSize = 0
        Me.btnCustomerInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomerInfo.Location = New System.Drawing.Point(183, 254)
        Me.btnCustomerInfo.Name = "btnCustomerInfo"
        Me.btnCustomerInfo.Size = New System.Drawing.Size(156, 59)
        Me.btnCustomerInfo.TabIndex = 0
        Me.btnCustomerInfo.Text = "Customer"
        Me.btnCustomerInfo.UseVisualStyleBackColor = False
        '
        'btnInstallment
        '
        Me.btnInstallment.BackColor = System.Drawing.SystemColors.WindowText
        Me.btnInstallment.FlatAppearance.BorderSize = 0
        Me.btnInstallment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnInstallment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstallment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstallment.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInstallment.Location = New System.Drawing.Point(417, 254)
        Me.btnInstallment.Name = "btnInstallment"
        Me.btnInstallment.Size = New System.Drawing.Size(155, 59)
        Me.btnInstallment.TabIndex = 1
        Me.btnInstallment.Text = "Installment Basis"
        Me.btnInstallment.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date Time"
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.SystemColors.WindowText
        Me.btnCash.FlatAppearance.BorderSize = 0
        Me.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCash.Location = New System.Drawing.Point(417, 340)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(155, 59)
        Me.btnCash.TabIndex = 3
        Me.btnCash.Text = "Cash Basis"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(461, 46)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "XYZ Appliance Center"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.SystemColors.WindowText
        Me.btnAddItem.FlatAppearance.BorderSize = 0
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddItem.Location = New System.Drawing.Point(183, 340)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(155, 59)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(654, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(718, 483)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInstallment)
        Me.Controls.Add(Me.btnCustomerInfo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCustomerInfo As System.Windows.Forms.Button
    Friend WithEvents btnInstallment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
