Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If txtInteger.Text = "1" Then
            lblRomanNumeral.Text = "I"
        End If
        If txtInteger.Text = "2" Then
            lblRomanNumeral.Text = "II"
        End If
        If txtInteger.Text = "3" Then
            lblRomanNumeral.Text = "III"
        End If
        If txtInteger.Text = "4" Then
            lblRomanNumeral.Text = "IV"
        End If
        If txtInteger.Text = "5" Then
            lblRomanNumeral.Text = "V"
        End If
        If txtInteger.Text = "6" Then
            lblRomanNumeral.Text = "VI"
        End If
        If txtInteger.Text = "7" Then
            lblRomanNumeral.Text = "VII"
        End If
        If txtInteger.Text = "8" Then
            lblRomanNumeral.Text = "VIII"
        End If
        If txtInteger.Text = "9" Then
            lblRomanNumeral.Text = "IX"
        End If
        If txtInteger.Text = "10" Then
            lblRomanNumeral.Text = "X"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblRomanNumeral.Text = ""
        txtInteger.Text = ""
    End Sub
End Class
