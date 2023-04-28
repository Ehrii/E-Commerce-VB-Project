Imports MySql.Data.MySqlClient

Public Class frmSalesReport

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim status As String = "Delivered"

        Dim table As New DataTable()
        Dim command As New MySqlCommand("select total as'Sales Amount', qty as'Sales Volume', status as'Sales Status', Order_Date as'Order Date' from orderdetails where status like '%" & status & "%'", conn)
        ' conn.Open()'
        'command.Parameters.Add("@Status", MySqlDbType.DateTime).Value = status
        DgvSales.RowTemplate.Height = 70

        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvSales.DataSource = table
        conn.Close()

        Dim sum As Decimal = 0
        For i = 0 To DgvSales.Rows.Count - 1
            sum += DgvSales.Rows(i).Cells(0).Value
        Next
        lblSales.Text = sum

    End Sub



    Private Sub DgvSales_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvSales.CellMouseClick

        txtSales.Text = DgvSales.CurrentRow.Cells(0).Value.ToString()
        txtVolume.Text = DgvSales.CurrentRow.Cells(1).Value.ToString()
        txtStatus.Text = DgvSales.CurrentRow.Cells(2).Value.ToString()
        txtCustomer.Text = DgvSales.CurrentRow.Cells(3).Value.ToString()
    End Sub
End Class