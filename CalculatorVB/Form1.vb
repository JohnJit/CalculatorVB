Public Class frmCalc

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text = txtDisplay.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text = txtDisplay.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text = txtDisplay.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text = txtDisplay.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text = txtDisplay.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text = txtDisplay.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text = txtDisplay.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text = txtDisplay.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text = txtDisplay.Text + "9"
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtDisplay.Text = txtDisplay.Text + "0"
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        txtDisplay.Text = txtDisplay.Text + "."
    End Sub

    'Declaring Value
    Dim num1 As Double
    Dim num2 As Double
    Dim Answer As Double
    Dim optr As Char

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        num1 = Convert.ToDecimal(txtDisplay.Text)
        optr = "+"
        txtDisplay.Clear()
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        num1 = Convert.ToDecimal(txtDisplay.Text)
        optr = "-"
        txtDisplay.Clear()
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        num1 = Convert.ToDecimal(txtDisplay.Text)
        optr = "*"
        txtDisplay.Clear()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        num1 = Convert.ToDecimal(txtDisplay.Text)
        optr = "/"
        txtDisplay.Clear()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        num2 = Convert.ToDecimal(txtDisplay.Text)

        If optr = "+" Then
            Answer = num1 + num2
        ElseIf optr = "-" Then
            Answer = num1 + num2
        ElseIf optr = "*" Then
            Answer = num1 * num2
        ElseIf optr = "/" Then
            Answer = num1 / num2
        End If

        txtDisplay.Text = Convert.ToString(Answer)
    End Sub


End Class
