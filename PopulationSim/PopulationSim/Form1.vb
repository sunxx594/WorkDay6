Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim curYear As Integer
        Dim pop As Double

        curYear = 2012
        pop = 7000

        Do While (pop >= 6)

            pop = pop / 2
            curYear = curYear - 50

        Loop

        MessageBox.Show("The year is" & " " & curYear)

    End Sub
End Class
