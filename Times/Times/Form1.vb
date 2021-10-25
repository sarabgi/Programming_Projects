Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim multiplier As Integer
        Dim answer As Integer
        Dim i As Integer

        num1 = Val(txtNum1.Text)
        num2 = Val(txtNum2.Text)
        multiplier = 2

        Do While multiplier < 3

            For i = num1 To num2
                answer = i * multiplier
                ListBox1.Items.Add(i & " Times " & multiplier & " = " & answer)
            Next i
            multiplier = multiplier + 1
        Loop
    End Sub
End Class
