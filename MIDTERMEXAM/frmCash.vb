Public Class frmCash

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmSelect.Show()
        Me.Close()
    End Sub
 
    Sub loadgridItemInfo()

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
            dgItemInfo.DataSource = dt

            MyCon.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub loadgridCustInfo()

        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable

            With MyCommand
                .Connection = MyCon
                .CommandText = "Select UID as 'CUS ID',FNAME as 'FIRST NAME', MNAME as 'MIDDLE NAME', LNAME as 'LAST NAME', ADDRESS as 'ADDRESS',EMAIL as'EMAIL', CP as 'Cellphone', PICTURE FROM customer  "
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            dgCusInfo.DataSource = dt
            MyCon.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmCash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DISABLE ALL FUNCTIONS
        loadgridCustInfo()
        loadgridItemInfo()
        gbCustomerInfo.Enabled = False
        gbItemInfo.Enabled = False


        btnSave.Enabled = False


        Me.dgItemInfo.Columns(4).Visible = False
        Me.dgCusInfo.Columns(7).Visible = False

    End Sub
     
    Private Sub dgCusInfo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgCusInfo.MouseClick
        gbCustomerInfo.Enabled = False
        On Error Resume Next
        Dim i As Integer
        i = dgCusInfo.CurrentRow.Index
        Me.txtID.Text = dgCusInfo.Item(0, i).Value
        Me.txtFname.Text = dgCusInfo.Item(1, i).Value
        Me.txtMname.Text = dgCusInfo.Item(2, i).Value
        Me.txtLname.Text = dgCusInfo.Item(3, i).Value
        Me.txtAddress.Text = dgCusInfo.Item(4, i).Value
        Me.txtEmail.Text = dgCusInfo.Item(5, i).Value
        Me.txtPhone.Text = dgCusInfo.Item(6, i).Value
        Me.txtPath.Text = dgCusInfo.Item(7, i).Value

        idpicture.ImageLocation = Replace(txtPath.Text, ";", "/")
    End Sub

    
    Private Sub dgItemInfo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgItemInfo.DoubleClick

        txtQty.Enabled = True
        On Error Resume Next
        Dim i As Integer
        i = dgItemInfo.CurrentRow.Index
        Me.txtItemID.Text = dgItemInfo.Item(0, i).Value
        Me.txtItemName.Text = dgItemInfo.Item(1, i).Value
        Me.txtPrice.Text = dgItemInfo.Item(2, i).Value
        Me.txtDesc.Text = dgItemInfo.Item(3, i).Value
        Me.txtPath1.Text = dgItemInfo.Item(4, i).Value

        idpicture1.ImageLocation = Replace(txtPath1.Text, ";", "/")

    End Sub
 
    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

        Dim discount As Double
        Dim qty As Single
        Dim price As Single
        Dim dis_price As Single
        Dim total_price As Single
        Dim payment As Single


        'DISCOUNT
        txtDiscount.Text = 30 & "%"

        
        'TOTAL PRICE
        qty = Val(txtQty.Text)
        price = Val(txtPrice.Text)
        total_price = (qty * price)
        txtTotalPrice.Text = total_price.ToString("#,###.00")

        'PAYMENT
        payment = Val(txtPayment.Text)
        payment = total_price - dis_price
        txtPayment.Text = payment.ToString("#,###.00")

        'DISCOUNTED PRICE
        'txtDiscount.Text = (txtPrice.Text * 0.3).ToString
        total_price = Val(txtPrice.Text - (txtPrice.Text * 0.3))
        txtTotalPrice.Text = total_price.ToString("#,###.00")

        Dim datetime As Date = Date.Now
        txtDate.Text = datetime.ToString

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
         
        txtQty.Focus()
        btnAdd.Enabled = False
        gbItemInfo.Enabled = True

        txtItemID.Enabled = False
        txtItemName.Enabled = False
        txtPrice.Enabled = False
        txtDesc.Enabled = False
        txtPayment.Enabled = False
        txtTotalPrice.Enabled = False
        txtDiscount.Enabled = False
        txtDisPrice.Enabled = False
        txtDate.Enabled = False
        txtSearchCust.Enabled = False
        txtSearchItem.Enabled = False

    End Sub

    Private Sub txtSearchCust_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchCust.TextChanged
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            dgCusInfo.Refresh()
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT UID,FNAME, MNAME, LNAME, ADDRESS FROM customer WHERE FNAME LIKE '" & txtSearchCust.Text & "%'"
            MyAdapter.SelectCommand = MyCommand
            dt = New DataTable
            dt.Clear()
            MyAdapter.Fill(dt)
            dgCusInfo.DataSource = dt

            MyCon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearchItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchItem.TextChanged
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            dgItemInfo.Refresh()
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT ITEM_ID,ITEM_NAME,ITEM_DESCRIPTION FROM item WHERE ITEM_NAME LIKE '" & txtSearchItem.Text & "%'"
            MyAdapter.SelectCommand = MyCommand
            dt = New DataTable
            dt.Clear()
            MyAdapter.Fill(dt)
            dgItemInfo.DataSource = dt

            MyCon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only!!")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    End Sub
End Class