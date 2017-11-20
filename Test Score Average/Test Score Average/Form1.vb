Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Average As Double
        Dim dblScore1 As Double
        Dim dblScore2 As Double
        Dim dblScore3 As Double

        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0

        dblScore1 = CDbl(txtTestScore1.Text)
        dblScore2 = CDbl(txtTestScore2.Text)
        dblScore3 = CDbl(txtTestScore3.Text)
        Average = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

        lblAverage.Text = Average.ToString("n2")

        If Average > dblHIGH_SCORE Then
            lblMessage.Text = "Congrats!!! :)"
        Else
            lblMessage.Text = "Keep trying."
        End If

        If Average < 60 Then
            lblGrade.Text = ("F")
        ElseIf Average < 70 Then
            lblGrade.Text = ("D")
        ElseIf Average < 80 Then
            lblGrade.Text = ("C")
        ElseIf Average < 90 Then
            lblGrade.Text = ("B")
        ElseIf Average < 100 Then
            lblGrade.Text = ("A")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Text = ""
        txtTestScore2.Text = ""
        txtTestScore3.Text = ""

        lblAverage.Text = ""
        lblGrade.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
