Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBurger As Double = 5.99
        Dim dblToppings As Double = 0.25
        Dim dblDrink As Double = 1.25
        Dim Total As Double
        If rdHamburger.Checked = True Then
            lblOrder.Text = "You selected Hamburger"
            Total = dblBurger + Total
        ElseIf rbCheeseburger.Checked = True Then
            lblOrder.Text = "You selected Cheese Burger"
            Total = dblBurger + Total
        ElseIf rbChicken.Checked = True Then
            lblOrder.Text = "You selected a Chicken Patty"
            Total = dblBurger + Total
        ElseIf rbTurkey.Checked = True Then
            lblOrder.Text = "You selected Turkey"
            Total = dblBurger + Total
        End If

        If chkTomato.Checked = True Then
            lblOrder2.Text &= ", and tomato"
            Total = dblToppings + Total
        End If
        If chkLettuce.Checked = True Then
            lblOrder2.Text &= ", and lettuce"
            Total = dblToppings + Total
        End If
        If chkMayo.Checked = True Then
            lblOrder2.Text &= ", and mayo"
            Total = dblToppings + Total
        End If
        If rbWater.Checked = True Then
            lblOrder3.Text = ", and water"
            Total = dblDrink + Total
        ElseIf rbPop.Checked = True Then
            lblOrder3.Text = ", and pop"
            Total = dblDrink + Total
        ElseIf rbTea.Checked = True Then
            lblOrder3.Text = ", and tea"
            Total = dblDrink + Total
        End If
        lblPrice.Text = Total.ToString("c")

    End Sub
End Class
