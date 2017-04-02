Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ListBox1.Items.Add(ListBox1.SelectedItem)
        If ListBox1.SelectedIndex = 0 Then
            Form1.A += 11.95
        End If
        If ListBox1.SelectedIndex = 1 Then
            Form1.A += 14.5
        End If
        If ListBox1.SelectedIndex = 2 Then
            Form1.A += 29.95
        End If
        If ListBox1.SelectedIndex = 3 Then
            Form1.A += 18.5
        End If
        Form1.TextBox1.Text = Form1.A
    End Sub
End Class