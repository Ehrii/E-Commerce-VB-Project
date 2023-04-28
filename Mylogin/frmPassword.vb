Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmPassword
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text Is Nothing And txtPass.Text Is Nothing And txtConfirmPass.Text Is Nothing Then
            MessageBox.Show("Please fill-up the following details!", "Invalid Log-in attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If txtPass.Text <> txtConfirmPass.Text Then
            MessageBox.Show("Passwords do not match!. Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If ValidatePassword(txtConfirmPass.Text) = False Then
            MessageBox.Show("Invalid Password!. Please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Dim prodId As New Integer
        Dim ms As New MemoryStream
        Dim cm As New MySqlCommand
        cm = New MySqlCommand("UPDATE customer SET Customer_Password=@Password WHERE Email = @Email", conn)


        With cm
            .Parameters.Clear()
            .Parameters.AddWithValue("@Password", txtConfirmPass.Text)
            .Parameters.AddWithValue("@Email", txtEmail.Text)
        End With

        If cm.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Record Updated")
            frmManage.loadRecord()
        Else
            MessageBox.Show("Wrong Email, Please enter a valid one...")
        End If
        conn.Close()

        Me.Hide()

    End Sub


    Private Function ValidatePassword(password As String) As Boolean
        Dim minimum = 8

        If (Not password.Length >= minimum) Then
            Return False
        End If

        Dim hasNum = False
        Dim hasCap = False
        Dim hasLow = False
        Dim hasSpe = False
        Dim currentCharacter As Char

        For i As Integer = 0 To password.Length - 1
            currentCharacter = password.Chars(i)

            If (Char.IsWhiteSpace(currentCharacter)) Then
                Return False
            End If
            If (Integer.TryParse(currentCharacter, 0)) Then
                hasNum = True
            ElseIf (Char.IsUpper(currentCharacter)) Then
                hasCap = True
            ElseIf (Char.IsLower(currentCharacter)) Then
                hasLow = True
            Else
                hasSpe = True
            End If
        Next

        Return hasNum And hasCap And hasLow And hasSpe
    End Function

    Private Sub chkPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        If chkPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
            txtConfirmPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
            txtConfirmPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub
End Class