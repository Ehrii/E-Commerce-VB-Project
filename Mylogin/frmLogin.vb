Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Public attemp As Integer = 3
    Private Sub linkaccnt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaccnt.LinkClicked
        frmPassword.Show()
    End Sub
    Private Sub btnx_Click(sender As Object, e As EventArgs)
        anima1.ShowSync(p2)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anima1.ShowSync(p2)
        txtPass.UseSystemPasswordChar = True
        'txtID.Text = 123413
        'txtPass.Text = "Valor@871"
        connect()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        login()


    End Sub
    Sub login()
        Dim query, query2, query3 As String
        cmd = New MySqlCommand
        cmd.Connection = conn
        query = "Select*from Customer where Email = '" & txtEmail.Text & "'"
        query2 = "Select*from Supplier where Email = '" & txtEmail.Text & "'"
        query3 = "Select*from Admin where Admin_Email='" & txtEmail.Text & "'"

        Dim da = New MySqlDataAdapter(query, conn)
        Dim da2 = New MySqlDataAdapter(query2, conn)
        Dim da3 = New MySqlDataAdapter(query3, conn)
        Dim dt = New DataTable()
        Dim dt2 = New DataTable()
        Dim dt3 = New DataTable()
        If attemp = 0 Then
            MessageBox.Show("No more attempts left. Please contact the administrator", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Clear()
            txtPass.Clear()
            txtEmail.Enabled = False
            txtPass.Enabled = False
            Exit Sub
        End If

        Try
            da.Fill(dt)
            da2.Fill(dt2)
            da3.Fill(dt3)
            Dim pass As String

            If dt.Rows.Count <= 0 And dt2.Rows.Count <= 0 And dt3.Rows.Count <= 0 Then
                attemp -= 1
                MessageBox.Show("Account not found. Please try again You have " & attemp & " attempts left.", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf dt.Rows.Count > 0 Then
                pass = dt(0)(4)

                If txtPass.Text <> pass Then
                    attemp -= 1
                    MessageBox.Show("Account not found. Please try again You have " & attemp & " attempts left.", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                MessageBox.Show("Log-In Successful..", "CUSTOMER DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                customID = dt(0)(0)
                frmShop.lblCustomId.Text = "Customer ID: " & customID
                frmCustomMenu.Show()

            ElseIf dt2.Rows.Count > 0 Then
                pass = dt2(0)(4)

                If txtPass.Text <> pass Then
                    attemp -= 1
                    MessageBox.Show("Account not found. Please try again You have " & attemp & " attempts left.", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                MessageBox.Show("Log-In Successful..", "SUPPLIER DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                supplierID = dt2(0)(0)
                frmSupplier.Show()

            ElseIf dt3.Rows.Count > 0 Then
                pass = dt3(0)(5)

                If txtPass.Text <> pass Then
                    attemp -= 1
                    MessageBox.Show("Account not found. Please try again You have " & attemp & " attempts left.", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                MessageBox.Show("Log-In Successful..", "ADMIN DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                adminID = dt3(0)(0)
                frmAdmin.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conn.Close()

    End Sub



    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        frmCreate.Show()
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        If chkPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)
        If attemp = 0 Then
            MessageBox.Show("No more attempts left. Please contact the administrator", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Clear()
            txtPass.Clear()
            txtEmail.Enabled = False
            txtPass.Enabled = False
            Exit Sub
        End If
    End Sub

End Class