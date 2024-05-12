Imports System.Diagnostics.Eventing
Imports System.Web
Imports MySql.Data.MySqlClient

Public Class frmStatus
    Dim ordId As Integer = frmOrderHis.DgvOrders.CurrentRow.Cells(0).Value
    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadstatus()
    End Sub


    Sub loadstatus()
        connect()

        btnConfirm.Enabled = False

        Dim cm As New MySqlCommand
        DgvStatus.Rows.Clear()
        cm = New MySqlCommand("Select * from product_history where Order_ID ='" & ordId & "'", conn)

        dr = cm.ExecuteReader
        While dr.Read
            DgvStatus.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Name"), dr.Item("Product_Quantity").ToString, dr.Item("Amount").ToString, dr.Item("Order_Date"), dr.Item("Order_ID"))
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvStatus.Rows.Count - 1
            Dim r As DataGridViewRow = DgvStatus.Rows(i)
            r.Height = 40

        Next
    End Sub



    Private Sub DgvStatus_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvStatus.CellMouseClick
        lblID.Text = DgvStatus.CurrentRow.Cells(0).Value
        txtName.Text = DgvStatus.CurrentRow.Cells(1).Value
        lblQuantity.Text = DgvStatus.CurrentRow.Cells(2).Value
        lblAmount.Text = DgvStatus.CurrentRow.Cells(3).Value
        lblDateOrdered.Text = DgvStatus.CurrentRow.Cells(4).Value
        Dim orderID As Integer = DgvStatus.CurrentRow.Cells(5).Value


        '  Dim dateordered As Date =
        ' Dim address As String = 
        Dim query As String
        Dim reader As MySqlDataReader
        Dim receivingdate, deliveryadd, deliverymethod, deliverystatus
        query = "select * from delivery where Order_Id='" & orderID & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            receivingdate = reader.GetString("Delivery_Date")
            deliveryadd = reader.GetString("Delivery_Location")
            deliverymethod = reader.GetString("Delivery_Type")
            deliverystatus = reader.GetString("Order_Status")
        End While

        conn.Close()

        lblReceiving.Text = receivingdate
        txtAdd.Text = deliveryadd
        lblMethod.Text = deliverymethod
        lblStatus.Text = deliverystatus


        If lblMethod.Text = "Same-Day Shipping (Same Day)" Then
            circleProgBar.Value = 95
        End If


        If lblMethod.Text = "In-Store Pick-up" Then
            circleProgBar.Value = 100
        End If

        'lblDateOrdered

        If lblMethod.Text = "Standard Delivery (5-7 Days)" Then
            Dim dateord As Date = lblDateOrdered.Text
            Dim days As Single = Convert.ToInt32((dateord.AddDays(7) - currdate).TotalDays)

            If days <= 8 Then
                circleProgBar.Value = 10
            ElseIf days <= 6 Then
                circleProgBar.Value = 30
            ElseIf days <= 4 Then
                circleProgBar.Value = 60
            ElseIf days <= 2 Then
                circleProgBar.Value = 80
            ElseIf days <= 1 Then
                circleProgBar.Value = 95
            End If

            If lblStatus.Text = "Shipped" Then
                days = 2
                circleProgBar.Value = 65
                If days <= 2 Then
                    circleProgBar.Value = 84
                ElseIf days <= 1 Then
                    circleProgBar.Value = 95
                End If
            End If
        End If


        If lblMethod.Text = "Express Shipping (1-2 Days)" Then
            Dim dateord As Date = lblDateOrdered.Text
            Dim days As Single = Convert.ToInt32((dateord.AddDays(2) - currdate).TotalDays)

            If days <= 3 Then
                circleProgBar.Value = 30
            ElseIf days <= 2 Then
                circleProgBar.Value = 50
            ElseIf days <= 1 Then
                circleProgBar.Value = 98
            End If

            If lblStatus.Text = "Shipped" Then
                days = 2
                circleProgBar.Value = 55
                If days <= 1 Then
                    circleProgBar.Value = 95
                End If
            End If
        End If



        Dim query2 As String
        Dim reader2 As MySqlDataReader
        Dim orderAmt
        query2 = "select * from orderdetails where Order_Id='" & orderID & "'"
        Dim cm2 As New MySqlCommand
        cm2 = New MySqlCommand(query2, conn)
        conn.Open()
        reader2 = cm2.ExecuteReader
        While reader2.Read
            orderAmt = reader2.GetString("Total")

        End While

        conn.Close()
        lblOrderAmt.Text = orderAmt


        If lblStatus.Text = "Delivered" Then
            circleProgBar.ProgressColor = Color.LightGreen
            circleProgBar.ProgressColor2 = Color.SpringGreen
            progBar.ProgressColor = Color.LightGreen
            progBar.ProgressColor2 = Color.SpringGreen
            circleProgBar.Value = 100
            btnConfirm.Enabled = False
        End If


        If lblStatus.Text = "Canceled" Then
            circleProgBar.Value = 0
            circleProgBar.ProgressColor = Color.IndianRed
            circleProgBar.ProgressColor2 = Color.Red
            progBar.ProgressColor = Color.Red
            progBar.ProgressColor2 = Color.IndianRed
        End If

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        conn.Close()

        Dim expense, profit As Integer
        Dim totalQuan As Integer
        Dim totalAmt As Double
        Dim prodId As Integer
        conn.Open()

        For i = 0 To DgvStatus.Rows.Count - 1
            Dim quan As Integer = DgvStatus.Rows(i).Cells(2).Value
            prodId = DgvStatus.Rows(i).Cells(0).Value
            Dim sum As Integer
            Dim query As String
            Dim reader As MySqlDataReader

            query = "select * from sales_report where product_id='" & prodId & "'"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            conn.Close()
            conn.Open()
            reader = cm.ExecuteReader
            While reader.Read
                totalQuan = reader("Sales_Volume")
                totalAmt = reader("Sales_Amount")
                expense = reader("Sales_Expenses")
            End While
            totalQuan = DgvStatus.Rows(i).Cells(2).Value
            totalAmt += DgvStatus.Rows(i).Cells(3).Value * totalQuan

            If expense >= totalAmt Then
                profit = 0.00
            ElseIf expense < totalAmt Then
                profit = totalAmt - expense
            End If

            Dim Command3 As New MySqlCommand("UPDATE sales_report set Sales_Volume=@QtySold,Sales_Amount=@AmtSold , Sales_Profit = @Profit where Product_Id=@ProdID", conn)
            With Command3
                .Parameters.AddWithValue("@QtySold", totalQuan)
                .Parameters.AddWithValue("@AmtSold", totalAmt)
                .Parameters.AddWithValue("@Profit", profit)
                .Parameters.AddWithValue("@ProdID", prodId)
            End With
            conn.Close()
            conn.Open()
            Command3.ExecuteNonQuery()
            conn.Close()
        Next
        dashboard()
        updatedeliv()
        updateorder()
        MessageBox.Show("Process Complete", "Product Delivered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frmOrderHis.loadrecord()
        Me.Hide()
    End Sub

    Sub dashboard()
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
    Sub updatedeliv()
        Dim command1 As New MySqlCommand("Update delivery set Order_Status = @Status where Order_ID =@OrderID", conn)
        With command1
            .Parameters.Clear()
            .Parameters.AddWithValue("@OrderID", ordId)
            .Parameters.AddWithValue("@Status", "Delivered")
        End With
        conn.Open()
        command1.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub updateorder()
        Dim command1 As New MySqlCommand("Update orderdetails set Status=@Status,Date_Received =@DateReceived where Order_ID =@OrderID", conn)
        With command1
            .Parameters.Clear()
            .Parameters.AddWithValue("@OrderID", ordId) '
            .Parameters.AddWithValue("@DateReceived", currdatetime) 'ADDED
            .Parameters.AddWithValue("@Status", "Delivered")
        End With
        conn.Open()
        command1.ExecuteNonQuery()
        conn.Close()
    End Sub


    Sub deleteprodhistory()
        Dim command1 As New MySqlCommand("delete from product_history where Order_ID=@OrderID", conn)
        With command1
            .Parameters.Clear()
            .Parameters.AddWithValue("@OrderID", ordId)
        End With
        conn.Open()
        MsgBox("Process Complete..")
        command1.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub DgvStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvStatus.CellContentClick
        btnConfirm.Enabled = True

    End Sub
End Class