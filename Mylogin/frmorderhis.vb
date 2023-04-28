Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient

Public Class frmOrderHis
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails  where Order_Date between @d1 and @d2", conn)

        command.Parameters.Add("@d1", MySqlDbType.DateTime).Value = dtp1.Value
        command.Parameters.Add("@d2", MySqlDbType.DateTime).Value = dtp2.Value
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.DataSource = table
        conn.Close()
    End Sub

    Private Sub frmOrderHis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadrecord()

    End Sub

    Sub loadrecord()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails where order_id like '%" & txtSearch.Text & "%'", conn)

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.RowTemplate.Height = 70
        DgvOrders.DataSource = table
        conn.Close()


        'Dim cm As New MySqlCommand
        'DgvOrders.Rows.Clear()
        'cm = New MySqlCommand("Select * from orderdetails where Customer_ID like '%" & txtSearch.Text & "%'", conn)
        'dr = cm.ExecuteReader
        'While dr.Read
        '    DgvOrders.Rows.Add(dr.Item("Order_ID").ToString, dr.Item("Order_Date"), dr.Item("Total").ToString, dr.Item("Qty").ToString, dr.Item("Status").ToString, dr.Item("Customer_ID"))
        'End While
        'dr.Close()
        'conn.Close()

        'For i = 0 To DgvOrders.Rows.Count - 1
        '    Dim r As DataGridViewRow = DgvOrders.Rows(i)
        '    r.Height = 60
        'Next
    End Sub


    Private Sub DgvOrders_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvOrders.CellMouseClick

        txtID.Text = DgvOrders.CurrentRow.Cells(0).Value.ToString()
        txtDate.Text = DgvOrders.CurrentRow.Cells(1).Value.ToString()
        txtAmt.Text = DgvOrders.CurrentRow.Cells(2).Value.ToString()
        txtQuantity.Text = DgvOrders.CurrentRow.Cells(3).Value.ToString()
        cmbOrderStat.Text = DgvOrders.CurrentRow.Cells(4).Value.ToString()
        txtCustomer.Text = DgvOrders.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadrecord()

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim command As New MySqlCommand("INSERT INTO orderdetails VALUES(@Order_ID,@Order_Date,@Total,@Qty,@Status,@Customer_ID)", conn)
        Dim datetime As Date = txtDate.Text
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Order_ID", 0)
            .Parameters.AddWithValue("@Order_Date", datetime)
            .Parameters.AddWithValue("@Total", txtAmt.Text)
            .Parameters.AddWithValue("@Qty", txtQuantity.Text)
            .Parameters.AddWithValue("@Status", cmbOrderStat.Text)
            .Parameters.AddWithValue("@Customer_ID", txtCustomer.Text)
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Inserted")
            loadrecord()

        Else
            MessageBox.Show("Record not Inserted")
        End If
        conn.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim command As New MySqlCommand("delete from orderdetails where Order_Id =@order_ID", conn)
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Order_ID", txtID.Text)
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Deleted")
            loadrecord()

        Else
            MessageBox.Show("Record not Deleted ")
        End If
        conn.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim command As New MySqlCommand("Update orderdetails set Order_ID=@OrderID,Order_Date=@OrderDate, Total = @Total, Qty =@Qty, Status=@Status, Customer_ID=@CustomerID where Order_ID=@OrderID", conn)
        With command
            Dim datetime As Date = txtDate.Text
            .Parameters.Clear()
            .Parameters.AddWithValue("@OrderID", txtID.Text)
            .Parameters.AddWithValue("@OrderDate", datetime)
            .Parameters.AddWithValue("@Total", txtAmt.Text)
            .Parameters.AddWithValue("@Qty", txtQuantity.Text)
            .Parameters.AddWithValue("@Status", cmbOrderStat.Text)
            .Parameters.AddWithValue("@CustomerID", txtCustomer.Text)
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Updated..")
            loadrecord()
        Else
            MessageBox.Show("Record not Updated")
        End If
        conn.Close()

    End Sub

    Private Sub cmbCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCateg.SelectedIndexChanged
        Dim table As New DataTable()
        Dim cm As New MySqlCommand
        If cmbCateg.Text = "All" Then
            cm = New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails", conn)
        Else
            cm = New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails where Status like '%" & cmbCateg.Text & "%'", conn)
        End If

        Dim da As New MySqlDataAdapter
        da.SelectCommand = cm
        table.Clear()
        da.Fill(table)
        DgvOrders.RowTemplate.Height = 70
        DgvOrders.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails WHERE DATE(Order_Date) = DATE(@currdate)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND WEEK(@currdate) = WEEK(Order_Date)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND MONTH(Order_Date) = MONTH(@currdate)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID' from orderdetails  WHERE YEAR(Order_Date) ='" & DateAndTime.Year(currdate) & "'", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.DataSource = table
        conn.Close()
    End Sub

    Private Sub DgvOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOrders.CellContentClick

    End Sub
End Class