Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmCustomMenu
    Private Sub frmCustomMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Close()
        login()
        Dim name
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from customer where Customer_ID='" & customID & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        conn.Open()
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        Dim imgByte() As Byte
        adapter.Fill(table)
        imgByte = table(0)(13)
        Dim ms As New MemoryStream(imgByte)
        picCustom.Image = Image.FromStream(ms)
        'If table.Rows.Count = 1 Then


        'Else
        '    MessageBox.Show("No Data Found")
        'End If
        reader = cm.ExecuteReader
        While reader.Read
            name = reader.GetString("Customer_Username")
            lblName.Text = "Username:@" & name
        End While
    End Sub

    Sub login()
        Dim command As New MySqlCommand("INSERT INTO audit VALUES(@Audit_No,@Username,@Action_Type,@Action_Date,@Action_Time,@Role)", conn)
        With command
            Dim username
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from customer where Customer_ID='" & customID & "'"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            conn.Open()
            reader = cm.ExecuteReader
            While reader.Read
                username = reader.GetString("Customer_Username")
            End While
            conn.Close()

            .Parameters.Clear()
            .Parameters.AddWithValue("@Audit_No", 0)
            .Parameters.AddWithValue("@Username", username)
            .Parameters.AddWithValue("@Action_Type", "Logged-In")
            .Parameters.AddWithValue("@Action_Date", currdate)
            .Parameters.AddWithValue("@Action_Time", currtime)
            .Parameters.AddWithValue("@Role", "Customer")
            conn.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Audit record Inserted")
            Else
                MessageBox.Show("Audit record not Inserted")
            End If
            conn.Close()
        End With
    End Sub

    Sub logout()
        Dim command As New MySqlCommand("INSERT INTO audit VALUES(@Audit_No,@Username,@Action_Type,@Action_Date,@Action_Time,@Role)", conn)
        With command
            Dim username
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from customer where Customer_ID='" & customID & "'"
            Dim cm As New MySqlCommand
            cm = New MySqlCommand(query, conn)
            conn.Open()
            reader = cm.ExecuteReader
            While reader.Read
                username = reader.GetString("Customer_Username")
            End While
            conn.Close()

            .Parameters.Clear()
            .Parameters.AddWithValue("@Audit_No", 0)
            .Parameters.AddWithValue("@Username", username)
            .Parameters.AddWithValue("@Action_Type", "Logged-Out")
            .Parameters.AddWithValue("@Action_Date", currdate)
            .Parameters.AddWithValue("@Action_Time", currtime)
            .Parameters.AddWithValue("@Role", "Customer")
            conn.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Audit record Inserted")
            Else
                MessageBox.Show("Audit record not Inserted")
            End If
            conn.Close()
        End With

    End Sub

    Private Sub gunabtnLogOut_Click(sender As Object, e As EventArgs) Handles gunabtnLogOut.Click
        logout()

    End Sub

    Private Sub gunabtnShop_Click(sender As Object, e As EventArgs) Handles gunabtnShop.Click
        pnlForm.Controls.Clear()
        frmShop.TopLevel = False
        pnlForm.Controls.Add(frmShop)
        Me.Location = New Point(0, 24)

        frmShop.Show()

    End Sub

    Private Sub gunabtnAccount_Click(sender As Object, e As EventArgs) Handles gunabtnAccount.Click
        connect()

        pnlForm.Controls.Clear()
        frmCreate.TopLevel = False

        pnlForm.Controls.Add(frmCreate)
        Me.Location = New Point(0, 24)
        frmCreate.Location = New Point(150, 0)
        frmCreate.lblAction.Text = "UPDATE CUSTOMER ACCOUNT"
        frmCreate.loadrecord()

        frmCreate.Show()
    End Sub


    Private Sub gunabtnReview_Click(sender As Object, e As EventArgs) Handles gunabtnReview.Click

        pnlForm.Controls.Clear()
        frmReview.TopLevel = False

        pnlForm.Controls.Add(frmReview)
        Me.Location = New Point(0, 24)
        frmReview.Location = New Point(195, 60)
        frmReview.Show()

    End Sub
End Class


