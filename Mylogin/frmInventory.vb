Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports MySql.Data.MySqlClient

Public Class frmInventory



    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            DgvInventory.Rows.Add(dr.Item("Product_Image"), dr.Item("Inventory_ID").ToString, dr.Item("Item_Code"), dr.Item("Product_Name").ToString, dr.Item("Stock").ToString)
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



    Private Sub DgvInventory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvInventory.CellMouseClick
        txtID.Text = DgvInventory.CurrentRow.Cells(1).Value.ToString()
        txtCode.Text = DgvInventory.CurrentRow.Cells(2).Value.ToString()
        txtName.Text = DgvInventory.CurrentRow.Cells(3).Value.ToString()
        txtStockQty.Text = DgvInventory.CurrentRow.Cells(4).Value.ToString()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim stockQty = InputBox("Enter a stock quantity to increase...", "DELAROTA - ADMINISTRATION")
            Dim command As New MySqlCommand("Update product set Stock=@stk where Inventory_ID=@InvID", conn)
            With command
                .Parameters.Clear()
                .Parameters.AddWithValue("@InvID", txtID.Text)
                .Parameters.AddWithValue("@stk", stockQty + Val(txtStockQty.Text))
            End With
            conn.Open()

            Dim command1 As New MySqlCommand("Update inventory set Stock=@stk where Inventory_ID=@InvID", conn)
            With command1
                .Parameters.Clear()
                .Parameters.AddWithValue("@InvID", txtID.Text)
                .Parameters.AddWithValue("@stk", stockQty + Val(txtStockQty.Text))
            End With


            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Stock Qty Inserted..")
                loadrecord()
            Else
                MessageBox.Show("Record not Inserted")
            End If
            conn.Close()

            conn.Open()
            command1.ExecuteNonQuery()
            loadrecord()
            conn.Close()


            Dim command2 As New MySqlCommand("INSERT INTO stockhistory VALUES(@History_ID,@Inventory_ID,@Product_Name,@Stock,
        @Quantity,@Action_Type,@Inventory_Date)", conn)
            With command2
                .Parameters.Clear()
                .Parameters.AddWithValue("@History_ID", 0)
                .Parameters.AddWithValue("@Inventory_ID", txtID.Text)
                .Parameters.AddWithValue("@Product_Name", txtName.Text)
                .Parameters.AddWithValue("@Stock", Val(txtStockQty.Text))
                .Parameters.AddWithValue("@Quantity", stockQty)
                .Parameters.AddWithValue("@Action_Type", "ADDED STOCKS +(" & stockQty & ")")
                .Parameters.AddWithValue("@Inventory_Date", currdatetime)
            End With
            conn.Open()

            If command2.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Stock history record Inserted")
                frmStockHis.loadrecord()
            Else
                MessageBox.Show("Record not Inserted")
            End If
            conn.Close()


        Catch ex As Exception
            MessageBox.Show("NO STOCK INSERTED: " & ex.Message, "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim stockQty = InputBox("Enter a stock quantity to decrease...", "DELAROTA - Administration")
            Dim command As New MySqlCommand("Update product set Stock=@stk where Inventory_ID=@InvID", conn)
            With command
                .Parameters.Clear()
                .Parameters.AddWithValue("@InvID", txtID.Text)
                .Parameters.AddWithValue("@stk", Val(txtStockQty.Text) - stockQty)

            End With
            conn.Open()

            Dim command1 As New MySqlCommand("Update inventory set Stock=@stk where Inventory_ID=@InvID", conn)
            With command1
                .Parameters.Clear()
                .Parameters.AddWithValue("@InvID", txtID.Text)
                .Parameters.AddWithValue("@stk", Val(txtStockQty.Text) - stockQty)

            End With

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Stock Qty Inserted..")
                loadrecord()
            Else
                MessageBox.Show("Record not Inserted")
            End If
            conn.Close()
            conn.Open()
            command1.ExecuteNonQuery()
            conn.Close()

            Dim command2 As New MySqlCommand("INSERT INTO stockhistory VALUES(@History_ID,@Inventory_ID,@Product_Name,@Stock,
        @Quantity,@Action_Type,@Inventory_Date)", conn)
            With command2
                .Parameters.Clear()
                .Parameters.AddWithValue("@History_ID", 0)
                .Parameters.AddWithValue("@Inventory_ID", txtID.Text)
                .Parameters.AddWithValue("@Product_Name", txtName.Text)
                .Parameters.AddWithValue("@Stock", Val(txtStockQty.Text))
                .Parameters.AddWithValue("@Quantity", stockQty)
                .Parameters.AddWithValue("@Action_Type", "REMOVED STOCKS -(" & stockQty & ")")
                .Parameters.AddWithValue("@Inventory_Date", currdatetime)

            End With
            conn.Open()

            If command2.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Stock history record Inserted")
                frmStockHis.loadrecord()
            Else
                MessageBox.Show("Record not Inserted")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("NO STOCK DELETED: " & ex.Message, "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


End Class