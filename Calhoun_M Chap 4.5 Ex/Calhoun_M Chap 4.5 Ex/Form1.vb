Public Class Form1
    Private balamount, checkbal, dbal, scbal As Decimal
    Private checkinteger, dinteger, scinteger As Integer
    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()

    End Sub

    Private Sub calbutton_Click(sender As Object, e As EventArgs) Handles calbutton.Click
        Dim inputdecimal As Decimal

        inputdecimal = Decimal.Parse(amounttextbox.Text)

        If checkbutton.Checked = True Then
            balamount -= inputdecimal
            checkbal += inputdecimal
            checkinteger += 1
        ElseIf depositbutton.Checked = True Then
            balamount += inputdecimal
            dbal += inputdecimal
            dinteger += 1
        ElseIf chargebutton.Checked = True Then
            balamount -= inputdecimal
            scbal += inputdecimal
            scinteger += 1
        End If

        baltextbox.Text = balamount.ToString("C")

    End Sub

    Private Sub clearbutton_Click(sender As Object, e As EventArgs) Handles clearbutton.Click
        baltextbox.Clear()
        amounttextbox.Clear()

    End Sub

    Private Sub printbutton_Click(sender As Object, e As EventArgs) Handles printbutton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

    Private Sub sumbutton_Click(sender As Object, e As EventArgs) Handles sumbutton.Click
        Dim messagestring As String
        messagestring = "Number of Checks: " _
            & checkinteger.ToString() _
            & Environment.NewLine & Environment.NewLine _
            & "Total amount of checks: " _
            & checkbal.ToString("C") _
            & Environment.NewLine & Environment.NewLine _
            & "Total number of deposits: " _
            & dinteger.ToString() _
            & Environment.NewLine & Environment.NewLine _
            & "Total amount of deposits: " _
            & dbal.ToString("C") _
            & Environment.NewLine & Environment.NewLine _
            & "Total number of service charges: " _
            & scinteger.ToString() _
            & Environment.NewLine & Environment.NewLine _
            & "Total amount of service charges: " _
            & scbal.ToString("C")
        MessageBox.Show(messagestring, "Bank Statement", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
