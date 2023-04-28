Imports MySql.Data.MySqlClient

Public Class frmAudit
    Private Sub frmAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        Dim table As New DataTable()
        Dim command As New MySqlCommand("Select Audit_No as'Audit No.', Username as 'Audit Username', Action_Type as'Action Type' , Action_Date as'Action Date', Action_Time as'Action Time', Role as'Role' from audit", conn)
        ' conn.Open()
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        table.Clear()
        da.Fill(table)
        DgvAudit.DataSource = table
        conn.Close()
    End Sub


    Private Sub DgvInventory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvAudit.CellMouseClick

        txtNo.Text = DgvAudit.CurrentRow.Cells(0).Value.ToString()
        txtUsername.Text = DgvAudit.CurrentRow.Cells(1).Value.ToString()
        txtAction.Text = DgvAudit.CurrentRow.Cells(2).Value.ToString()
        txtActionDate.Text = DgvAudit.CurrentRow.Cells(3).Value.ToString()
        txtTime.Text = DgvAudit.CurrentRow.Cells(4).Value.ToString()
        txtRole.Text = DgvAudit.CurrentRow.Cells(5).Value.ToString()
    End Sub


End Class