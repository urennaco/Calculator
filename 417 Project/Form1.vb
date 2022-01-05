Public Class Form1
    Dim Var1, Var2 As Double
    Dim Operators As String
    Dim Number As Integer = 2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display.Text = Display.Text
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If Display.Text <> "0" Then
            Display.Text += "1"
        Else
            Display.Text = "1"
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Display.Text <> "0" Then
            Display.Text += "2"
        Else
            Display.Text = "2"
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If Display.Text <> "0" Then
            Display.Text += "3"
        Else
            Display.Text = "3"
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Display.Text <> "0" Then
            Display.Text += "4"
        Else
            Display.Text = "4"
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If Display.Text <> "0" Then
            Display.Text += "5"
        Else
            Display.Text = "5"
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If Display.Text <> "0" Then
            Display.Text += "6"
        Else
            Display.Text = "6"
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If Display.Text <> "0" Then
            Display.Text += "7"
        Else
            Display.Text = "7"
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If Display.Text <> "0" Then
            Display.Text += "8"
        Else
            Display.Text = "8"
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If Display.Text <> "0" Then
            Display.Text += "9"
        Else
            Display.Text = "9"
        End If
    End Sub

    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles BtnZero.Click
        If Display.Text <> "0" Then
            Display.Text += "0"
        End If
    End Sub

    Private Sub Btndot_Click(sender As Object, e As EventArgs) Handles Btndot.Click
        If Not (Display.Text.Contains(".")) Then
            Display.Text += "."
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Var1 = Val(Display.Text)
        Operators = "+"
        Display.Text = ""
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        Var1 = Val(Display.Text)
        Operators = "-"
        Display.Text = ""
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        Var1 = Val(Display.Text)
        Operators = "*"
        Display.Text = ""
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        Var1 = Val(Display.Text)
        Operators = "/"
        Display.Text = ""
    End Sub

    Private Sub BtnPtg_Click(sender As Object, e As EventArgs) Handles BtnPtg.Click
        Var1 = Val(Display.Text)
        Operators = "%"
        Display.Text = ""
    End Sub

    Private Sub Btnsrt_Click(sender As Object, e As EventArgs) Handles Btnsrt.Click
        Var1 = Val(Display.Text)
        Operators = "√"
        Display.Text = ""
    End Sub

    Private Sub BtnPwr_Click(sender As Object, e As EventArgs) Handles BtnPwr.Click
        Var1 = Val(Display.Text)
        Operators = "x^2"
        Display.Text = ""
    End Sub

    Private Sub BtnInverse_Click(sender As Object, e As EventArgs) Handles BtnInverse.Click
        Var1 = Val(Display.Text)
        Operators = "1/x"
        Display.Text = ""
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Var2 = Val(Display.Text)
        Select Case Operators
            Case "+" : Display.Text = Var1 + Var2
            Case "-" : Display.Text = Var1 - Var2
            Case "*" : Display.Text = Var1 * Var2
            Case "/" : Display.Text = Var1 / Var2
            Case "%" : Display.Text = Var1 * 1 / 100
            Case "√" : Display.Text = Math.Sqrt(Var1)
            Case "x^2" : Display.Text = Var1 ^ 2
            Case "1/x" : Display.Text = (1 / Var1)
        End Select
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Display.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Display.TextChanged



    End Sub
End Class
