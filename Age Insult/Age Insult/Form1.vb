Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Double

        Try
            intAge = txtUserAgeInput.Text

            If intAge < 10 Then
                lblResult.Text = "You're still a fetus."
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how niave you are."
            ElseIf intAge >= 14 And intAge < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            End If
            '18 to 24, 24 to 30, 30 to 40, 40 to 60, and 60 up
        Catch ex As Exception
            lblMessage.Text = "Enter a numeric value."

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
        lblMessage.Text = ""
        txtUserAgeInput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
