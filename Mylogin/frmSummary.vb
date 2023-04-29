Imports System.Diagnostics.Eventing
Imports System.Drawing.Printing
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class frmSummary
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim cm As New MySqlCommand
        dgvSummary.Rows.Clear()
        cm = New MySqlCommand("Select * from cart where Customer_ID ='" & customID & "'", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvSummary.Rows.Add(dr.Item("Product_Image"), dr.Item("Product_ID"), dr.Item("Product_Name"), dr.Item("Quantity").ToString, dr.Item("Amount").ToString)
        End While
        dr.Close()
        conn.Close()
        For i = 0 To dgvSummary.Rows.Count - 1
            Dim r As DataGridViewRow = dgvSummary.Rows(i)
            r.Height = 60
        Next
        Dim imagecolumn = DirectCast(dgvSummary.Columns("Column1"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        lblOrder.Text = orderID

        lblDisc.Text = Val(frmDelivery.lblDiscAmt.Text)
        lblSubtotal.Text = frmCart.txtSub.Text
        lblShipping.Text = frmDelivery.lblShipping.Text
        lblTotal.Text = frmPayment.txtAmtDue.Text
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        For i = 0 To dgvSummary.Rows.Count - 1
            Dim totalQuan As Integer
            Dim totalAmt As Double
            Dim quan As Integer = dgvSummary.Rows(i).Cells(3).Value
            Dim prodId As Integer = dgvSummary.Rows(i).Cells(1).Value
            Dim sum As Integer
            Dim query As String
            Dim reader As MySqlDataReader

            query = "select * from sales_report where product_id='" & prodId & "'"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            conn.Open()
            reader = cm.ExecuteReader
            While reader.Read
                totalQuan = reader("Sales_Volume")
                totalAmt = reader("Sales_Amount")
            End While

            Dim Command As New MySqlCommand("UPDATE sales_report set Sales_Volume=@QtySold,Sales_Amount=@AmtSold where Product_Id=@ProdID", conn)

            totalQuan += dgvSummary.Rows(i).Cells(3).Value
            totalAmt += dgvSummary.Rows(i).Cells(4).Value
            With Command
                .Parameters.AddWithValue("@QtySold", totalQuan)
                .Parameters.AddWithValue("@AmtSold", totalAmt)
                .Parameters.AddWithValue("@ProdID", prodId)
            End With
            conn.Close()
            conn.Open()
            If Command.ExecuteNonQuery() = 1 Then
                MsgBox("Sales report updated")
                frmReceipt.Show()
            Else
                MessageBox.Show("Record Not Inserted")

            End If
            conn.Close()
        Next


        For i = 0 To dgvSummary.Rows.Count - 1
            Dim command2 As New MySqlCommand("INSERT INTO sales_history VALUES (@Sales_ID,@Product_ID,@Product_Name,@Product_Quantity,@Amount,@Sales_Date,@Order_ID)", conn)
            With command2

                .Parameters.Clear()
                .Parameters.AddWithValue("@Sales_ID", 0)
                .Parameters.AddWithValue("@Product_ID", dgvSummary.Rows(i).Cells(1).Value)
                .Parameters.AddWithValue("@Product_Name", dgvSummary.Rows(i).Cells(2).Value)
                .Parameters.AddWithValue("@Product_Quantity", dgvSummary.Rows(i).Cells(3).Value)
                .Parameters.AddWithValue("@Amount", dgvSummary.Rows(i).Cells(4).Value)
                .Parameters.AddWithValue("@Sales_Date", currdatetime)
                .Parameters.AddWithValue("@Order_ID", orderID)
                conn.Open()
            End With
            command2.ExecuteNonQuery()
            conn.Close()
        Next
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ''DELIVERY
        Dim cm As New MySqlCommand
        conn.Close()

        Dim cm1 As New MySqlCommand
        conn.Close()
        cm1 = New MySqlCommand("Update delivery set Order_Status=@Status WHERE Delivery_ID ='" & frmDelivery.delivery & "'", conn)
        With cm1
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", "Canceled")
        End With
        conn.Open()
        If cm1.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Delivery Cancelled")
            frmShop.loadcartcount()
            frmShop.txtCart.Enabled = False

        Else
            MessageBox.Show("Error")
        End If
        Me.Hide()
        ''PAYMENT

        ''CART
        Dim cm2 As New MySqlCommand
        conn.Close()
        cm2 = New MySqlCommand("truncate table cart", conn)
        conn.Open()
        cm2.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("records deleted")
        frmShop.loadcartcount()
        frmCart.loadRecord()
        frmShop.lblPrice.Text = "TOTAL PRICE: " & 0.00

        ''ORDERDETAILS
        Dim cm3 As New MySqlCommand
        conn.Close()
        cm3 = New MySqlCommand("Update orderdetails set Status=@Status WHERE Order_ID ='" & orderID & "'", conn)
        With cm3
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", "Canceled")
        End With
        conn.Open()
        If cm3.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Order Canceled")

        Else
            MessageBox.Show("Error")
        End If
        Me.Hide()


    End Sub
End Class