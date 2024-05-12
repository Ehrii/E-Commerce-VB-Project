Imports DevComponents.DotNetBar
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI
Imports System.IO
Imports System.Text
Imports System.Web.UI.Design
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSalesReport

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim status As String = "Delivered"

        Dim table As New DataTable()
        Dim command As New MySqlCommand("select Report_ID as'Report ID', Product_ID as'Product ID', Product_Name as'Product Name', Sales_Volume as'Sales Volume', Sales_Amount as 'Sales Amount', Sales_Expenses as 'Sales Expenses', Sales_Profit as 'Sales Profit' from sales_report", conn)

        DgvSales.RowTemplate.Height = 70

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvSales.DataSource = table
        conn.Close()

        Dim totalSales As Integer
        Dim totalExp As Integer
        Dim totalProf As Integer


        If totalSales Or totalExp Or totalProf = 0 Then
            totalSales = 0.00
            totalExp = 0.00
            totalProf = 0.00
        Else
            For i = 0 To DgvSales.Rows.Count - 1
                totalSales += DgvSales.Rows(i).Cells(4).Value
                totalExp += DgvSales.Rows(i).Cells(5).Value
                totalProf += DgvSales.Rows(i).Cells(6).Value
            Next
            Chart1.Visible = False
            Chart2.Visible = False
        End If


    End Sub




    Sub loadchart(Salesamt As Integer, expenses As Integer, profit As Integer)

        Dim series1 As New Series()
        series1.ChartType = SeriesChartType.Doughnut

        series1.Points.AddXY("Sales Amount", Salesamt)
        series1.Points.AddXY("Sales Expenses", expenses)
        series1.Points.AddXY("Sales Profit", profit)

        Chart1.Series.Add(series1)

        series1.Name = "SALES"

        With Chart1
            .Series(0)("PieLabelStyle") = "outside"

            .Series(0).BorderWidth = 1
            .Series(0).BorderColor = Color.White
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LabelFormat = "₱{#,##0}"
            .Series(0).LabelForeColor = Color.White
            .Series(0).IsValueShownAsLabel = True
            .Series(0).LegendText = "#VALX (#PERCENT)"
        End With

        Dim series2 As New Series()
        series2.ChartType = SeriesChartType.RangeColumn
        series2.Points.AddXY("Sales Amount", Salesamt)
        series2.Points.AddXY("Sales Expenses", expenses)
        series2.Points.AddXY("Sales Profit", profit)
        Chart2.Series.Add(series2)


        Dim XAxis As Axis = Chart2.ChartAreas(0).AxisX
        Dim YAxis As Axis = Chart2.ChartAreas(0).AxisY
        ' XAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        ' YAxis.LabelStyle.Font = New Font("Tw Cen Mt", 10, FontStyle.Regular)
        With Chart2
            .Series(0)("PieLabelStyle") = "outside"
            .Series(0).BorderWidth = 1
            .Series(0).BorderColor = Color.White
            .Series(0).LabelFormat = "{#,##0}"
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(0).LabelForeColor = Color.Black
            .Series(0).IsValueShownAsLabel = True
        End With

    End Sub

    Private Sub DgvSales_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvSales.CellMouseClick
        conn.Close()
        Chart1.Visible = True
        Chart2.Visible = True
        Chart1.Series.Clear()
        Chart2.Series.Clear()
        lblSales.Text = FormatNumber(DgvSales.CurrentRow.Cells(4).Value, 2)
        lblExpenses.Text = FormatNumber(DgvSales.CurrentRow.Cells(5).Value, 2)
        lblIncome.Text = FormatNumber(DgvSales.CurrentRow.Cells(6).Value, 2)

        Dim salesamt, expenses, profit As Integer
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from sales_report where product_id='" & DgvSales.CurrentRow.Cells(1).Value & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        reader = cm.ExecuteReader
        While reader.Read
            salesamt = reader("Sales_Amount")
            expenses = reader("Sales_Expenses")
            profit = reader("Sales_Profit")

            If salesamt > expenses Then
                If salesamt > profit Then
                    Chart2.ChartAreas(0).AxisY.Maximum = salesamt
                Else
                    Chart2.ChartAreas(0).AxisY.Maximum = profit
                End If
            Else
                If expenses > profit Then
                    Chart2.ChartAreas(0).AxisY.Maximum = expenses
                Else
                    Chart2.ChartAreas(0).AxisY.Maximum = profit
                End If
            End If

            loadchart(salesamt, expenses, profit)
        End While
        conn.Close()

        'txtSales.Text = DgvSales.CurrentRow.Cells(0).Value.ToString()
        'txtVolume.Text = DgvSales.CurrentRow.Cells(1).Value.ToString()
        'txtStatus.Text = DgvSales.CurrentRow.Cells(2).Value.ToString()
        'txtCustomer.Text = DgvSales.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.FileName = "export-csv"
            sfd.Filter = "CSV File | *.csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Using sw As StreamWriter = New StreamWriter(sfd.FileName, False, Encoding.UTF8)
                    ' Write the column names to the CSV file
                    Dim dgvColumnNames As List(Of String) = DgvSales.Columns.
                        Cast(Of DataGridViewColumn).ToList().
                       Select(Function(c) c.Name).ToList()
                    sw.WriteLine(String.Join(",", dgvColumnNames))

                    ' Write the data rows to the CSV file
                    For Each row As DataGridViewRow In DgvSales.Rows
                        Dim rowdata As New List(Of String)
                        For Each column As DataGridViewColumn In DgvSales.Columns
                            Dim cellValue = row.Cells(column.Name).Value
                            If TypeOf cellValue Is System.Byte Then
                                ' Replace System.Byte values with an empty string
                                rowdata.Add("")
                            Else
                                rowdata.Add(Convert.ToString(cellValue))
                            End If
                        Next
                        sw.WriteLine(String.Join(",", rowdata))
                    Next

                    ' Close the StreamWriter and release the file lock
                    sw.Close()

                    ' Open the exported file
                    Process.Start(sfd.FileName)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("CSV ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
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
                    Dim table As New PdfPTable(DgvSales.ColumnCount)
                    For Each column As DataGridViewColumn In DgvSales.Columns
                        table.AddCell(column.HeaderText)
                    Next
                    table.HeaderRows = 1

                    For Each row As DataGridViewRow In DgvSales.Rows
                        For Each cell As DataGridViewCell In row.Cells
                            If cell.Value IsNot Nothing Then
                                table.AddCell(cell.Value.ToString())
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

        Catch ex As Exception
            MessageBox.Show("PDF ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmWeekly.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmMonthly.Show()

    End Sub
End Class