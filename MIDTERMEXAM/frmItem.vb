Imports MySql.Data.MySqlClient
Public Class frmItem
    Public maxNumber As Integer
    Private idnum As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSelect.Show()
        Me.Close()
    End Sub

    Sub getItemID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim itemID As String
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxNumber = Convert.ToInt32(getMaxNumberItem()) '3
        idnum = maxNumber + 1 '1 + 1 idnum=4
        itemID = "ITEM-" & idnum & "-" & Year 'ITEM-1-2023
        txtItemID.Text = itemID
    End Sub

    Sub loadgrid()

        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable

            With MyCommand
                .Connection = MyCon
                .CommandText = "Select ITEM_ID as 'ITEM ID',ITEM_NAME as 'ITEM NAME', ITEM_PRICE as 'ITEM_PRICE', ITEM_DESCRIPTION as 'ITEM DESCRIPTION', ITEM_PIC FROM item  "
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            gridviewinfo.DataSource = dt

            MyCon.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub locktxt()
        gbItem.Enabled = False
    End Sub
    Sub lockButtons()
        btnUpload.Enabled = False
        btnSaveItem.Enabled = False
    End Sub
    Sub cleartxt()
        txtItemID.Text = ""
        txtItemName.Text = ""
        txtPrice.Text = ""
        txtDesc.Text = ""
        txtPath1.Text = Nothing
        Lbl.Text = ""
        idpicture1.ImageLocation = "C:\Users\carre\OneDrive\Pictures\photoicon.jpg"
    End Sub
    Sub clearError()
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()
        ErrorProvider3.Clear()
    End Sub


    Private Sub frmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idpicture1.ImageLocation = "C:\Users\carre\OneDrive\Pictures\photoicon.jpg"
        gbItem.Enabled = False
        btnUpload.Enabled = False
        btnSaveItem.Enabled = False
        btnEdit.Enabled = True
        loadgrid()
        Me.gridviewinfo.Columns(4).Visible = False


    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        btnAddItem.Enabled = False
        btnEdit.Enabled = False
        txtItemID.Enabled = False
        gbItem.Enabled = True
        btnUpload.Enabled = True
        btnSaveItem.Enabled = True
        btnSaveItem.Text = "Save Item"
        getItemID()


    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click

        Dim img = OpenFileDialog1.ShowDialog
        DialogResult = img
        If DialogResult = DialogResult.OK Then
            OpenFileDialog1.Filter = "Jpeg|*.JPG|Bitmap|*.BMP|Gif|*.GIF"
            OpenFileDialog1.RestoreDirectory = True
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName = "" Then Exit Sub
            idpicture1.ImageLocation = OpenFileDialog1.FileName
            txtPath1.Text = (Replace(OpenFileDialog1.FileName, "\", ";"))

        End If
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath1.TextChanged
        txtPath1.Text = (Replace(txtPath1.Text, "\", ";"))
    End Sub


    Private Sub btnSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveItem.Click
        If txtItemName.Text = "" Then
            If String.IsNullOrEmpty(txtItemName.Text.Trim) Then
                ErrorProvider1.SetError(txtItemName, "Please enter item name")
                txtItemName.Focus()
            End If
            Lbl.Text = "Item are required!"
            Exit Sub
        End If

        If txtPrice.Text = "" Then
            If String.IsNullOrEmpty(txtPrice.Text.Trim) Then
                ErrorProvider2.SetError(txtPrice, "Please enter price name")
                txtPrice.Focus()
            End If
            Lbl.Text = "Item price are required!"
            Exit Sub
        End If

        If txtDesc.Text = "" Then
            If String.IsNullOrEmpty(txtDesc.Text.Trim) Then
                ErrorProvider3.SetError(txtDesc, "Please enter description name")
                txtDesc.Focus()
            End If
            Lbl.Text = "Item description are required!"
            Exit Sub
        End If
        If txtPath1.Text = "" Then
            txtPath1.Focus()
            Lbl.Text = "Image are required!"
            Exit Sub
        End If

        If btnSaveItem.Text = "Save Item" Then
            Dim queryInsert As String = "INSERT INTO item(ITEM_ID,ITEM_NAME,ITEM_PRICE,ITEM_DESCRIPTION,ITEM_PIC) VALUES('" & txtItemID.Text & "','" & txtItemName.Text & "','" & txtPrice.Text & "','" & txtDesc.Text & "','" & txtPath1.Text & "');"
            ExecInsertButton(queryInsert)
            cleartxt()
            clearError()
            btnAddItem.Enabled = True
            btnEdit.Enabled = True
            btnSaveItem.Text = "Save"
            lockButtons()
            locktxt()
            loadgrid()
        Else
            Dim queryUpdateItem As String = "UPDATE item SET ITEM_NAME = '" & txtItemName.Text & "', ITEM_PRICE = '" & txtPrice.Text & "', ITEM_DESCRIPTION = '" & txtDesc.Text & "', ITEM_PIC = '" & txtPath1.Text & "' WHERE ITEM_ID = '" & txtItemID.Text & "';"
            ExecUpdateButton(queryUpdateItem)
            cleartxt()
            clearError()
            loadgrid()
            btnSaveItem.Text = "Save"
            btnAddItem.Enabled = True
            btnEdit.Enabled = True
            lockButtons()
            locktxt()
        End If


    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtItemID.Text = "" Then
            MsgBox("Select item to edit!", MsgBoxStyle.Critical, "Select")
            gbItem.Enabled = False
            btnUpload.Enabled = False
            btnSaveItem.Enabled = False
        Else
            btnSaveItem.Text = "Update Item"
            btnSaveItem.Enabled = True
            btnEdit.Enabled = False
            btnAddItem.Enabled = False
            btnUpload.Enabled = True
            gbItem.Enabled = True
            txtItemID.Enabled = False
            gridviewinfo.Enabled = False

        End If
    End Sub

    Private Sub gridviewinfo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridviewinfo.MouseClick
        btnEdit.Enabled = True
        btnAddItem.Enabled = False
        On Error Resume Next
        Dim i As Integer
        i = gridviewinfo.CurrentRow.Index
        Me.txtItemID.Text = gridviewinfo.Item(0, i).Value
        Me.txtItemName.Text = gridviewinfo.Item(1, i).Value
        Me.txtPrice.Text = gridviewinfo.Item(2, i).Value
        Me.txtDesc.Text = gridviewinfo.Item(3, i).Value
        Me.txtPath1.Text = gridviewinfo.Item(4, i).Value

        idpicture1.ImageLocation = Replace(txtPath1.Text, ";", "/")

    End Sub

End Class