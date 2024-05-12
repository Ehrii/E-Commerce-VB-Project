Imports Guna.UI2.WinForms
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAudit
    Private Sub frmAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        toggleTime.Checked = True

        auditload()


    End Sub

    'SELECT review.comment as 'Comment',review.rating as 'Rating', product.product_image as 'Product Image', review.product_id as 'Product ID', review.customer_id as 'Customer ID' FROM review INNER JOIN product ON review.product_id = product.product_id where rating=1
    Sub auditload()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Audit_No as'Audit No.', Username as 'Audit Username', Action_Type as'Action Type' , Action_Date as'Action Date', Action_Time as'Action Time', Role as'Role' from audit", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvAudit.DataSource = table
        conn.Close()
    End Sub



    Sub paymentload()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Payment_ID as'Payment ID', Order_ID as 'Order ID', Payment_Method as'Payment Method' , Payment_Amount as'Payment Amount', Payment_Date as'Payment Date', Amount_Due as'Amount Due', Account_Details as 'Account Details' from payment", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvAudit.DataSource = table
        conn.Close()
    End Sub


    Sub ordersload()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Order_ID as'Order ID', Order_Date as 'Order Date', Total as'Order Total' , Qty as'Order Quantity', Status as'Order Status', Customer_ID as'Customer ID', Date_Received as 'Date Received' from orderdetails", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvAudit.DataSource = table
        conn.Close()
    End Sub





    Private Sub DgvInventory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvAudit.CellMouseClick
        conn.Close()

        txtNo.Text = DgvAudit.CurrentRow.Cells(0).Value.ToString()
        txtUsername.Text = DgvAudit.CurrentRow.Cells(1).Value.ToString()
        txtAction.Text = DgvAudit.CurrentRow.Cells(2).Value.ToString()
        txtActionDate.Text = DgvAudit.CurrentRow.Cells(3).Value
        txtTime.Text = DgvAudit.CurrentRow.Cells(4).Value.ToString()
        txtRole.Text = DgvAudit.CurrentRow.Cells(5).Value.ToString()

        Dim query As String
        Dim reader As MySqlDataReader
        query = "Select * from customer where customer_username='" & DgvAudit.CurrentRow.Cells(1).Value.ToString() & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader

        While reader.Read
            Dim imageBytes As Byte() = DirectCast(reader("Profile_Image"), Byte())
            Dim stream As New MemoryStream(imageBytes)
            Dim image As Image = image.FromStream(stream)
            picAvatar.Image = image
        End While
        conn.Close()


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If toggleTime.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("select Audit_no as'Audit_No', Username as 'Username', Action_Type as'Action Type' , Action_Date as'Action Date', Action_Time as'Action Time', Role as'Role' from audit  where Action_Date between @d1 and @d2", conn)
            command.Parameters.Add("@d1", MySqlDbType.DateTime).Value = dtp1.Value
            command.Parameters.Add("@d2", MySqlDbType.DateTime).Value = dtp2.Value
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf togglePay.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Payment_ID as'Payment ID', Order_ID as 'Order ID', Payment_Method as'Payment Method' , Payment_Amount as'Payment Amount', Payment_Date as'Payment Date', Amount_Due as'Amount Due', Account_Details as 'Account Details' from payment  where Payment_Date between @d1 and @d2", conn)
            command.Parameters.Add("@d1", MySqlDbType.DateTime).Value = dtp1.Value
            command.Parameters.Add("@d2", MySqlDbType.DateTime).Value = dtp2.Value
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf toggleOrd.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Order_ID as'Order ID', Order_Date as 'Order Date', Total as'Order Total' , Qty as'Order Quantity', Status as'Order Status', Customer_ID as'Customer ID', Date_Received as 'Date Received' from orderdetails  where Order_Date between @d1 and @d2", conn)
            command.Parameters.Add("@d1", MySqlDbType.DateTime).Value = dtp1.Value
            command.Parameters.Add("@d2", MySqlDbType.DateTime).Value = dtp2.Value
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        Else
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If toggleTime.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("select Audit_no as'Audit_No', Username as 'Username', Action_Type as'Action Type' , Action_Date as'Action Date', Action_Time as'Action Time', Role as 'Role' from audit WHERE DATE(Action_Date) = DATE(@currdate)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf togglePay.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Payment_ID as'Payment ID', Order_ID as 'Order ID', Payment_Method as'Payment Method' , Payment_Amount as'Payment Amount', Payment_Date as'Payment Date', Amount_Due as'Amount Due', Account_Details as 'Account Details' from payment WHERE DATE(Payment_Date) = DATE(@currdate)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf toggleOrd.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Order_ID as'Order ID', Order_Date as 'Order Date', Total as'Order Total' , Qty as'Order Quantity', Status as'Order Status', Customer_ID as'Customer ID', Date_Received as 'Date Received' from orderdetails  WHERE DATE(Order_Date) = DATE(@currdate)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If toggleTime.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("select Audit_no as'Audit_No', Username as 'Username', Action_Type as'Action Type' , Action_Date as'Action Date', Action_Time as'Action Time', Role as 'Role' from audit  WHERE YEAR(Action_Date) = YEAR(@currdate) AND WEEK(@currdate) = WEEK(Action_Date)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf togglePay.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Payment_ID as'Payment ID', Order_ID as 'Order ID', Payment_Method as'Payment Method' , Payment_Amount as'Payment Amount', Payment_Date as'Payment Date', Amount_Due as'Amount Due', Account_Details as 'Account Details' from payment WHERE YEAR(Payment_Date) = YEAR(@currdate) AND WEEK(@currdate) = WEEK(Payment_Date)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf toggleOrd.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Order_ID as'Order ID', Order_Date as 'Order Date', Total as'Order Total' , Qty as'Order Quantity', Status as'Order Status', Customer_ID as'Customer ID', Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND WEEK(@currdate) = WEEK(Order_Date)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()

        End If





    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If toggleTime.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("select Audit_no as'Audit_No', Username as 'Username', Action_Type as'Action Type' , Action_Date as'Action Date', Action_Time as'Action Time', Role as 'Role' from audit  WHERE YEAR(Action_Date) = YEAR(@currdate) AND MONTH(Action_Date) = MONTH(@currdate)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf togglePay.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Payment_ID as'Payment ID', Order_ID as 'Order ID', Payment_Method as'Payment Method' , Payment_Amount as'Payment Amount', Payment_Date as'Payment Date', Amount_Due as'Amount Due', Account_Details as 'Account Details' from payment  WHERE YEAR(Payment_Date) = YEAR(@currdate) AND MONTH(Payment_Date) = MONTH(@currdate)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        ElseIf toggleOrd.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Order_ID as'Order ID', Order_Date as 'Order Date', Total as'Order Total' , Qty as'Order Quantity', Status as'Order Status', Customer_ID as'Customer ID', Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) = YEAR(@currdate) AND MONTH(Order_Date) = MONTH(@currdate)", conn)
            command.Parameters.Add("@currdate", MySqlDbType.DateTime).Value = currdate
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table
            conn.Close()
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If toggleTime.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("select Audit_no as'Audit_No', Username as 'Username', Action_Type as'Action Type' , Action_Date as'Action Date', Action_Time as'Action Time', Role as 'Role' from audit   WHERE YEAR(Action_Date) ='" & DateAndTime.Year(currdate) & "'", conn)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table

            conn.Close()
        ElseIf togglePay.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Payment_ID as'Payment ID', Order_ID as 'Order ID', Payment_Method as'Payment Method' , Payment_Amount as'Payment Amount', Payment_Date as'Payment Date', Amount_Due as'Amount Due', Account_Details as 'Account Details' from payment  WHERE YEAR(Payment_Date) ='" & DateAndTime.Year(currdate) & "'", conn)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table

            conn.Close()
        ElseIf toggleOrd.Checked Then
            Dim table As New DataTable()
            Dim command As New MySqlCommand("Select Order_ID as'Order ID', Order_Date as 'Order Date', Total as'Order Total' , Qty as'Order Quantity', Status as'Order Status', Customer_ID as'Customer ID', Date_Received as 'Date Received' from orderdetails  WHERE YEAR(Order_Date) ='" & DateAndTime.Year(currdate) & "'", conn)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)
            DgvAudit.DataSource = table

            conn.Close()


        End If

    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles togglePay.CheckedChanged
        If togglePay.Checked = True Then
            grpAuditinfo.Enabled = False
            paymentload()
            toggleOrd.Enabled = False
            toggleTime.Enabled = False
        ElseIf togglePay.Checked = False Then
            auditload()
            toggleOrd.Enabled = True
            toggleTime.Enabled = True

        End If
    End Sub

    Private Sub toggleMen_CheckedChanged(sender As Object, e As EventArgs) Handles toggleOrd.CheckedChanged
        If toggleOrd.Checked = True Then
            grpAuditinfo.Enabled = False
            ordersload()
            togglePay.Enabled = False
            toggleTime.Enabled = False
        ElseIf toggleOrd.Checked = False Then
            auditload()
            togglePay.Enabled = True
            toggleTime.Enabled = True
        End If
    End Sub

    Private Sub toggleTime_CheckedChanged(sender As Object, e As EventArgs) Handles toggleTime.CheckedChanged
        If toggleTime.Checked = True Then
            grpAuditinfo.Enabled = True

            auditload()
            togglePay.Enabled = False
            toggleOrd.Enabled = False
        ElseIf toggleTime.Checked = False Then
            auditload()
            toggleOrd.Enabled = True
            toggleTime.Enabled = True
            togglePay.Enabled = True
        End If
    End Sub


End Class