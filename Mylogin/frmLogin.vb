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
        ' anima1.HideSync(p3)
        anima1.ShowSync(p2)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conn.ConnectionString = "server = localhost;user id=root; port = 3306;password=root;database=ecommercedb1"
        anima1.ShowSync(p2)
        txtPass.UseSystemPasswordChar = True
        txtID.Text = 123413
        txtPass.Text = "Eriel@874"
        connect()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim query, query2, query3 As String
        cmd = New MySqlCommand
        cmd.Connection = conn
        query = "Select*from Customer WHERE Customer_ID = '" & txtID.Text & "' AND Customer_Password= '" & txtPass.Text & "'"
        query2 = "Select*from Supplier WHERE Supplier_ID = '" & txtID.Text & "' AND Supplier_Password= '" & txtPass.Text & "'"
        query3 = "Select*from Admin WHERE Admin_ID='" & txtID.Text & "' AND Admin_Password='" & txtPass.Text & "'"

        Dim da = New MySqlDataAdapter(query, conn)
        Dim da2 = New MySqlDataAdapter(query2, conn)
        Dim da3 = New MySqlDataAdapter(query3, conn)
        Dim dt = New DataTable()
        Dim dt2 = New DataTable()
        Dim dt3 = New DataTable()


        If attemp = 0 Then
            MessageBox.Show("No more attempts left. Please contact the administrator", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Clear()
            txtPass.Clear()
            txtID.Enabled = False
            txtPass.Enabled = False
            Me.Hide()

        End If
        Try
            da.Fill(dt)
            da2.Fill(dt2)
            da3.Fill(dt3)
            If dt.Rows.Count <= 0 And dt2.Rows.Count <= 0 And dt3.Rows.Count <= 0 Then
                attemp -= 1
                MessageBox.Show("Account not found. Please try again You have " & attemp & " attempts left.", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf dt.Rows.Count > 0 Then
                MessageBox.Show("Log-In Successful..", "CUSTOMER DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                customID = txtID.Text
                frmShop.lblCustomId.Text = "Customer ID: " & customID
                frmCustomMenu.Show()

            ElseIf dt2.Rows.Count > 0 Then
                MessageBox.Show("Log-In Successful..", "SUPPLIER DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                supplierID = txtID.Text
                frmSupplier.Show()

            ElseIf dt3.Rows.Count > 0 Then
                MessageBox.Show("Log-In Successful..", "ADMIN DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                adminID = txtID.Text
                frmAdmin.Show()

            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conn.Close()



        'query = "Select*from Supplier WHERE Supplier_ID = '" & txtAdminID.Text & "' AND Supplier_Password= '" & txtAdminPass.Text & "'"
        'Dim da = New MySqlDataAdapter(query, conn)
        'Dim dt = New DataTable()
        'Try
        '    da.Fill(dt)
        '    If dt.Rows.Count <= 0 Then
        '        MessageBox.Show("Account not found. Please try again You have " & attemp & " attempts left.", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Else
        '        MessageBox.Show("Log-IN Successful..", "DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        'conn.Close()
        'End If


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

        'Dim query As String
        'cmd = New MySqlCommand
        'cmd.Connection = conn

        'attemp -= 1


        'If cmbRoles.SelectedItem = "Supplier" Then


        '    If attemp = 0 Then
        '    MessageBox.Show("No more attempts left. Please contact the administrator", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtAdminID.Clear()
        '    txtAdminPass.Clear()
        '    txtAdminID.Enabled = False
        '    txtAdminPass.Enabled = False
        'End If

        'If cmbRoles.SelectedItem = "Administrator" Then
        '    query = "Select*from admin WHERE Admin_ID = '" & txtAdminID.Text & "' AND Admin_Password= '" & txtAdminPass.Text & "'"
        '    Dim da = New MySqlDataAdapter(query, conn)
        '    Dim dt = New DataTable()
        '    Try
        '        da.Fill(dt)
        '        If dt.Rows.Count <= 0 Then
        '            MessageBox.Show("Account not found. Please try again You have " & attemp & " attempts left.", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Else
        '            MessageBox.Show("Log-IN Successful..", "DELAROTA Log-In Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show("ERROR: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        '    conn.Close()
        'End If

        If attemp = 0 Then
            MessageBox.Show("No more attempts left. Please contact the administrator", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Clear()
            txtPass.Clear()
            txtID.Enabled = False
            txtPass.Enabled = False
        End If
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)
        'If chkSecondPass.Checked = True Then
        '    txtAdminPass.UseSystemPasswordChar = False
        'Else
        '    txtAdminPass.UseSystemPasswordChar = True
        'End If
    End Sub


End Class