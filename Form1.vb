Public Class Form1
    Private Const MAX_VALUES As Integer = 10
    Private Const ERROR_MSG As String = "Please enter a valid positive decimal number."

    Private totalSpeed As Double = 0
    Private count As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAverageInput.Text = ""
    End Sub
    Private Sub btnEnterSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterSpeed.Click
        Dim inputSpeed As String = InputBox("Enter your Internet speed in Mbps:", "Internet Speed Test Survey")
        Dim speed As Double

        If inputSpeed <> "" AndAlso Double.TryParse(inputSpeed, speed) AndAlso speed >= 0 Then
            totalSpeed += speed
            count += 1
            lstSpeeds.Items.Add(speed)
            If count = MAX_VALUES Then
                btnEnterSpeed.Enabled = False
                Dim averageSpeed As Double = totalSpeed / count
                lblAverageInput.Text = averageSpeed.ToString("0.00") & " Mbps"
            End If
        ElseIf inputSpeed <> "" Then
            MessageBox.Show(ERROR_MSG, "Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If count = 0 Then
            MessageBox.Show("You have not entered any speeds.", "Notice")
        Else
            lstSpeeds.Items.Clear()
            lblAverageInput.Text = ""
            totalSpeed = 0
            count = 0
            btnEnterSpeed.Enabled = True
        End If

    End Sub


End Class
