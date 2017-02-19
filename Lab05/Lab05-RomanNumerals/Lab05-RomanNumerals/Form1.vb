Public Class Form1
    Dim A As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        If Integer.TryParse(TextBox1.Text, A) Then
            If A >= 1 And A <= 10 Then
                Select Case True
                    Case (TextBox1.Text = 1)
                        TextBox2.Text = "I"
                    Case (TextBox1.Text = 2)
                        TextBox2.Text = "II"
                    Case (TextBox1.Text = 3)
                        TextBox2.Text = "III"
                    Case (TextBox1.Text = 4)
                        TextBox2.Text = "IV"
                    Case (TextBox1.Text = 5)
                        TextBox2.Text = "V"
                    Case (TextBox1.Text = 6)
                        TextBox2.Text = "VI"
                    Case (TextBox1.Text = 7)
                        TextBox2.Text = "VII"
                    Case (TextBox1.Text = 8)
                        TextBox2.Text = "VIII"
                    Case (TextBox1.Text = 9)
                        TextBox2.Text = "IX"
                    Case (TextBox1.Text = 10)
                        TextBox2.Text = "X"
                End Select
            Else
                MessageBox.Show("Invalid Input", "Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            End If
        Else
            MessageBox.Show("Invalid Input", "Error",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If

    End Sub
End Class
