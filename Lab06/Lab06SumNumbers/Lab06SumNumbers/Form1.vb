Public Class Form1
    Dim Input As Integer
    Dim Output As Integer
    Dim A As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Input = 0
        Output = 0
        A = 0
        Input = InputBox("Enter a positive integer value.", "Input Needed", 10)
        If Input < 0 Then
            MessageBox.Show("Negative Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Do Until A = Input
                Output += A + 1
                A += 1
            Loop
            MessageBox.Show("The sum of the numbers 1 through " & Input & " is " & Output,
            "Sum of Numbers", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
