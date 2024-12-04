Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class frmAddCustomer
    Public maxNumber As Integer
    Private idnum As String
    Private EmailValid As Boolean
    Sub getCusID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim customerID As String
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxNumber = Convert.ToInt32(getMaxNumberCus()) '3
        idnum = maxNumber + 1 '1 + 1 idnum=4
        customerID = "CUS-" & Year & "-" & idnum 'CSI-2023-4
        txtID.Text = customerID
    End Sub
    Sub lockinfo()
        gbCustomerInfo.Enabled = False
    End Sub
    Sub unlockinfo()
        gbCustomerInfo.Enabled = True
    End Sub
    Sub clearText()
        txtID.Enabled = True
        txtID.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtPath.Text = ""
        Lbl.Text = ""
        btnSave.Text = "Save"
        clearError()
        idpicture.ImageLocation = "C:\Users\carre\OneDrive\Pictures\defualt.jpg"
    End Sub
    Sub clearError()
        ErrorProvider1.Clear()
        ErrorProvider2.Clear()
        ErrorProvider3.Clear()
        ErrorProvider4.Clear()
        ErrorProvider5.Clear()
        ErrorProvider6.Clear()
    End Sub
    Sub lockOtherButton()
        btnSave.Enabled = False
        btnUpload.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Sub unlockOthehrButton()
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnBack.Enabled = True
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
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Jpeg|*.JPG|Bitmap|*.BMP|Gif|*.GIF"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        idpicture.ImageLocation = OpenFileDialog1.FileName
        txtPath.Text = (Replace(OpenFileDialog1.FileName, "\", ";"))
    End Sub

    Private Sub frmAddCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lockinfo()
        lockOtherButton()
        loadgridCustInfo()
        Me.dgCusInfo.Columns(7).Visible = False

    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        btnAdd.Enabled = False
        btnBack.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnUpload.Enabled = True
        unlockinfo()
        btnSave.Text = "Update Customer"
        btnCancel.Text = "Cancel"
        Try

            idnum = InputBox("Enter ID Number:", "Edit")
            If (idnum = "") Then
                MsgBox("Enter ID Number.", MsgBoxStyle.Exclamation, "Error")
                lockinfo()
                lockOtherButton()
                unlockOthehrButton()
                btnSave.Text = "Save"
                btnCancel.Text = "Clear"
                clearText()
                Exit Sub
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM customer WHERE UID='" & idnum & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If (MySQLData.HasRows = 0) Then
                    MsgBox("ID Number not found.", MsgBoxStyle.Critical, "Error")
                    MyCon.Close()
                    lockinfo()
                    lockOtherButton()
                    unlockOthehrButton()
                    btnSave.Text = "Save"
                    btnCancel.Text = "Clear"
                    clearText()
                    Exit Sub

                Else
                    txtID.Enabled = False
                    MySQLData.Read()
                    txtID.Text = MySQLData("UID")
                    txtFname.Text = MySQLData("FNAME")
                    txtMname.Text = MySQLData("MNAME")
                    txtLname.Text = MySQLData("LNAME")
                    txtAddress.Text = MySQLData("ADDRESS")
                    txtEmail.Text = MySQLData("EMAIL")
                    txtPhone.Text = MySQLData("CP")
                    idpicture.ImageLocation = Replace((MySQLData("PICTURE")), ";", "\")
                    txtPath.Text = Replace((MySQLData("PICTURE")), ";", "\")

                    MySQLData.Close()
                    MyCon.Close()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        'ERROR PROVIDER


        If txtFname.Text = "" Then

            If String.IsNullOrEmpty(txtFname.Text.Trim) Then
                ErrorProvider1.SetError(txtFname, "Please enter first name")
                txtFname.Focus()
            End If
            Lbl.Text = "First name are required!"
            Exit Sub
        End If

        If txtMname.Text = "" Then
            If String.IsNullOrEmpty(txtMname.Text.Trim) Then
                ErrorProvider2.SetError(txtMname, "Please enter middle name")
                txtMname.Focus()
            End If
            Lbl.Text = "Middle name are required!"
            Exit Sub
        End If

        If txtLname.Text = "" Then
            If String.IsNullOrEmpty(txtLname.Text.Trim) Then
                ErrorProvider3.SetError(txtLname, "Please enter last name")
                txtLname.Focus()
            End If
            Lbl.Text = "Last name are required!"
            Exit Sub
        End If
        If txtAddress.Text = "" Then
            If String.IsNullOrEmpty(txtAddress.Text.Trim) Then
                ErrorProvider4.SetError(txtAddress, "Please your full address")
                txtAddress.Focus()
            End If
            Lbl.Text = "Address are required!"
            Exit Sub
        End If
        If txtEmail.Text = "" Then
            If String.IsNullOrEmpty(txtEmail.Text.Trim) Then
                ErrorProvider5.SetError(txtEmail, "Please enter email ")
                txtEmail.Focus()
            End If
            Lbl.Text = "Email Address are required!"
            Exit Sub
        End If

        If txtPhone.Text = "" Then
            If String.IsNullOrEmpty(txtPhone.Text.Trim) Then
                ErrorProvider6.SetError(txtPhone, "Please enter cp number")
                txtPhone.Focus()
            End If
            Lbl.Text = "Phone number are required!"
            Exit Sub
        End If

        If txtPath.Text = "" Then
            txtPath.Focus()
            Lbl.Text = "Image are required!"
            Exit Sub
        End If


        If btnSave.Text = "Update Customer" Then
            Dim queryUpdate As String = "UPDATE customer SET FNAME = '" & txtFname.Text & "', MNAME = '" & txtMname.Text & "', LNAME = '" & txtLname.Text & "', ADDRESS = '" & txtAddress.Text & "', EMAIL = '" & txtEmail.Text & "', CP = '" & txtPhone.Text & "', PICTURE = '" & txtPath.Text & "' WHERE UID = '" & txtID.Text & "'; "
            ExecUpdateButton(queryUpdate)
            clearText()
            lockinfo()
            lockOtherButton()
            unlockOthehrButton()
            loadgridCustInfo()
        Else
            Dim queryInsert As String = "INSERT INTO customer(UID,FNAME, MNAME, LNAME, ADDRESS, EMAIL, CP, PICTURE) VALUES('" & txtID.Text & "','" & txtFname.Text & "','" & txtMname.Text & "','" & txtLname.Text & "','" & txtAddress.Text & "','" & txtEmail.Text & "','" & txtPhone.Text & "','" & txtPath.Text & "');"
            ExecInsertButton(queryInsert)
            clearText()
            unlockinfo()
            clearError()
            lockinfo()
            lockOtherButton()
            unlockOthehrButton()
            loadgridCustInfo()
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        clearText()
        If btnCancel.Text = "Cancel" Then
            lockinfo()
            btnSave.Enabled = False
            btnUpload.Enabled = False
            btnDelete.Enabled = False
            btnCancel.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = True
        End If
        btnBack.Enabled = True
        btnCancel.Text = "Clear"
    End Sub

    Private Sub txtFname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtMname.Focus()
            Exit Sub
        End If
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only!")
        End If
    End Sub

    Private Sub txtMname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtLname.Focus()
            Exit Sub
        End If
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only!")
        End If
    End Sub

    Private Sub txtLname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtAddress.Focus()
            Exit Sub
        End If
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept letters only!")
        End If
    End Sub

    Private Sub txtAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtEmail.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPhone.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field will accept numbers only!!")
        End If
        If txtPhone.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Contact number should not be more than 11 numbers!")
            End If
        End If

    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        txtPath.Text = (Replace(txtPath.Text, "\", ";"))
    End Sub

    Private Sub btnAddone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnUpload.Enabled = True
        unlockinfo()
        getCusID()
        txtID.Enabled = False
        btnAdd.Enabled = False
        btnBack.Enabled = False
        btnEdit.Enabled = False
        btnCancel.Enabled = True
        btnCancel.Text = "Cancel"
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmSelect.Show()
        Me.Close()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim idcustomer As String = txtID.Text
        If btnDelete.Text = "Delete" Then
            DialogResult = MessageBox.Show("Are you sure you want to delete CUSTOMER ID" + " " + idcustomer + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If DialogResult = DialogResult.OK Then
                Dim delCus As String = "DELETE FROM customer WHERE UID = '" & idcustomer & "' "
                ExecDeleteButton(delCus)
                clearText()
                lockinfo()
                btnSave.Enabled = False
                btnUpload.Enabled = False
                btnDelete.Enabled = False
                btnCancel.Enabled = False
                btnAdd.Enabled = True
                btnEdit.Enabled = True
                btnBack.Enabled = True
                loadgridCustInfo()
            End If
        End If

    End Sub
       
    Private Sub dgCusInfo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCusInfo.DoubleClick
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

    Private Sub ValidateEmail()

        'Set Up Reg Exp Pattern To Allow Most Characters, And No Special Characters
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})",
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtEmail.Text)

        If blnPossibleMatch Then

            'Check If Entered Email Is In Correct Format
            If Not txtEmail.Text.Equals(reEmail.Match(txtEmail.Text).ToString) Then

                MessageBox.Show("Invalid Email Address!")

            Else

                EmailValid = True

            End If

        Else 'Not A Match To Pattern

            EmailValid = False 'Set Boolean Variable To False

            MessageBox.Show("Invalid Email Address!")

            txtEmail.Clear() 'Clear Textbox

            txtEmail.Focus() 'Set Focus To TextBox

        End If

    End Sub

    Private Sub txtEmail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.Leave
        ValidateEmail()
    End Sub

    Private Sub txtLname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLname.TextChanged

    End Sub

    
End Class