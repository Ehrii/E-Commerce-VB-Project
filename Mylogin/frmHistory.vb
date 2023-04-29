Imports MySql.Data.MySqlClient

Public Class frmHistory
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrecord()
    End Sub



    Sub loadrecord()
        conn.Close()

        Dim cm As New MySqlCommand
        DgvHistory.Rows.Clear()
        'conn.Open()'
        cm = New MySqlCommand("Select * from orderdetails where Customer_ID='" & customID & "'", conn)
        conn.Open()

        dr = cm.ExecuteReader
        While dr.Read
            DgvHistory.Rows.Add(dr.Item("Order_ID").ToString, dr.Item("Order_Date"), dr.Item("Total").ToString, dr.Item("Qty").ToString, dr.Item("Status").ToString, dr.Item("Customer_ID").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvHistory.Rows.Count - 1
            Dim r As DataGridViewRow = DgvHistory.Rows(i)
            r.Height = 70
        Next
        conn.Close()
    End Sub

    Private Sub cmbCateg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCateg.SelectedIndexChanged
        connect()

        DgvHistory.Rows.Clear()
        Dim cm As New MySqlCommand
        If cmbCateg.Text = "All" Then
            cm = New MySqlCommand("Select * from orderdetails", conn)
        Else
            cm = New MySqlCommand("Select * from orderdetails where Status like '%" & cmbCateg.Text & "%'", conn)
        End If


        dr = cm.ExecuteReader
        While dr.Read
            DgvHistory.Rows.Add(dr.Item("Order_ID").ToString, dr.Item("Order_Date"), dr.Item("Total").ToString, dr.Item("Qty").ToString, dr.Item("Status").ToString, dr.Item("Customer_ID").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvHistory.Rows.Count - 1
            Dim r As DataGridViewRow = DgvHistory.Rows(i)
            r.Height = 70
        Next
        conn.Close()
    End Sub
End Class