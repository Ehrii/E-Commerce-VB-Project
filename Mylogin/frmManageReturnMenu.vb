Imports System.Web.UI.WebControls.WebParts
Imports MySql.Data.MySqlClient

Public Class frmManageReturnMenu
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnApp.Click
        approved()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNotApp.Click
        notapproved()

    End Sub

    Sub approved()
        Try
            conn.Close()
            Dim command As New MySqlCommand("UPDATE returnprod set Return_Status = @Status WHERE Return_ID ='" & frmSalesReturn.DgvReturn.CurrentRow.Cells(0).Value & "'", conn)
            With command
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "Approved")
            End With
            conn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Product Return Approved", "ORDER RETURN MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmSalesReturn.loadrecord()

            Else
                MessageBox.Show("Record not Inserted")

            End If
        Catch ex As Exception
            MessageBox.Show("APPROVE ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub notapproved()
        conn.Close()
        Try
            Dim command As New MySqlCommand("UPDATE returnprod set Return_Status = @Status WHERE Return_ID ='" & frmSalesReturn.DgvReturn.CurrentRow.Cells(0).Value & "'", conn)
            With command
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "Not Approved")
            End With
            conn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Product Return Not Approved", "ORDER RETURN MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmSalesReturn.loadrecord()
            Else
                MessageBox.Show("Record Not Inserted")
            End If
        Catch ex As Exception
            MessageBox.Show("NOT APPROVED ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmManageReturnMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmSalesReturn.DgvReturn.CurrentRow.Cells(3).Value.ToString = "Returned" Then
            btnApp.Enabled = False
            btnNotApp.Enabled = False

        End If

        If frmSalesReturn.DgvReturn.CurrentRow.Cells(3).Value.ToString = "Not Approved" Then
            btnApp.Enabled = False
            btnNotApp.Enabled = False
        End If
    End Sub




End Class