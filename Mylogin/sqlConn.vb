Imports MySql.Data.MySqlClient
Module sqlConn


    Public conn As MySqlConnection
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String
    Public customID, supplierID, adminID As Integer
    Public shippingFee As Decimal
    Public currdatetime As Date = DateAndTime.Now
    Public currdate As Date = DateAndTime.Today
    Public currtime As String = TimeOfDay.ToShortTimeString
    Public orderID As Integer
    Public Sub connect()

        Try
            conn = New MySqlConnection("server = localhost;user id=root; port = 3306;password=root;database=ecommercedb1")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




End Module




'cmd.CommandText = sql
'cmd.CommandType = CommandType.Text
'cmd.Connection = conn
'conn.Open()

'dr = cmd.ExecuteReader