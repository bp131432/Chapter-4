Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strUsername As String

        strUsername = txtPassword.Text
        If strUsername = "Poston" Then
            MessageBox.Show("Congrats")
        Else
            MessageBox.Show("Whoops")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
