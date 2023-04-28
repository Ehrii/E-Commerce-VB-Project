Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports DevComponents.DotNetBar
Imports DevComponents.Editors
Imports MySql.Data.MySqlClient

Public Class frmDelivery
    Dim total = 0
    Dim totalDisc As Decimal
    Public tracknum As Decimal
    Public query3 As String
    Dim newbal As Decimal
    Dim DeliveryType As String
    Public reader3 As MySqlDataReader
    Public delivery


    Sub loadrecord()
        lblOrderID.Text = orderID
        total = frmCart.lblTotal.Text
        lblTotal.Text = total
        cmbDelivery.Enabled = False
        cmbRegion.Enabled = False
        cmbCity.Enabled = False
        txtAddress.Enabled = False
        txtBarangay.Enabled = False
        txtPhone.Enabled = False
        txtTracking.Enabled = False
        txtDate.Enabled = False
        txtDate.Text = DateAndTime.Today & " - " & DateAndTime.Today.AddDays(7)
        conn.Close()

        Dim cm As New MySqlCommand

        dgvCart.Rows.Clear()

        cm = New MySqlCommand("Select * from cart where Customer_ID ='" & customID & "'", conn)
        conn.Open()
        dr = cm.ExecuteReader
        While dr.Read
            dgvCart.Rows.Add(dr.Item("Product_ID").ToString, dr.Item("Product_Name"), dr.Item("Quantity").ToString, dr.Item("Amount").ToString)
        End While
        dr.Close()
        conn.Close()
        For i = 0 To dgvCart.Rows.Count - 1
            Dim r As DataGridViewRow = dgvCart.Rows(i)
            r.Height = 30

        Next
    End Sub
    Private Sub frmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        loadrecord()



        'TRACKING NUMBER'
        tracknum = 123456789012
        Dim query2 As String
        Dim reader2 As MySqlDataReader
        query2 = "select * from delivery where tracking_number=(Select max(tracking_number))"
        Dim com As New MySqlCommand
        com = New MySqlCommand(query2, conn)
        conn.Open()
        reader2 = com.ExecuteReader
        While reader2.Read
            tracknum = reader2.GetString("tracking_number")
            tracknum += 1
            txtTracking.Text = tracknum
        End While
        conn.Close()

        'GET CUSTOMER DATA'
        Dim address, Region, city As String
        query3 = "select * from customer where customer_id='" & customID & "'"
        Dim comm As New MySqlCommand
        comm = New MySqlCommand(query3, conn)
        conn.Open()
        reader3 = comm.ExecuteReader
        While reader3.Read
            address = reader3.GetString("Street_Address")
            Region = reader3.GetString("Region")
            city = reader3.GetString("city")
        End While
        conn.Close()


        Dim command As New MySqlCommand("INSERT INTO delivery VALUES(@Delivery_ID,@Delivery_Type,@Tracking_Number,@Delivery_Date,@Order_ID,@Customer_ID,@Delivery_Location,@Order_Status)", conn)
        Dim DeliveryType As String = "Standard Delivery (5-7 Days)"

        With command
            .Parameters.Clear()
            .Parameters.AddWithValue("@Delivery_ID", 0)
            .Parameters.AddWithValue("@Delivery_Type", DeliveryType)
            .Parameters.AddWithValue("@Tracking_Number", tracknum)
            .Parameters.AddWithValue("@Delivery_Date", txtDate.Text)
            .Parameters.AddWithValue("@Order_ID", orderID)
            .Parameters.AddWithValue("@Customer_ID", customID)
            .Parameters.AddWithValue("@Delivery_Location", Region & " - " & address & " - " & city)
            .Parameters.AddWithValue("@Order_Status", "Pending")
        End With
        conn.Open()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Success")
        Else
            MessageBox.Show("Record Not Inserted")

        End If
        conn.Close()

        lbltotalQty.Text = frmCart.txtQty.Text

        loadDelivery()
        loadRegionRecord()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        conn.Close()


        Dim query1, query2, query3 As String
        Dim reader1, reader2, reader3 As MySqlDataReader

        query1 = "select * from delivery where customer_id='" & customID & "'"
        Dim comm1 As New MySqlCommand
        comm1 = New MySqlCommand(query1, conn)
        conn.Open()
        reader1 = comm1.ExecuteReader
        While reader1.Read
            delivery = reader1.GetString("delivery_id")
        End While
        conn.Close()


        query2 = "select * from orderdetails where customer_id='" & customID & "'"
        Dim comm2 As New MySqlCommand
        comm2 = New MySqlCommand(query2, conn)
        conn.Open()
        reader2 = comm2.ExecuteReader
        While reader2.Read
            orderID = reader2.GetString("order_ID")
        End While
        conn.Close()




        Dim cm As New MySqlCommand
        cm = New MySqlCommand("UPDATE delivery Set Delivery_Type = @DevType, Tracking_Number =@TrackNum, Delivery_Date =@DelivDate, Order_ID = @OrderID, Delivery_Location =@DelivLoc, Order_Status=@OrderStatus  WHERE Delivery_ID ='" & delivery & "'", conn)

        Dim prodId As New Integer
        With cm
            .Parameters.Clear()
            .Parameters.AddWithValue("@DevType", DeliveryType)
            .Parameters.AddWithValue("@TrackNum", tracknum)
            .Parameters.AddWithValue("@DelivDate", txtDate.Text)
            .Parameters.AddWithValue("@OrderID", orderID)
            .Parameters.AddWithValue("@DelivLoc", cmbRegion.Text & " - " & txtAddress.Text & " - " & cmbCity.Text)
            .Parameters.AddWithValue("@OrderStatus", "Canceled")

        End With




        conn.Open()
        If cm.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Updated")
            Me.Hide()
        Else
            MessageBox.Show("Record not Updated")
        End If
        conn.Close()




        Dim cm2 As New MySqlCommand
        cm2 = New MySqlCommand("UPDATE orderDetails SET Total=@Total where Order_ID='" & orderID & "'", conn)
        Dim amt As Decimal = lblTotal.Text
        With cm2
            .Parameters.Clear()
            .Parameters.AddWithValue("@Total", amt)

        End With
        conn.Open()
        If cm2.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Amount Updated")
            frmPayment.Show()
            'frmManage.loadRecord()
            Me.Hide()
        Else
            MessageBox.Show("Record not Updated")
        End If
        conn.Close()


        frmPayment.loadrecord()
    End Sub

    Sub loadRegionRecord()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from region"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()

        reader = cm.ExecuteReader
        While reader.Read
            Dim reg = reader.GetString("Region_Name")
            cmbRegion.Items.Add(reg)
        End While
        conn.Close()
    End Sub

    Sub loadDelivery()
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from customer where customer_id='" & customID & "'"
        Dim command As New MySqlCommand
        command = New MySqlCommand(query, conn)
        conn.Open()
        reader = command.ExecuteReader
        While reader.Read
            Dim phonenum = reader.GetString("phone_number")
            Dim region = reader.GetString("Region")
            Dim barangay = reader.GetString("barangay")
            Dim address = reader.GetString("street_address")
            Dim city = reader.GetString("City")
            cmbDelivery.Text = "Standard Delivery (5-7 Days)"
            txtPhone.Text = phonenum
            cmbRegion.Text = region
            txtBarangay.Text = barangay
            txtAddress.Text = address
            cmbCity.Text = city
        End While
        conn.Close()
    End Sub


    Sub readData(command As String)
        conn.Close()
        Dim readerreg As MySqlDataReader
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(command, conn)
        conn.Open()
        readerreg = cm.ExecuteReader
        While readerreg.Read
            Dim reg = readerreg.GetString("City_Name")
            cmbCity.Items.Add(reg)
        End While
    End Sub




    Private Sub cmbRegion_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbRegion.SelectedIndexChanged
        cmbCity.Items.Clear()
        Dim query As String
        If cmbRegion.Text = "Region 1 (Ilocos Region)" Then
            query = "Select * from city where Region_ID = 1001"
            readData(query)
            changeRegion()
        End If

        If cmbRegion.Text = "Region 2 (Cagayan Valley)" Then
            query = "Select * from city where Region_ID = 1002"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 3 (Central Luzon)" Then
            query = "Select * from city where Region_ID = 1003"
            readData(query)
            changeRegion()

        End If


        If cmbRegion.Text = "Region 4A (CALABARZON)" Then
            query = "Select * from city where Region_ID = 1004"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 4B (MIMAROPA)" Then
            query = "Select * from city where Region_ID = 1005"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 5 (Bicol Region)" Then
            query = "Select * from city where Region_ID = 1006"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 6 (Western Visayas)" Then
            query = "Select * from city where Region_ID = 1007"
            readData(query)
            changeRegion()

        End If


        If cmbRegion.Text = "Region 7 (Central Visayas)" Then
            query = "Select * from city where Region_ID = 1008"
            readData(query)
            changeRegion()

        End If


        If cmbRegion.Text = "Region 8 (Eastern Visayas)" Then
            query = "Select * from city where Region_ID = 1009"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 9 (Zamboanga Peninsula)" Then
            query = "Select * from city where Region_ID = 1010"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 10 (Northern Mindanao)" Then
            query = "Select * from city where Region_ID = 1011"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 11 (Davao Region)" Then
            query = "Select * from city where Region_ID = 1012"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 12 (SOCCSKSARGEN)" Then
            query = "Select * from city where Region_ID = 1013"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "Region 13 (Caraga Region)" Then
            query = "Select * from city where Region_ID = 1014"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "NCR (National Capital Region)" Then
            query = "Select * from city where Region_ID = 1015"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "CAR (Cordillera Administrative Region)" Then
            query = "Select * from city where Region_ID = 1016"
            readData(query)
            changeRegion()

        End If

        If cmbRegion.Text = "ARMM (Autonomous Region In Muslim Mindanao)" Then
            query = "Select * from city where Region_ID = 1017"
            readData(query)
            changeRegion()

        End If
        conn.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        'verify()

        cmbDelivery.Enabled = False
        cmbRegion.Enabled = False
        cmbCity.Enabled = False
        txtAddress.Enabled = False
        txtBarangay.Enabled = False
        txtPhone.Enabled = False
        txtTracking.Enabled = False



    End Sub
    Function changeRegion()
        conn.Close()
        Dim query2 As String
        Dim reader2 As MySqlDataReader

        query2 = "select Shipping_Fee from region where region_name='" & cmbRegion.Text & "'"
        Dim cm2 As New MySqlCommand
        cm2 = New MySqlCommand(query2, conn)
        conn.Open()
        reader2 = cm2.ExecuteReader
        While reader2.Read
            shippingFee = reader2.GetString("Shipping_Fee")
            lblShipping.Text = shippingFee
            newbal = frmCart.txtSub.Text + shippingFee
            newbal = newbal - Val(lblDiscAmt.Text)
            lblTotal.Text = FormatNumber(newbal, 2)



        End While
        'conn.Open()
        conn.Close()
    End Function

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        cmbDelivery.Enabled = True
        cmbRegion.Enabled = True
        cmbCity.Enabled = True
        txtAddress.Enabled = True
        txtBarangay.Enabled = True
        txtPhone.Enabled = True
        txtTracking.Enabled = False
    End Sub
    Private Sub btnVerify_Click(sender As Object, e As EventArgs)
        'verify()
    End Sub

    Private Sub cmbDelivery_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDelivery.SelectedIndexChanged



        If cmbDelivery.SelectedIndex = 0 Then
            txtDate.Text = DateAndTime.Today & " - " & DateAndTime.Today.AddDays(7)
            DeliveryType = "Standard Delivery (5-7 Days)"
            lblShipping.Text = shippingFee
            newbal = frmCart.txtSub.Text + shippingFee
            newbal = newbal - Val(lblDiscAmt.Text)
            lblTotal.Text = FormatNumber(newbal, 2)
            Exit Sub

        End If
        If cmbDelivery.SelectedIndex = 1 Then
            txtDate.Text = DateAndTime.Today & " - " & DateAndTime.Today.AddDays(2)
            DeliveryType = "Express Shipping (1-2 Days)"
            lblShipping.Text = shippingFee + 50.0
            Dim amount = FormatNumber(newbal, 2) + 50.0
            lblTotal.Text = FormatNumber(amount, 2)
            Exit Sub
        End If
        If cmbDelivery.SelectedIndex = 2 Then
            txtDate.Text = DateAndTime.Today
            DeliveryType = "Same-Day Shipping (1 Day)"
            lblShipping.Text = shippingFee + 100.0
            Dim amount = FormatNumber(newbal, 2) + 100.0
            lblTotal.Text = FormatNumber(amount, 2)
            Exit Sub

        End If
        If cmbDelivery.SelectedIndex = 3 Then
            DeliveryType = "In-Store pickup"
            lblShipping.Text = 0.00
            newbal = frmCart.txtSub.Text + shippingFee
            newbal = newbal - Val(lblDiscAmt.Text)
            lblTotal.Text = FormatNumber(newbal, 2)
            Exit Sub
        End If


    End Sub




    '-------------------------RECENTLY ADDED--------------------------------'

    Function verify()

        Dim query As String
        Dim reader As MySqlDataReader
        Dim cm As New MySqlCommand
        conn.Close()

        'conn.Open()
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


            While reader.Read
                lblDiscount.Text = reader.GetString("discount")

                If lblDiscount.Text = "15%" Then
                    '-------------------------RECENTLY ADDED--------------------------------'
                    totalDisc = 0.15 * (FormatNumber(Val(newbal), 2))
                    lblDiscAmt.Text = totalDisc
                    lblTotal.Text = newbal - totalDisc
                    ' lblTotal.Text = FormatNumber(ne, 2)

                ElseIf lblDiscount.Text = "20%" Then
                    'totalDisc = 0.2 * (FormatNumber(Val(lblTotal.Text), 2))
                    'calculateDisc(totalDisc)

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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        conn.Close()
        Dim query1 As String
        Dim reader1 As MySqlDataReader

        query1 = "select * from delivery where customer_id='" & customID & "'"
        Dim comm1 As New MySqlCommand
        comm1 = New MySqlCommand(query1, conn)
        conn.Open()
        reader1 = comm1.ExecuteReader
        While reader1.Read
            delivery = reader1.GetString("delivery_id")
        End While
        conn.Close()

        Me.Hide()
        frmCart.Hide()
        Dim cm1 As New MySqlCommand
        conn.Close()
        cm1 = New MySqlCommand("Update delivery set Order_Status=@Status WHERE Delivery_ID ='" & delivery & "'", conn)
        With cm1
            .Parameters.Clear()
            .Parameters.AddWithValue("@Status", "Canceled")
        End With
        conn.Open()
        If cm1.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Delivery Cancelled") '''''
            frmShop.loadcartcount()
            frmShop.txtCart.Enabled = False
        Else
            MessageBox.Show("Error")
        End If
        Me.Hide()


        '' ADD STOCKS 
        For i = 0 To dgvCart.Rows.Count - 1
            Dim totalStock As Integer
            Dim quan As Integer = dgvCart.Rows(i).Cells(2).Value
            Dim prodId As Integer = dgvCart.Rows(i).Cells(0).Value
            Dim sum As Integer
            Dim query As String
            Dim reader As MySqlDataReader

            query = "select * from product where product_id='" & dgvCart.Rows(i).Cells(0).Value & "'"
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
        Next

        Dim cm2 As New MySqlCommand
        conn.Close()
        cm2 = New MySqlCommand("truncate table cart", conn)
        conn.Open()
        cm2.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("records deleted") ''''
        frmShop.loadcartcount()
        frmCart.loadRecord()
        frmShop.lblPrice.Text = "TOTAL PRICE: " & 0.00

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

    Private Sub btnVerify_Click_2(sender As Object, e As EventArgs) Handles btnVerify.Click
        verify()
    End Sub
End Class