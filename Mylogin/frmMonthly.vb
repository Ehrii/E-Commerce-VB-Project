Imports Guna
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMonthly
    Public series1 As New Series()

    Private Sub frmMonthly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        lblDate.Text = "Current Month: " & MonthName(Today.Month)
        loadchart()
    End Sub




    Sub loadchart()
        ''CHART 2
        ' conn.Close()
        Chart1.Series.Clear()
        series1.Points.Clear()
        Dim totalsales As Decimal

        series1.ChartType = SeriesChartType.RangeColumn
        Chart1.Series.Add(series1)
        Dim chartArea2 As ChartArea = Chart1.ChartAreas(0)


        With Chart1
            .Series(0).Palette = ChartColorPalette.SemiTransparent
            .Series(0).BorderColor = Color.White
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LabelFormat = "₱{#,##0}"
            .Series(0).LabelBackColor = Color.White
            .Series(0).LabelForeColor = Color.Black
            .Series(0).IsValueShownAsLabel = True

        End With

        Dim XAxis1 As Axis = Chart1.ChartAreas(0).AxisX
        Dim YAxis1 As Axis = Chart1.ChartAreas(0).AxisY
        XAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 8, FontStyle.Regular)
        YAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 11, FontStyle.Regular)
        ' XAxis1.Minimum = DateTime.Today.AddMonths().ToOADate
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.IntervalOffset = 0
        Chart1.ChartAreas(0).AxisX.Maximum = 12
        Dim table1 As New DataTable()
        Dim command1 As New MySqlCommand("SELECT month,sales_profit from dashboard ", conn)
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = command1
        table1.Clear()
        da1.Fill(table1)

        Dim month As String
        Dim profit As Integer

        For i = 0 To table1.Rows.Count - 1
            month = table1(i)(0)
            profit = table1(i)(1)
            series1.Points.AddXY(month, profit)
        Next
    End Sub

    Sub months(selectedmonth As String)
        conn.Close()
        Chart1.Series.Clear()
        series1.Points.Clear()
        Chart1.Refresh()
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.IntervalOffset = 0
        Chart1.ChartAreas(0).AxisX.Maximum = 3
        series1.ChartType = SeriesChartType.Column
        Chart1.Series.Add(series1)


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
        series1.Points.AddXY("Monthly Revenue - " & month, profit)
        series1.Points.AddXY("Monthly Expense", expense)
        Dim XAxis1 As Axis = Chart1.ChartAreas(0).AxisX
        Dim YAxis1 As Axis = Chart1.ChartAreas(0).AxisY
        XAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 8, FontStyle.Regular)
        YAxis1.LabelStyle.Font = New Font("Tw Cen Mt", 11, FontStyle.Regular)

        With Chart1
            .Series(0).Palette = ChartColorPalette.SemiTransparent
            .Series(0).BorderColor = Color.White
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LabelFormat = "₱{#,##0}"
            .Series(0).LabelBackColor = Color.White
            .Series(0).LabelForeColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
        End With


    End Sub

End Class