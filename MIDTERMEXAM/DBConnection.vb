Imports System.Data
Imports MySql.Data.MySqlClient

Module DBConnection
    Public newrecord As Boolean
    Public cmd As New MySqlCommand
    Public MyAdapter As New MySqlDataAdapter
    Public dt As New DataTable
    Public num As Integer
    Public MyCommand As New MySqlCommand
    Public MyCon As MySqlConnection = New MySqlConnection("server=localhost;database=midtermprojectdb;uid=root;password=Nicolas051002;")

    Public Sub ExecButton(ByVal query)
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = query
            MyAdapter.SelectCommand = MyCommand
            Dim MyData As MySqlDataReader = MyCommand.ExecuteReader
            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExecInsertButton(ByVal query As String)
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = query
            MyCommand.ExecuteNonQuery()
            MessageBox.Show("Insert Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExecUpdateButton(ByVal query As String)
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = query
            MyCommand.ExecuteNonQuery()
            MessageBox.Show("Update Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExecDeleteButton(ByVal query As String)
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = query
            MyCommand.ExecuteNonQuery()
            MessageBox.Show("Record has been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MyCon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub



    Public Function getMaxNumberCus()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT MAX(ID) AS MAX_NUM FROM customer"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getMaxNumberCus = num '3
    End Function


    Public Function getMaxNumberItem()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT MAX(ITEM_NUM) AS MAX_NUM FROM item"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getMaxNumberItem = num '3
    End Function
End Module
