Public Class Calculator

    Dim strOperators As String = " "
    Dim intFristNumber As Double
    Dim intLastNumber As Double


    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_num1_Click(sender As Object, e As EventArgs) Handles Btn_num1.Click
        Screen.Text += "1"
    End Sub

    Private Sub Btn_num2_Click(sender As Object, e As EventArgs) Handles Btn_num2.Click
        Screen.Text += "2"
    End Sub

    Private Sub Btn_num3_Click(sender As Object, e As EventArgs) Handles Btn_num3.Click
        Screen.Text += "3"
    End Sub

    Private Sub Btn_num4_Click(sender As Object, e As EventArgs) Handles Btn_num4.Click
        Screen.Text += "4"
    End Sub

    Private Sub Btn_num5_Click(sender As Object, e As EventArgs) Handles Btn_num5.Click
        Screen.Text += "5"
    End Sub

    Private Sub Btn_num6_Click(sender As Object, e As EventArgs) Handles Btn_num6.Click
        Screen.Text += "6"
    End Sub

    Private Sub Btn_num7_Click(sender As Object, e As EventArgs) Handles Btn_num7.Click
        Screen.Text += "7"
    End Sub

    Private Sub Btn_num8_Click(sender As Object, e As EventArgs) Handles Btn_num8.Click
        Screen.Text += "8"
    End Sub

    Private Sub Btn_num9_Click(sender As Object, e As EventArgs) Handles Btn_num9.Click
        Screen.Text += "9"
    End Sub

    Private Sub Btn_num0_Click(sender As Object, e As EventArgs) Handles Btn_num0.Click
        Screen.Text += "0"
    End Sub

    Private Sub Btn_adds_Click(sender As Object, e As EventArgs) Handles Btn_adds.Click
        intFristNumber = CDbl(Screen.Text)
        strOperators = "+"
        Screen.Text = ""
    End Sub

    Private Sub Btn_subtracts_Click(sender As Object, e As EventArgs) Handles Btn_subtracts.Click
        intFristNumber = CDbl(Screen.Text)
        strOperators = "-"
        Screen.Text = ""
    End Sub

    Private Sub Btn_multiplys_Click(sender As Object, e As EventArgs) Handles Btn_multiplys.Click
        intFristNumber = CDbl(Screen.Text)
        strOperators = "*"
        Screen.Text = ""
    End Sub

    Private Sub Btn_divides_Click(sender As Object, e As EventArgs) Handles Btn_divides.Click
        intFristNumber = CDbl(Screen.Text)
        strOperators = "/"
        Screen.Text = ""
    End Sub

    Private Sub Btn_sumall_Click(sender As Object, e As EventArgs) Handles Btn_sumall.Click
        intLastNumber = Screen.Text
        If strOperators = "+" Then
            Screen.Text = intFristNumber + intLastNumber
        ElseIf strOperators = "-" Then
            Screen.Text = intFristNumber - intLastNumber
        ElseIf strOperators = "*" Then
            Screen.Text = intFristNumber * intLastNumber
        ElseIf strOperators = "/" Then
            Screen.Text = intFristNumber / intLastNumber
        End If
    End Sub

    Private Sub Btn_clearall_Click(sender As Object, e As EventArgs) Handles Btn_clearall.Click
        Screen.Text = ""
    End Sub

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click
        Me.Close()
    End Sub

    Private Sub Btn_addpoint_Click(sender As Object, e As EventArgs) Handles Btn_addpoint.Click
        If Screen.Text Like "*.*" Then
            Screen.Text += ""
        Else : Screen.Text += "."
        End If
    End Sub
End Class