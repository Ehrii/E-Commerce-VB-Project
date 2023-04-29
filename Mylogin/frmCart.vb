Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports MySql.Data.MySqlClient

Public Class frmCart
    Dim discount As String
    Public totaldisc, totalAmt, totalSub, shopprice As Decimal
    Public sum As Decimal = 0
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick
        Dim cm As New MySqlCommand
        Dim prodId As New Integer
        Dim colName As String = dgvCart.Columns(e.ColumnIndex).Name
        conn.Close()

        If colName = "Delete" Then
            stockvalidation()
            prodId = dgvCart.CurrentRow.Cells(0).Value.ToString()
            Dim cartid As Integer
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from cart where product_id='" & prodId & "'"
            Dim cm1 As New MySqlCommand
            cm1 = New MySqlCommand(query, conn)
            conn.Open()
            reader = cm1.ExecuteReader
            While reader.Read
                cartid = reader.GetString("Cart_ID")
            End While
            conn.Close()

            cm = New MySqlCommand("DELETE FROM cart WHERE Cart_ID = @CartID", conn)
            cm.Parameters.Add("@CartID", MySqlDbType.Int64).Value = cartid

            conn.Open()
            If cm.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Deleted")
                loadRecord()
                loadCart()
                frmShop.loadcartcount()
            Else
                MessageBox.Show("Error")
            End If
        End If


        Dim query2 As String
        Dim reader2 As MySqlDataReader
        Dim cm2 As New MySqlCommand


        query2 = "select * from cart"
        'table
        Dim da = New MySqlDataAdapter(query2, conn)
        'reader
        cm2 = New MySqlCommand(query2, conn)

        Dim dt = New DataTable()
        da.Fill(dt)

        If dt.Rows.Count <= 0 Then
            Me.Hide()
            frmShop.txtCart.Enabled = False
        End If

    End Sub


    Sub stockvalidation()
        Dim totalStock As Integer
        Dim quan As Integer = dgvCart.CurrentRow.Cells(3).Value
        Dim prodId As Integer = dgvCart.CurrentRow.Cells(0).Value
        Dim sum As Integer
        Dim query As String
        Dim reader As MySqlDataReader

        query = "select * from product where product_id='" & prodId & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            totalStock = reader("Stock")
            Console.WriteLine(totalStock)
        End While

        conn.Close()
        conn.Open()
        Dim comm As New MySqlCommand
        comm = New MySqlCommand("Update product set Stock=@Stock WHERE Product_ID =@ProdId", conn)
        With comm
            sum = totalStock + quan
            .Parameters.Clear()
            .Parameters.AddWithValue("@ProdId", prodId)
            .Parameters.AddWithValue("@Stock", sum)
            Console.WriteLine(sum)

        End With
        comm.ExecuteNonQuery()
        frmShop.loadRecord()
        conn.Close()

    End Sub

    Private Sub frmCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Close()
        connect()
        loadRecord()
        loadCart()



    End Sub


    Sub loadRecord()
        Dim cm As New MySqlCommand
        dgvCart.Rows.Clear()
        conn.Close()
        conn.Open()
        cm = New MySqlCommand("Select * from cart where Customer_ID ='" & customID & "'", conn)
        dr = cm.ExecuteReader
        While dr.Read
            dgvCart.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Image"), dr.Item("Product_Name").ToString, dr.Item("Quantity").ToString, dr.Item("Amount").ToString, dr.Item("Item_Size").ToString)
        End While
        dr.Close()
        conn.Close()
        For i = 0 To dgvCart.Rows.Count - 1
            Dim r As DataGridViewRow = dgvCart.Rows(i)
            r.Height = 60
        Next
        Dim imagecolumn = DirectCast(dgvCart.Columns("Column2"), DataGridViewImageColumn)
        imagecolumn.ImageLayout = DataGridViewImageCellLayout.Zoom


    End Sub


    Function loadCart()

        Dim customregion As String
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from customer where customer_id='" & customID & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            customregion = reader.GetString("Region")
        End While
        conn.Close()

        Dim query2 As String
        Dim reader2 As MySqlDataReader
        query2 = "select Shipping_Fee from region where region_name='" & customregion & "'"
        Dim cm2 As New MySqlCommand
        cm2 = New MySqlCommand(query2, conn)
        conn.Open()
        reader2 = cm2.ExecuteReader
        While reader2.Read
            shippingFee = reader2.GetString("Shipping_Fee")
        End While
        conn.Close()


        sum = 0.00
        For i = 0 To dgvCart.Rows.Count - 1
            sum += dgvCart.Rows(i).Cells(4).Value * dgvCart.Rows(i).Cells(3).Value

        Next

        frmShop.lblPrice.Text = "TOTAL PRICE: " & FormatNumber(sum, 2)
        shopprice = FormatNumber(sum, 2)

        Dim totalQty As Integer = 0
        For i = 0 To dgvCart.Rows.Count - 1
            totalQty += dgvCart.Rows(i).Cells(3).Value

        Next
        txtQty.Text = totalQty
        lblDiscount.Text = "None"
        txtShipping.Text = FormatNumber(shippingFee, 2)
        txtSub.Text = FormatNumber(sum, 2)

        lblTotal.Text = sum + shippingFee
        totalAmt = lblTotal.Text
        lblTotal.Text = FormatNumber(lblTotal.Text, 2)
        verify()

    End Function


    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles btnVerify.Click
        verify()
    End Sub

    Sub calculateDisc(disc As Double)
        frmDelivery.lblDiscAmt.Text = totaldisc
        lblDiscount.Text = discount
        frmDelivery.lblDiscount.Text = discount
        totalAmt = Val(totalAmt) - Val(totaldisc)
        lblTotal.Text = totalAmt
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        addrecords()
        frmDelivery.loadrecord()
        conn.Open()
    End Sub


    Sub addrecords()

        Dim command As New MySqlCommand("INSERT INTO orderdetails VALUES(@Order_ID,@Order_Date,@Total,@Qty,@Status,@Customer_ID)", conn)
        Dim amt As Decimal = FormatNumber(lblTotal.Text, 2)

        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Order_ID", 0)
            .Parameters.AddWithValue("@Order_Date", currdatetime)
            .Parameters.AddWithValue("@Total", amt)
            .Parameters.AddWithValue("@Qty", txtQty.Text)
            .Parameters.AddWithValue("@Status", "Pending")
            .Parameters.AddWithValue("@Customer_ID", customID)
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            frmDelivery.lblShipping.Text = txtShipping.Text
            MessageBox.Show("Cart Records Inserted")
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from orderdetails"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            reader = cm.ExecuteReader
            While reader.Read
                orderID = reader.GetString("Order_ID")
            End While
            conn.Close()
            frmPayment.lblOrder.Text = "ORDER ID: " & orderID
            frmDelivery.Show()
            Me.Hide()
        Else
            MessageBox.Show("Record not Inserted")

        End If
        conn.Close()

        Dim command2 As New MySqlCommand("UPDATE cart SET Order_ID = @Order_ID", conn)
        With command2
            .Parameters.Clear()
            .Parameters.AddWithValue("@Order_ID", orderID)
        End With
        conn.Open()
        command2.ExecuteNonQuery()
        conn.Close()




    End Sub


    Function verify()
        Dim query As String
        Dim reader As MySqlDataReader
        Dim cm As New MySqlCommand


        query = "select * from coupon where Coupon_Code ='" & txtCoupon.Text & "'"
        'table
        Dim da = New MySqlDataAdapter(query, conn)
        'reader
        cm = New MySqlCommand(query, conn)

        Dim dt = New DataTable()
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            conn.Open()
            MessageBox.Show("Coupon Verified", "COUPON CODE VALIDATION SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnVerify.Enabled = False

            reader = cm.ExecuteReader

            frmDelivery.txtCoupon.Text = txtCoupon.Text
            frmDelivery.btnVerify.Enabled = False
            frmDelivery.txtCoupon.Enabled = False
            While reader.Read
                discount = reader.GetString("discount")
                'frmDelivery.lblDiscount.Text = "-" & discount
                totalSub = txtSub.Text
                If discount = "15%" Then

                    totaldisc = 0.15 * (FormatNumber(Val(totalAmt), 2))
                    calculateDisc(totaldisc)

                ElseIf discount = "20%" Then
                    totaldisc = 0.2 * (FormatNumber(Val(totalAmt), 2))
                    calculateDisc(totaldisc)

                    'frmDelivery.lblDiscAmt.Text = totaldisc
                    'lblDiscount.Text = discount
                    'frmDelivery.lblDiscount.Text = discount
                    'totalAmt = Val(totalSub) - Val(totaldisc)
                    'lblTotalBal.Text = totalAmt
                    'lblTotal.Text = "Total:    " & lblTotalBal.Text

                End If
            End While

        End If
        conn.Close()
    End Function


End Class