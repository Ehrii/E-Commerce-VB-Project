Imports MySql.Data.MySqlClient

Public Class frmViewInv
    Private Sub frmViewInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadrecord()

    End Sub

    Sub loadrecord()

        Dim cm As New MySqlCommand
        DgvInventory.Rows.Clear()
        'conn.Open()'
        cm = New MySqlCommand("Select * from product where Product_Name like '%" & txtSearch.Text & "%'", conn)

        dr = cm.ExecuteReader
        While dr.Read
            DgvInventory.Rows.Add(dr.Item("Inventory_ID").ToString, dr.Item("Product_Image"), dr.Item("Product_ID"), dr.Item("Item_Code").ToString, dr.Item("Product_Name").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvInventory.Rows.Count - 1
            Dim r As DataGridViewRow = DgvInventory.Rows(i)
            r.Height = 60
        Next

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        conn.Open()
        loadrecord()
    End Sub
End Class