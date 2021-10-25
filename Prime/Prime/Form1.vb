Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flag As Boolean = True
        Dim num As Integer = Val(txtNo.Text)

        For i = 2 To num / 2
            If (num Mod i = 0) Then
                flag = False
                Exit For
            End If

        Next i
        If flag = False Then
            lblResult.Text = "Not Prime"
        Else
            lblResult.Text = "Prime"
        End If

    End Sub
End Class
