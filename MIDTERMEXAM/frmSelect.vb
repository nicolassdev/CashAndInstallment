Public Class frmSelect

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM-dd-yyyy   hh:mm:ss")
    End Sub

    Private Sub frmSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btnCustomerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerInfo.Click
        frmAddCustomer.Show()
        Me.Close()

    End Sub

    Private Sub btnInstallment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstallment.Click
        frmInstallment.Show()
        Me.Close()
    End Sub

    Private Sub btnCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCash.Click
        frmCash.Show()
        Me.Close()

    End Sub
 
    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        frmItem.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
