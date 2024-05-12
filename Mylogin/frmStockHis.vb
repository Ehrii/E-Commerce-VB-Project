Imports MySql.Data.MySqlClient

Public Class frmStockHis
    Private Sub frmStockHis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadrecord()
    End Sub

    Sub loadrecord()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Inventory_ID as'Inventory ID', Product_Name as 'Product Name', Total_Stocks as'Total Stocks' , Stock_Adjustments as'Stock Adjustments', Action_Type as'Action Type', Inventory_Date as'Inventory Date' from stockhistory ", conn)

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvInventory.RowTemplate.Height = 60
        DgvInventory.DataSource = table
        conn.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Inventory_ID as'Inventory ID', Product_Name as 'Product Name', Total_Stocks as'Total Stocks' , Stock_Adjustments as'Stock Adjustments', Action_Type as'Action Type', Inventory_Date as'Inventory Date' from stockhistory  where Inventory_Date Between @d1 AND @d2", conn)
        ' conn.Open()
        command.Parameters.Add("@d1", MySqlDbType.Date).Value = dtp1.Value
        command.Parameters.Add("@d2", MySqlDbType.Date).Value = dtp2.Value
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvInventory.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Inventory_ID as'Inventory ID', Product_Name as 'Product Name', Total_Stocks as'Total Stocks' , Stock_Adjustments as'Stock Adjustments', Action_Type as'Action Type', Inventory_Date as'Inventory Date' from stockhistory WHERE DATE(Inventory_Date) = DATE(@currdate)", conn)
        ' conn.Open()
        command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvInventory.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Inventory_ID as'Inventory ID', Product_Name as 'Product Name', Total_Stocks as'Total Stocks' , Stock_Adjustments as'Stock Adjustments', Action_Type as'Action Type', Inventory_Date as'Inventory Date' from stockhistory  WHERE YEAR(Inventory_Date) = YEAR(@currdate) AND WEEK(@currdate) = WEEK(Inventory_Date)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvInventory.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Inventory_ID as'Inventory ID', Product_Name as 'Product Name', Total_Stocks as'Total Stocks' , Stock_Adjustments as'Stock Adjustments', Action_Type as'Action Type', Inventory_Date as'Inventory Date' from stockhistory  WHERE YEAR(Inventory_Date) = YEAR(@currdate) AND MONTH(Inventory_Date) = MONTH(@currdate)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvInventory.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Inventory_ID as'Inventory ID', Product_Name as 'Product Name', Total_Stocks as'Total Stocks' , Stock_Adjustments as'Stock Adjustments', Action_Type as'Action Type', Inventory_Date as'Inventory Date' from stockhistory  WHERE YEAR(Inventory_Date) ='" & DateAndTime.Year(currdate) & "'", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvInventory.DataSource = table
        conn.Close()
    End Sub
End Class