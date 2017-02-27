Public Class Form1
    Dim Input1 As Integer
    Dim Input2 As Integer
    Dim A As Integer
    Dim B As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Input1 = InputBox("Enter vehicle speed in miles per hour.", "Vehicle Speed")
        Input2 = InputBox("Enter time traveled in hours.", "Time Traveled")
        A = 1
        B = 0
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Vehicle Speed: " & Input1 & " MPH")
        ListBox1.Items.Add("Time Traveled: " & Input2 & " hours")
        ListBox1.Items.Add("Hours    Distance Traveled")
        ListBox1.Items.Add("__________________________")
        Do Until A = Input2 + 1
            B = A * Input1
            ListBox1.Items.Add(A & "           " & B)
            A += 1
        Loop
    End Sub
End Class
