Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Web
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports DevComponents.DotNetBar
Imports Guna.Charts.WinForms
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class frmOrderHis
    Dim orderID As Integer
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID', Date_Received as 'Date Received' from orderdetails  where Order_Date between @d1 and @d2", conn)

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
        dtpOrder.Value = Date.Today
        connect()
        loadrecord()
        disable()

        If cmbOrderStat.Text = "Shipped" Then
            btnDeliv.Enabled = True
        Else
            btnDeliv.Enabled = False
        End If



    End Sub

    Sub loadrecord()
        cmbCustomer.Items.Clear()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails where order_id like '%" & txtSearch.Text & "%'", conn)

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.RowTemplate.Height = 70
        DgvOrders.DataSource = table
        conn.Close()

        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from customer"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            Dim reg = reader.GetString("Customer_ID")
            cmbCustomer.Items.Add(reg)
        End While
        conn.Close()

        Dim loadquery
        cmd = New MySqlCommand
        cmd.Connection = conn
        loadquery = "select * from orderdetails"
        Dim da1 = New MySqlDataAdapter(loadquery, conn)
        Dim dt = New DataTable()
        da.Fill(dt)

    End Sub

    Private Sub DgvOrders_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvOrders.CellMouseClick

        txtID.Text = DgvOrders.CurrentRow.Cells(0).Value.ToString
        dtpOrder.Text = DgvOrders.CurrentRow.Cells(1).Value.ToString
        txtAmt.Text = DgvOrders.CurrentRow.Cells(2).Value.ToString
        txtQuantity.Text = DgvOrders.CurrentRow.Cells(3).Value.ToString
        cmbOrderStat.Text = DgvOrders.CurrentRow.Cells(4).Value.ToString
        cmbCustomer.Text = DgvOrders.CurrentRow.Cells(5).Value.ToString

        If DgvOrders.CurrentRow.Cells(4).Value = "Pending" Then
            Guna2CircleProgressBar1.Value = 10
            Guna2CircleProgressBar1.ProgressColor = Color.Yellow
            Guna2CircleProgressBar1.ProgressColor2 = Color.Gold
        ElseIf DgvOrders.CurrentRow.Cells(4).Value = "Shipped" Then
            Guna2CircleProgressBar1.Value = 50
            Guna2CircleProgressBar1.ProgressColor = Color.Yellow
            Guna2CircleProgressBar1.ProgressColor2 = Color.Gold
        ElseIf DgvOrders.CurrentRow.Cells(4).Value = "Canceled" Then
            Guna2CircleProgressBar1.Value = 0
            Guna2CircleProgressBar1.ProgressColor = Color.IndianRed
            Guna2CircleProgressBar1.ProgressColor2 = Color.Red
        ElseIf DgvOrders.CurrentRow.Cells(4).Value = "Delivered" Then
            Guna2CircleProgressBar1.Value = 100
            Guna2CircleProgressBar1.ProgressColor = Color.Lime
            Guna2CircleProgressBar1.ProgressColor2 = Color.LightGreen
        ElseIf DgvOrders.CurrentRow.Cells(4).Value = "Returned" Then
            Guna2CircleProgressBar1.Value = 100
            Guna2CircleProgressBar1.ProgressColor = Color.Lime
            Guna2CircleProgressBar1.ProgressColor2 = Color.LightGreen
        ElseIf DgvOrders.CurrentRow.Cells(4).Value = "Pending Order Return" Then
            Guna2CircleProgressBar1.Value = 50
            Guna2CircleProgressBar1.ProgressColor = Color.Lime
            Guna2CircleProgressBar1.ProgressColor2 = Color.LightGreen
        End If

        If cmbOrderStat.Text = "Shipped" Then
            btnDeliv.Enabled = True
        Else
            btnDeliv.Enabled = False
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        loadrecord()
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        conn.Close()

        Dim command As New MySqlCommand("delete from orderdetails where Order_Id =@order_ID", conn)
        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Order_ID", txtID.Text)
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Order Deleted Successfully", "DELAROTA ORDER DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadrecord()
        Else
            MessageBox.Show("Record not Deleted ")
        End If
        conn.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        conn.Close()

        Dim choice = MessageBox.Show("Are you sure to update this order?", "DELAROTA PRODUCT INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        Try
            If choice = DialogResult.Yes Then
                Dim command As New MySqlCommand("Update orderdetails set Order_ID=@OrderID,Order_Date=@OrderDate, Total = @Total, Qty =@Qty, Status=@Status, Customer_ID=@CustomerID where Order_ID=@OrderID", conn)
                With command
                    Dim datetime As Date = dtpOrder.Value
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@OrderID", txtID.Text)
                    .Parameters.AddWithValue("@OrderDate", datetime)
                    .Parameters.AddWithValue("@Total", txtAmt.Text)
                    .Parameters.AddWithValue("@Qty", txtQuantity.Text)
                    .Parameters.AddWithValue("@Status", cmbOrderStat.Text)
                    .Parameters.AddWithValue("@CustomerID", cmbCustomer.Text)
                End With
                conn.Open()

                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Order Details Updated Successfully", "DELAROTA ORDER DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    updatedeliv()
                    loadrecord()

                Else
                    MessageBox.Show("Record not Updated")
                End If
                conn.Close()

            Else
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("UPDATE ORDER ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




    End Sub



    Sub updatedeliv()
        Try
            Dim command1 As New MySqlCommand("Update delivery set Order_Status=@Status where Order_ID=@OrderID ", conn)
            With command1
                .Parameters.Clear()
                .Parameters.AddWithValue("@OrderID", txtID.Text)
                .Parameters.AddWithValue("@Status", cmbOrderStat.Text)
            End With
            If command1.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Delivery Details Updated Successfully", "DELAROTA DELIVERY DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record not Updated")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("UPDATE DELIVERY ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub cmbCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCateg.SelectedIndexChanged
        Dim table As New DataTable()
        Dim cm As New MySqlCommand
        If cmbCateg.Text = "All" Then
            cm = New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails", conn)
        Else
            cm = New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails where Status like '%" & cmbCateg.Text & "%'", conn)
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
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails WHERE DATE(Order_Date) = DATE(@currdate)", conn)
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
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND WEEK(@currdate) = WEEK(Order_Date)", conn)
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
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND MONTH(Order_Date) = MONTH(@currdate)", conn)
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
        Dim command As New MySqlCommand("select order_id as'Order ID', order_date as 'Order Date', total as'Order Amount' , qty as'Order Quantity', status as'Order Status', customer_id as'Customer ID',Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) ='" & DateAndTime.Year(currdate) & "'", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvOrders.DataSource = table
        conn.Close()
    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnDeliv.Click
        frmStatus.loadstatus()
        frmStatus.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        cmbOrderStat.Text = "Shipped"
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        cmbOrderStat.Text = "Pending"
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        cmbOrderStat.Text = "Canceled"
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        enable()
    End Sub
    Sub disable()
        txtAmt.Enabled = False
        txtID.Enabled = False
        txtQuantity.Enabled = False
        cmbCustomer.Enabled = False
        dtpOrder.Enabled = False
    End Sub

    Sub enable()
        txtAmt.Enabled = False
        txtID.Enabled = True
        txtQuantity.Enabled = False
        cmbCustomer.Enabled = True
        dtpOrder.Enabled = True
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        disable()

    End Sub


    Sub dashboard()
        conn.Close()

        Dim totalSales As Decimal
        Dim user_cmd1 As New MySqlCommand
        Dim user_stmt1 As String
        Dim usertotalcount1 As String
        user_stmt1 = "Select sum(sales_profit) from sales_report"
        user_cmd1 = New MySqlCommand(user_stmt1, conn)
        conn.Open()
        usertotalcount1 = user_cmd1.ExecuteScalar()
        totalSales = usertotalcount1

        Dim currentMonth, month
        currentMonth = Today.Month

        If currentMonth = 1 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 2 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 3 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 4 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 5 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 6 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 7 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 8 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 9 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 10 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 11 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
        If currentMonth = 12 Then
            Dim Command3 As New MySqlCommand("UPDATE dashboard set sales_profit=@profit where sales_id='" & currentMonth & "'", conn)
            With Command3
                .Parameters.AddWithValue("@Profit", totalSales)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim sfd As New SaveFileDialog()
        sfd.FileName = "export-pdf"
        sfd.Filter = "PDF File | *.pdf"

        If sfd.ShowDialog() = DialogResult.OK Then
            Using doc As New Document()
                doc.SetPageSize(PageSize.A4.Rotate())
                doc.SetMargins(30, 30, 30, 30)
                PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                doc.Open()

                ' Create a table with column headers and data rows
                Dim table As New PdfPTable(DgvOrders.ColumnCount)
                For Each column As DataGridViewColumn In DgvOrders.Columns
                    table.AddCell(column.HeaderText)
                Next
                table.HeaderRows = 1

                For Each row As DataGridViewRow In DgvOrders.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing Then
                            Dim cellValue As String = cell.Value.ToString()
                            Dim dateTimeValue As DateTime
                            If DateTime.TryParse(cellValue, dateTimeValue) Then
                                table.AddCell(dateTimeValue.ToString("dd/MM/yyyy HH:mm:ss"))
                            Else
                                table.AddCell(cellValue)
                            End If
                        Else
                            table.AddCell("")
                        End If
                    Next
                Next

                ' Add the table to the PDF document
                doc.Add(table)

                ' Close the document
                doc.Close()

                ' Open the exported file
                Process.Start(sfd.FileName)
            End Using
        End If

    End Sub
End Class