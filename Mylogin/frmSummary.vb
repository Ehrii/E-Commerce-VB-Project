Imports System.Diagnostics.Eventing
Imports System.Drawing.Printing
Imports System.Net
Imports System.Web
Imports MySql.Data.MySqlClient

Public Class frmSummary
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsummary()
    End Sub

    Sub loadsummary()
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
        conn.Close()
        Try
            frmReceipt.Show()
            Me.Hide()
            For i = 0 To dgvSummary.Rows.Count - 1
                Dim command2 As New MySqlCommand("INSERT INTO product_history VALUES (@History_ID,@Product_ID,@Product_Name,@Product_Quantity,@Amount,@Order_Date,@Order_ID,@Customer_ID,@Payment_ID)", conn)
                With command2
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@History_ID", 0)
                    .Parameters.AddWithValue("@Product_ID", dgvSummary.Rows(i).Cells(1).Value)
                    .Parameters.AddWithValue("@Product_Name", dgvSummary.Rows(i).Cells(2).Value)
                    .Parameters.AddWithValue("@Product_Quantity", dgvSummary.Rows(i).Cells(3).Value)
                    .Parameters.AddWithValue("@Amount", dgvSummary.Rows(i).Cells(4).Value)
                    .Parameters.AddWithValue("@Order_Date", currdatetime)
                    .Parameters.AddWithValue("@Order_ID", orderID)
                    .Parameters.AddWithValue("@Customer_ID", customID)
                    .Parameters.AddWithValue("@Payment_ID", 0)
                    conn.Open()
                End With
                command2.ExecuteNonQuery()
                conn.Close()
            Next
        Catch ex As Exception
            MessageBox.Show("CONFIRM ORDER ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Try

            Dim totalAmt, totalAmt2 As Integer
            conn.Close()
            ''READ DATA
            ''CREDIT INFO REFUND
            Dim query As String
            Dim Reader As MySqlDataReader
            query = "SELECT * from creditinfo where Customer_ID='" & customID & "'AND creditcard_no ='" & lblDetails.Text & "' AND creditcard_type ='" & lblCard.Text & "'"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            conn.Open()
            Reader = cm.ExecuteReader
            While Reader.Read
                totalAmt = Reader("amount")
            End While

            conn.Close()

            Dim query2 As String
            Dim Reader2 As MySqlDataReader
            query = "SELECT * from ewalletinfo where Customer_ID='" & customID & "' AND ewallet_email ='" & lblDetails.Text & "' AND ewallet_type ='" & lblCard.Text & "'"
            Dim cm2 As New MySqlCommand
            cm2 = New MySqlCommand(query, conn)
            conn.Open()
            Reader2 = cm2.ExecuteReader
            While Reader2.Read
                totalAmt2 = Reader2("amount")
            End While



            ''DELIVERY
            Dim cm3 As New MySqlCommand
            conn.Close()
            cm3 = New MySqlCommand("Update delivery set Order_Status=@Status WHERE Delivery_ID ='" & frmDelivery.delivery & "'", conn)
            With cm3
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "Canceled on Summary")
            End With
            conn.Open()
            If cm3.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Delivery Details Canceled", "DELAROTA DELIVERY DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmShop.loadcartcount()
                frmShop.txtCart.Enabled = False

            Else
                MessageBox.Show("Error")
            End If
            Me.Hide()
            ''PAYMENT


            ''CART
            Dim cm4 As New MySqlCommand
            conn.Close()
            cm4 = New MySqlCommand("truncate table cart", conn)
            conn.Open()
            cm4.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Cart Ittems Deleted", "DELAROTA CART DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmShop.loadcartcount()
            frmCart.loadRecord()
            frmShop.lblPrice.Text = "TOTAL PRICE: " & 0.00

            ''ORDERDETAILS
            Dim cm5 As New MySqlCommand
            conn.Close()
            cm5 = New MySqlCommand("Update orderdetails set Status=@Status WHERE Order_ID ='" & orderID & "'", conn)
            With cm5
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "Canceled on Summary")
            End With
            conn.Open()
            If cm5.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Order Items Deleted", "DELAROTA ORDER DETAILS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error")
            End If
            Me.Hide()


            If lblMode.Text = "Credit/Debit Card" Then
                ''CREDIT INFO 
                Dim cm6 As New MySqlCommand
                conn.Close()
                cm6 = New MySqlCommand("Update creditinfo set Amount=@Amt WHERE Customer_ID ='" & customID & "' AND creditcard_no ='" & lblDetails.Text & "' AND creditcard_type ='" & lblCard.Text & "'", conn)
                With cm6
                    Dim amt As Integer = Val(lblTotal.Text)
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Amt", totalAmt + amt)
                End With
                conn.Open()
                cm6.ExecuteNonQuery()
                conn.Close()
            End If


            If lblMode.Text = "E-Wallets" Then
                ''E-WALLET INFO

                Dim cm7 As New MySqlCommand
                conn.Close()
                cm7 = New MySqlCommand("Update ewalletinfo set Amount=@Amt WHERE Customer_ID ='" & customID & "'AND ewallet_email ='" & lblDetails.Text & "' AND ewallet_type ='" & lblCard.Text & "'", conn)
                Dim amt As Integer = Val(lblTotal.Text)

                With cm7
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Amt", totalAmt2 + amt)
                End With
                conn.Open()
                cm7.ExecuteNonQuery()
                conn.Close()
            End If

            ''Stock
            For i = 0 To frmDelivery.dgvCart.Rows.Count - 1
                Dim totalStock As Integer
                Dim quan As Integer = frmDelivery.dgvCart.Rows(i).Cells(2).Value
                Dim prodId As Integer = frmDelivery.dgvCart.Rows(i).Cells(0).Value
                Dim sum As Integer
                Dim query3 As String
                Dim reader3 As MySqlDataReader
                query3 = "select * from product where product_id='" & frmDelivery.dgvCart.Rows(i).Cells(0).Value & "'"
                Dim comm3 As New MySqlCommand
                comm3 = New MySqlCommand(query3, conn)
                conn.Open()
                reader3 = comm3.ExecuteReader
                While reader3.Read
                    totalStock = reader3("Stock")
                    Console.WriteLine(totalStock)
                End While

                conn.Close()
                conn.Open()
                Dim comm2 As New MySqlCommand
                comm2 = New MySqlCommand("Update product set Stock=@Stock WHERE Product_ID =@ProdId", conn)
                With comm2
                    sum = totalStock + quan
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@ProdId", prodId)
                    .Parameters.AddWithValue("@Stock", sum)
                    Console.WriteLine(sum)

                End With
                comm2.ExecuteNonQuery()
                frmShop.loadRecord()
                conn.Close()
                conn.Open()

                Dim comm4 As New MySqlCommand
                comm4 = New MySqlCommand("Update inventory set Stock=@Stock WHERE Product_ID =@ProdId", conn)
                With comm4
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@ProdId", prodId)
                    .Parameters.AddWithValue("@Stock", sum)
                    Console.WriteLine(sum)
                End With
                comm4.ExecuteNonQuery()
                frmShop.loadRecord()
                conn.Close()
            Next
        Catch ex As Exception
            MessageBox.Show("CANCEL ORDER ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class