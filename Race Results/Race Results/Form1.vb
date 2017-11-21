Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Runner1Time, Runner2Time, Runner3Time As Double
        Runner1Time = txtTime1.Text
        Runner2Time = txtTime2.Text
        Runner3Time = txtTime3.Text

        If Runner1Time < Runner2Time And Runner1Time < Runner3Time Then
            lbl1stPlace.Text = txtRunner1.Text
            If Runner2Time < Runner3Time Then
                lbl2ndPlace.Text = txtRunner2.Text
                lbl3rdPlace.Text = txtRunner3.Text
            ElseIf Runner3Time < Runner2Time Then
                lbl2ndPlace.Text = txtRunner3.Text
                lbl3rdPlace.Text = txtRunner2.Text
            End If
        End If

        If Runner2Time < Runner1Time And Runner2Time < Runner3Time Then
            lbl1stPlace.Text = txtRunner2.Text
            If Runner1Time < Runner3Time Then
                lbl2ndPlace.Text = txtRunner1.Text
                lbl3rdPlace.Text = txtRunner3.Text
            ElseIf Runner3Time < Runner1Time Then
                lbl2ndPlace.Text = Runner3Time
                lbl3rdPlace.Text = Runner1Time
            End If
        End If

        If Runner3Time < Runner1Time And Runner3Time < Runner2Time Then
            lbl1stPlace.Text = txtRunner3.Text
            If Runner1Time < Runner2Time Then
                lbl2ndPlace.Text = txtRunner1.Text
                lbl3rdPlace.Text = txtRunner2.Text
            ElseIf Runner2Time < Runner1Time Then
                lbl2ndPlace.Text = txtRunner2.Text
                lbl3rdPlace.Text = txtRunner1.Text
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRunner1.Text = ""
        txtRunner2.Text = ""
        txtRunner3.Text = ""
        txtTime1.Text = ""
        txtTime2.Text = ""
        txtTime3.Text = ""
        lbl1stPlace.Text = ""
        lbl2ndPlace.Text = ""
        lbl3rdPlace.Text = ""
    End Sub
End Class
