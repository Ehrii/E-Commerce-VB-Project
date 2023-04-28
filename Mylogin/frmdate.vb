Public Class frmdate
    Private Sub frmdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Label1.Text = DateAndTime.Year(currdate)


        Label2.Text = DateAndTime.TimeOfDay



    End Sub
End Class