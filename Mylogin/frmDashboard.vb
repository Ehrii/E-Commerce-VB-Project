Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Web
Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna
Imports Guna.Charts.WinForms
Imports MySql.Data.MySqlClient

Public Class frmDashboard
    Public series1 As New Series()
    Public series2 As New Series()
    Public series3 As New Series()
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        lblMonth.Text = MonthName(Today.Month)
        lblToday.Text = currdate

        Dim query As String
        Dim reader As MySqlDataReader
        Dim cm As New MySqlCommand
        Dim deliverystats As String = "Delivered"
        query = "select * from orderdetails"
        'table
        Dim da = New MySqlDataAdapter(query, conn)
        'reader
        cm = New MySqlCommand(query, conn)

        Dim dt = New DataTable()
        da.Fill(dt)

        'Try

        Try
            ''CUSTOMER
            Dim user_cmd As New MySqlCommand
            Dim user_stmt As String
            Dim usertotalcount As String
            user_stmt = "Select count(*) from Customer"
            user_cmd = New MySqlCommand(user_stmt, conn)
            usertotalcount = user_cmd.ExecuteScalar()
            lblnumcustomer.Text = usertotalcount
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            '' ADMIN
            Dim user_cmd1 As New MySqlCommand
            Dim user_stmt1 As String
            Dim usertotalcount1 As String
            user_stmt1 = "Select count(*) from Admin"
            user_cmd1 = New MySqlCommand(user_stmt1, conn)
            usertotalcount1 = user_cmd1.ExecuteScalar()
            lblnumAdmin.Text = usertotalcount1
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            ''TODAY ORDERS

            Dim user_cmd2 As New MySqlCommand
            Dim user_stmt2 As String
            Dim usertotalcount2 As String
            user_stmt2 = "Select count(*) from orderdetails where status=@Status and order_date=@today "
            user_cmd2 = New MySqlCommand(user_stmt2, conn)
            user_cmd2.Parameters.Add("@Status", MySqlDbType.String).Value = deliverystats
            user_cmd2.Parameters.Add("@today", MySqlDbType.Date).Value = currdate



            usertotalcount2 = user_cmd2.ExecuteScalar()
            lbltodayOrders.Text = usertotalcount2
            If Not IsDBNull(usertotalcount2) Then
                lbltodayOrders.Text = usertotalcount2
            Else
                lbltodayOrders.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        Try
            ''TODAY REVENUE
            Dim user_cmd3 As New MySqlCommand
            Dim user_stmt3 As String
            Dim usertotalcount3
            user_stmt3 = "Select sum(total) from orderdetails where Status=@status AND order_date = @today"
            user_cmd3 = New MySqlCommand(user_stmt3, conn)
            user_cmd3.Parameters.Add("@today", MySqlDbType.Date).Value = currdate
            user_cmd3.Parameters.Add("@status", MySqlDbType.String).Value = deliverystats

            usertotalcount3 = user_cmd3.ExecuteScalar()

            If Not IsDBNull(usertotalcount3) Then
                lbltodayrevenue.Text = FormatNumber(usertotalcount3, 2)
            Else
                lbltodayrevenue.Text = 0.00

            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            ''TOTAL REVENUE
            Dim user_cmd4 As New MySqlCommand
            Dim user_stmt4 As String
            Dim usertotalcount4 As String
            user_stmt4 = "Select sum(sales_profit) from sales_report"
            user_cmd4 = New MySqlCommand(user_stmt4, conn)
            usertotalcount4 = user_cmd4.ExecuteScalar()
            lblRevenue.Text = FormatNumber(usertotalcount4, 2)
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            ''TOTAL PRODUCTS SOLD
            Dim user_cmd5 As New MySqlCommand
            Dim user_stmt5 As String
            Dim usertotalcount5 As String
            user_stmt5 = "Select sum(sales_volume) from sales_report"
            user_cmd5 = New MySqlCommand(user_stmt5, conn)
            usertotalcount5 = user_cmd5.ExecuteScalar()
            lblnumofproductssold.Text = usertotalcount5
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        Try
            ''AVAILABLE PROD
            Dim user_cmd6 As New MySqlCommand
            Dim user_stmt6 As String
            Dim usertotalcount6 As String
            user_stmt6 = "Select count(*) from product"
            user_cmd6 = New MySqlCommand(user_stmt6, conn)
            usertotalcount6 = user_cmd6.ExecuteScalar()
            lblnumofprod.Text = usertotalcount6

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        Try
            ''CRITICAL PRODUCTS
            Dim user_cmd7 As New MySqlCommand
            Dim user_stmt7 As String
            Dim usertotalcount7 As String
            user_stmt7 = "Select count(*) from returnprod"
            user_cmd7 = New MySqlCommand(user_stmt7, conn)
            usertotalcount7 = user_cmd7.ExecuteScalar()
            lblCritical.Text = usertotalcount7
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            ''BEST SELLER
            Dim query2 As String
            query2 = "Select max(Sales_amount) from sales_report"
            Dim cm2 As New MySqlCommand
            cm2 = New MySqlCommand(query2, conn)
            Dim maxvalue As Decimal = cm2.ExecuteScalar

            Dim reader1 As MySqlDataReader
            Dim query3 As String = "SELECT * FROM sales_report WHERE Sales_Amount ='" & maxvalue & "'"
            Dim cmd3 As New MySqlCommand(query3, conn)
            reader1 = cmd3.ExecuteReader
            While reader1.Read
                Dim productName As String = reader1.GetString("Product_Name")
                txtBestSeller.Text = productName

            End While

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        loadchart()
        loadchart2()
    End Sub


    Sub loadchart()
        Try
            Chart1.Series.Clear()
            Chart2.Series.Clear()
            conn.Close()
            'Dim series1 As New Series()
            series1.ChartType = SeriesChartType.StackedBar
            Dim table As New DataTable()
            Dim command As New MySqlCommand("SELECT product_id,sales_amount FROM sales_report GROUP BY report_id ORDER BY sales_amount DESC LIMIT 10", conn)
            Chart1.Series.Add(series1)
            Dim chartArea As ChartArea = Chart1.ChartAreas(0)
            chartArea.Position.Height += 3


            With Chart1
                .Series(0).Palette = ChartColorPalette.SemiTransparent
                .Series(0).BorderColor = Color.White
                .ChartAreas(0).Area3DStyle.Enable3D = True
                .Series(0).LabelFormat = "₱{#,##0}"
                .Series(0).LabelForeColor = Color.Black
                .Series(0).IsValueShownAsLabel = True

            End With


            Dim XAxis As Axis = Chart1.ChartAreas(0).AxisX
            Dim YAxis As Axis = Chart1.ChartAreas(0).AxisY
            XAxis.LabelStyle.Font = New Font("Tw Cen Mt", 11, FontStyle.Regular)
            YAxis.LabelStyle.Font = New Font("Tw Cen Mt", 11, FontStyle.Regular)
            XAxis.Maximum = 10

            Dim da As New MySqlDataAdapter
            da.SelectCommand = command
            table.Clear()
            da.Fill(table)

            Dim prodId, prodAmt As Integer


            For i = 0 To table.Rows.Count - 1
                conn.Close()
                prodId = table(i)(0)
                prodAmt = table(i)(1)
                series1.Points.AddXY("Product ID: " & prodId, FormatNumber(prodAmt, 2))
            Next


        Catch ex As Exception
            MessageBox.Show("LOADING CHART ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Sub loadchart2()
        Try
            ''CHART 2
            conn.Close()
            Chart2.Series.Clear()
            series3.Points.Clear()
            Dim totalsales As Decimal

            series2.ChartType = SeriesChartType.RangeColumn
            Chart2.Series.Add(series2)
            Dim chartArea2 As ChartArea = Chart2.ChartAreas(0)


            With Chart2
                .Series(0).Palette = ChartColorPalette.SemiTransparent
                .Series(0).BorderColor = Color.White
                .ChartAreas(0).Area3DStyle.Enable3D = True
                .Series(0).LabelFormat = "₱{#,##0}"
                .Series(0).LabelBackColor = Color.White
                .Series(0).LabelForeColor = Color.Black
                .Series(0).IsValueShownAsLabel = True

            End With

            Dim XAxis1 As Axis = Chart2.ChartAreas(0).AxisX
            Dim YAxis1 As Axis = Chart2.ChartAreas(0).AxisY
            XAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 8, FontStyle.Regular)
            YAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 11, FontStyle.Regular)
            ' XAxis1.Minimum = DateTime.Today.AddMonths().ToOADate
            XAxis1.Maximum = 12

            Dim table1 As New DataTable()
            Dim command1 As New MySqlCommand("SELECT * from dashboard", conn)
            Dim da1 As New MySqlDataAdapter
            da1.SelectCommand = command1
            table1.Clear()
            da1.Fill(table1)

            Dim month As String
            Dim profit As Integer

            For i = 0 To table1.Rows.Count - 1
                month = table1(i)(1)
                profit = table1(i)(2)
                series2.Points.AddXY(month, profit)
            Next
        Catch ex As Exception
            MessageBox.Show("LOADING CHART ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub months(selectedmonth As String)
        conn.Close()
        Chart2.Series.Clear()
        series3.Points.Clear()
        Chart2.Refresh()
        Chart2.ChartAreas(0).AxisX.Interval = 1
        Chart2.ChartAreas(0).AxisX.IntervalOffset = 0
        Chart2.ChartAreas(0).AxisX.Maximum = 3
        series3.ChartType = SeriesChartType.Column
        Chart2.Series.Add(series3)


        Dim reader, reader2 As MySqlDataReader
        Dim query, query2 As String
        Dim month As String
        Dim profit As Integer
        Dim expense As Integer


        Dim user_cmd As New MySqlCommand
        Dim user_stmt As String
        Dim usertotalcount As String
        conn.Open()
        user_stmt = "Select sum(sales_expenses) from sales_report"
        user_cmd = New MySqlCommand(user_stmt, conn)
        usertotalcount = user_cmd.ExecuteScalar()
        expense = usertotalcount
        conn.Close()

        query = "SELECT * from dashboard where month='" & selectedmonth & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            month = reader.GetString("month")
            profit = reader.GetString("sales_profit")
        End While
        series3.Points.AddXY("Monthly Revenue - " & month, profit)
        series3.Points.AddXY("Monthly Expense", expense)
        Dim XAxis1 As Axis = Chart2.ChartAreas(0).AxisX
        Dim YAxis1 As Axis = Chart2.ChartAreas(0).AxisY
        XAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 8, FontStyle.Regular)
        YAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 11, FontStyle.Regular)

        With Chart2
            .Series(0).Palette = ChartColorPalette.SemiTransparent
            .Series(0).BorderColor = Color.White
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LabelFormat = "₱{#,##0}"
            .Series(0).LabelBackColor = Color.White
            .Series(0).LabelForeColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
        End With


    End Sub




    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        Dim selectedmonth As String
        Chart2.Series.Clear()

        If cmbMonth.SelectedIndex = 0 Then
            Chart2.Series.Clear()
            selectedmonth = "January"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 1 Then
            Chart2.Series.Clear()
            selectedmonth = "February"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 2 Then
            selectedmonth = "March"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 3 Then
            selectedmonth = "April"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 4 Then
            selectedmonth = "May"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 5 Then
            selectedmonth = "June"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 6 Then
            selectedmonth = "July"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 7 Then
            selectedmonth = "August"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 8 Then
            selectedmonth = "September"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 9 Then
            selectedmonth = "October"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 10 Then
            selectedmonth = "November"
            months(selectedmonth)
        End If
        If cmbMonth.SelectedIndex = 11 Then
            selectedmonth = "December"
            months(selectedmonth)
        End If

        If cmbMonth.SelectedIndex = 12 Then
            loadchart2()
        End If

    End Sub


End Class