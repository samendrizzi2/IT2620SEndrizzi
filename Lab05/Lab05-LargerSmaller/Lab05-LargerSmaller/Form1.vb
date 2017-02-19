Public Class Form1
    Dim A As Integer
    Dim B As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Integer.TryParse(TextBox1.Text, A) Then
            If Integer.TryParse(TextBox2.Text, B) Then
                If A > B Then
                    TextBox3.Text = "Value A is Larger."
                Else
                    If B > A Then
                        TextBox3.Text = "Value B is Larger."
                    Else
                        If A = B Then
                            TextBox3.Text = "A and B are equal."
                        Else
                            TextBox3.Text = "What?"
                        End If
                    End If
                End If
            Else MessageBox.Show("Unable to Convert B to an Integer",
                 "Data Type Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
            End If
        Else
            MessageBox.Show("Unable to Convert A to an Integer",
            "Data Type Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
        End If
    End Sub
End Class
