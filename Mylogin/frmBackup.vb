Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.Diagnostics
Imports System.Windows

Public Class frmBackup
    Public lastbackup As DateTime
    Public lastrestore As DateTime




    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Try
            loadDate()
            loadtable()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try



    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        conn.Close()
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\BACKUP"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = backup.FileName

            Try
                Dim con As MySqlConnection = New MySqlConnection("Server=localhost;user id=root;port=3306;password=root;database=ecommercedb1;charset=utf8")
                Dim cmd As MySqlCommand = New MySqlCommand
                cmd.Connection = con
                con.Open()
                Dim mb As MySqlBackup = New MySqlBackup(cmd)
                mb.ExportToFile(backup.FileName)
                con.Close()
                MessageBox.Show("Database backup saved successfully.", "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lastbackup = currdatetime
                lblDate.Text = lastbackup

                ''INSERT RECORDS DATABASE HISTORY
                Dim command As New MySqlCommand("INSERT INTO backup (Backup_ID,Backup_Date,Path,Action_Type)  
                VALUES(@Backup_ID, @Backup_Date, @Path,@ActionType)", conn)
                conn.Open()

                With command
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Backup_ID", 0)
                    .Parameters.AddWithValue("@Backup_Date", currdatetime)
                    .Parameters.AddWithValue("@Path", filePath)
                    .Parameters.AddWithValue("@ActionType", "Backup")

                End With
                command.ExecuteNonQuery()
                loadtable()

                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error occurred while exporting database backup: " & ex.Message, "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf backup.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Close()

        Dim restore As New OpenFileDialog
        restore.InitialDirectory = "C:\BACKUP"
        restore.Title = "Database Restore"
        restore.CheckFileExists = True
        restore.CheckPathExists = True
        restore.DefaultExt = "sql"
        restore.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        restore.RestoreDirectory = True

        If restore.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = restore.FileName
            Try
                Dim con2 As MySqlConnection = New MySqlConnection("Server=localhost;user id=root;port=3306;password=root;database=ecommercedb1;charset=utf8")
                Dim cmd2 As MySqlCommand = New MySqlCommand
                cmd.Connection = con2
                con2.Open()
                Dim mb2 As MySqlBackup = New MySqlBackup(cmd)
                mb2.ImportFromFile(restore.FileName)
                con2.Close()
                MessageBox.Show("Database restore completed successfully.", "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lastrestore = currdatetime
                lblDate2.Text = lastrestore

                ''INSERT RECORDS DATABASE HISTORY
                Dim command2 As New MySqlCommand("INSERT INTO backup (Backup_ID,Backup_Date,Path,Action_Type)  
                VALUES(@Backup_ID, @Backup_Date, @Path,@ActionType)", conn)
                conn.Open()

                With command2
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Backup_ID", 0)
                    .Parameters.AddWithValue("@Backup_Date", lastrestore)
                    .Parameters.AddWithValue("@Path", filePath)
                    .Parameters.AddWithValue("@ActionType", "Restore")

                End With
                command2.ExecuteNonQuery()
                loadtable()

                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error occurred while importing database backup: " & ex.Message, "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf restore.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

    End Sub


    Sub loadtable()
        Dim cm As New MySqlCommand
        DgvBackup.Rows.Clear()
        conn.Close()
        conn.Open()
        cm = New MySqlCommand("Select * from backup", conn)
        dr = cm.ExecuteReader
        While dr.Read
            DgvBackup.Rows.Add(dr.Item("Backup_ID").ToString, dr.Item("Backup_Date"), dr.Item("Path").ToString, dr.Item("Action_Type").ToString)
        End While
        dr.Close()
        conn.Close()
        For i = 0 To DgvBackup.Rows.Count - 1
            Dim r As DataGridViewRow = DgvBackup.Rows(i)
            r.Height = 60
        Next
    End Sub
    Sub loadDate()
        Dim lastdate As DateTime
        Dim action As String = "Backup"
        Dim query As String
        Dim reader As MySqlDataReader
        query = "select * from backup where Action_Type='" & action & "'"
        Dim cm As New MySqlCommand
        cm = New MySqlCommand(query, conn)
        reader = cm.ExecuteReader
        While reader.Read
            lastdate = reader.GetString("backup_Date")
            lblDate.Text = lastdate
        End While
        conn.Close()

        Dim lastdate2 As DateTime
        Dim action2 As String = "Restore"
        Dim query2 As String
        Dim reader2 As MySqlDataReader
        query2 = "select * from backup where Action_Type='" & action2 & "'"
        Dim cm2 As New MySqlCommand
        conn.Open()
        cm2 = New MySqlCommand(query2, conn)
        reader2 = cm2.ExecuteReader
        While reader2.Read
            lastdate2 = reader2.GetString("backup_Date")
            lblDate2.Text = lastdate2
        End While
        conn.Close()


    End Sub

    Private Sub DgvBackup_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBackup.CellContentClick
        Dim colName As String = DgvBackup.Columns(e.ColumnIndex).Name

        If colName = "Directory" Then
            Dim directoryPath As String = "C:\BACKUP"
            Process.Start("explorer.exe", directoryPath)
        End If

    End Sub
End Class