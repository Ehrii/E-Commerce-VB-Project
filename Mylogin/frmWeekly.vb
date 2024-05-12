Imports Guna
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmWeekly
    Private Sub frmDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load '
        connect()
        lblDate.Text = "As of " & MonthName(Today.Month) & " " & DateTime.Today & " - " & DateTime.Today.AddDays(7)
        loadchart()

    End Sub


    Sub loadchart()
        Dim series1 As New Series()
        Chart1.Series.Clear()
        conn.Close()

        series1.ChartType = SeriesChartType.Column
        Chart1.Series.Add(series1)
        Dim chartArea As ChartArea = Chart1.ChartAreas(0)

        With Chart1
            .Series(0).Palette = ChartColorPalette.SemiTransparent
            .Series(0).BorderColor = Color.White
            .ChartAreas(0).Area3DStyle.Enable3D = False
            .Series(0).LabelFormat = "₱{#,##0}"
            .Series(0).LabelForeColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
        End With

        Dim XAxis As Axis = Chart1.ChartAreas(0).AxisX
        Dim YAxis As Axis = Chart1.ChartAreas(0).AxisY
        XAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        YAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        XAxis.Interval = 1
        XAxis.Minimum = DateTime.Today.AddDays(-2).ToOADate
        XAxis.Maximum = DateTime.Today.AddDays(7).ToOADate
        XAxis.IntervalType = DateTimeIntervalType.Days
        XAxis.LabelStyle.Format = "ddd " & " dd/MM/yy" 'set the format to display the day of the week abbreviated (e.g. "Mon", "Tue", etc.)


        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT sum(total), order_Date, status FROM orderdetails WHERE status=@status GROUP BY order_date ORDER BY order_date  limit 7", conn)
        command.Parameters.AddWithValue("@status", "Delivered")

        Dim da As New MySqlDataAdapter(command)
        table.Clear()
        da.Fill(table)
        Dim amt As Integer
        Dim orderDate As Date

        For i = 0 To table.Rows.Count - 1
            amt = table(i)(0)
            orderDate = CDate(table(i)(1))
            series1.Points.AddXY(orderDate, amt)
        Next
    End Sub


End Class