Imports System.Drawing.Printing
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmHistory
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrecord()
    End Sub

    Sub loadrecord()
        conn.Close()

        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID', Date_Received as 'Date Received' from orderdetails where Customer_ID='" & customID & "'", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        DgvHistory.RowTemplate.Height = 70
        da.Fill(table)
        DgvHistory.DataSource = table
        conn.Close()

    End Sub

    Private Sub cmbCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCateg.SelectedIndexChanged
        connect()
        Dim cm As New MySqlCommand
        If cmbCateg.Text = "All" Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID', Date_Received as 'Date Received' from orderdetails where Customer_ID='" & customID & "'", conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvHistory.DataSource = table
            conn.Close()
        Else
            Dim table As New DataTable()
            Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID', Date_Received as 'Date Received' from orderdetails where Status ='" & cmbCateg.Text & "'", conn)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvHistory.DataSource = table
            conn.Close()
        End If

        'dr = cm.ExecuteReader
        ' loadrecord()
        conn.Close()


    End Sub

    Private Sub DgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHistory.CellContentClick

        Dim colName As String = DgvHistory.Columns(e.ColumnIndex).Name
        If colName = "Cancel" Then
            Dim choice = MessageBox.Show("Are you sure to cancel this order?", "DELAROTA PRODUCT INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If choice = DialogResult.Yes Then
                Dim cm As New MySqlCommand
                cm = New MySqlCommand("DELETE FROM orderdetails WHERE Order_ID ='" & DgvHistory.CurrentRow.Cells(2).Value & "'", conn)
                conn.Open()
                If cm.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Order Canceled")
                    loadrecord()
                Else
                    MessageBox.Show("Error")
                End If

            Else
                Exit Sub
            End If

        ElseIf colName = "Print" Then
            frmPrint.loadprint()
            frmPrint.Show()
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID', Date_Received as 'Date Received' from orderdetails  where Order_Date between @d1 and @d2", conn)

        command.Parameters.Add("@d1", MySqlDbType.Date).Value = dtp1.Value
        command.Parameters.Add("@d2", MySqlDbType.Date).Value = dtp2.Value
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvHistory.DataSource = table
        conn.Close()


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails WHERE DATE(Order_Date) = DATE(@currdate)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.Date).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvHistory.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND WEEK(@currdate) = WEEK(Order_Date)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.Date).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvHistory.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND MONTH(Order_Date) = MONTH(@currdate)", conn)
        command.Parameters.Add("@currdate", MySqlDbType.Date).Value = currdate
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvHistory.DataSource = table
        conn.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) ='" & DateAndTime.Year(currdate) & "'", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvHistory.DataSource = table
        conn.Close()
    End Sub

End Class