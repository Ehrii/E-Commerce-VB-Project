Imports MySql.Data.MySqlClient

Public Class frmLowStock
    Private Sub frmLowStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Me.Activate()
        Dim cm As New MySqlCommand
        dgvStock.Rows.Clear()
        cm = New MySqlCommand("Select * from product where stock<=20", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvStock.Rows.Add(dr.Item("Product_Image"), dr.Item("Product_ID").ToString, dr.Item("Item_Code").ToString, dr.Item("Stock").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To dgvStock.Rows.Count - 1
            Dim r As DataGridViewRow = dgvStock.Rows(i)
            r.Height = 70
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
        frmSupplier.pnlform.Controls.Clear()
        frmInventory.TopLevel = False
        frmSupplier.pnlform.Controls.Add(frmInventory)
        frmInventory.Show()
        frmInventory.btnAdd.Text = "Add Stocks"
        frmInventory.btnAdd.Enabled = True
        frmInventory.btnDelete.Enabled = False
        frmInventory.grpEntry.Text = "Stock Entry Options"
        frmInventory.lblMenu.Text = "STOCK ENTRY / VIEW STOCKS"
        frmSupplier.Size = New Size(1365, 739)
        Me.Hide()

    End Sub
End Class