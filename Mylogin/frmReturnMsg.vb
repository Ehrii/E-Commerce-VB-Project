Imports MySql.Data.MySqlClient

Public Class frmReturnMsg
    Private Sub frmReturnMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cm As New MySqlCommand
        connect()
        lblDate.Text = DateAndTime.Today & DateAndTime.TimeOfDay
        customID = 123413
        DgvReturn.Rows.Clear()
        cm = New MySqlCommand("Select * from returnprod where Customer_ID ='" & customID & "' AND Return_Status=@Return", conn)
        cm.Parameters.AddWithValue("@Return", "Returned")
        dr = cm.ExecuteReader
        While dr.Read
            DgvReturn.Rows.Add(dr.Item("Order_ID").ToString, dr.Item("Product_ID"), dr.Item("Return_Amount").ToString)
        End While
        dr.Close()
        conn.Close()

        For i = 0 To DgvReturn.Rows.Count - 1
            Dim r As DataGridViewRow = DgvReturn.Rows(i)
            r.Height = 40

        Next



    End Sub
End Class