Public Class Form1
    Dim value1 As String
    Dim value2 As String
    Dim value3 As String
    Dim operation As Char
    Dim firstNumber As Double
    Dim secondNumber As Double
    Dim thirdNumber As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(7)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(8)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(4)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(1)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(5)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(2)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        'The following if statement onsures that there isn't a zero before the number (a fix to this following issue: 02 + 2 = 04)
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(9)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(6)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If (TextBox1.Text.Equals("0")) Then
            TextBox1.Clear()
        End If
        TextBox1.AppendText(3)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_0.Click

        TextBox1.AppendText(0)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn_dot.Click
        TextBox1.AppendText(".")
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        TextBox1.Clear()
        TextBox1.Text = "0"
        TextBox2.Clear()
        value1 = ""
        value3 = ""
        value2 = ""
    End Sub

    Private Sub btn_subtract_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click
        value1 = TextBox1.Text
        value2 = "-"
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()

    End Sub

    Private Sub btn_sum_Click(sender As Object, e As EventArgs) Handles btn_sum.Click
        value1 = TextBox1.Text
        value2 = "+"
        'The entire operation will be displayed in textbox2 when the "=" button is clicked
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()
    End Sub

    Private Sub btn_multip_Click(sender As Object, e As EventArgs) Handles btn_multip.Click
        value1 = TextBox1.Text
        value2 = "x"
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        value1 = TextBox1.Text
        value2 = "/"
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(value2 + " ")
        TextBox1.Clear()
    End Sub

    Private Sub btn_result_Click(sender As Object, e As EventArgs) Handles btn_result.Click
        value3 = TextBox1.Text
        operation = value2
        firstNumber = Convert.ToDouble(value1)
        If (TextBox1.Text.Equals("")) Then
            secondNumber = firstNumber

        Else
            secondNumber = Convert.ToDouble(value3)
        End If


        Select Case (operation)
            Case "+"
                thirdNumber = firstNumber + secondNumber
            Case "-"
                thirdNumber = firstNumber - secondNumber
            Case "/"
                thirdNumber = firstNumber / secondNumber
            Case "x"
                thirdNumber = firstNumber * secondNumber
        End Select
        TextBox1.Text = Convert.ToString(thirdNumber)

        TextBox2.Clear()
        TextBox2.AppendText(value1 + " ")
        TextBox2.AppendText(operation + " ")
        TextBox2.AppendText(value3 + " ")
        TextBox2.AppendText("=")

    End Sub
End Class