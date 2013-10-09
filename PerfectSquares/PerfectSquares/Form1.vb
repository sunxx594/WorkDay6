Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim n As Integer = 1
        Dim m As Integer

        Do While (n <= 10)
            m = n ^ 2
            n += 1
            lstResult.Items.Add("Number is" & " " & m)
        Loop


    End Sub
End Class
