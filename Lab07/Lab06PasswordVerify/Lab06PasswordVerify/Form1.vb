Public Class Form1
    Dim Flag As Boolean
    Dim Regex As String
    Private Sub IsValid(A As String)
        Flag = False
        If System.Text.RegularExpressions.Regex.Match(TextBox1.Text, "\d").Success Then
            If System.Text.RegularExpressions.Regex.Match(TextBox1.Text, "[a-zA-Z]").Success Then
                If TextBox1.Text.Length >= 6 Then
                Else
                    Flag = True
                    MessageBox.Show("Password Must Contain At Least 6 Characters", "Error", MessageBoxButtons.OK)
                End If
            Else
                Flag = True
                MessageBox.Show("Password Must Contain Letters", "Error", MessageBoxButtons.OK)
            End If
        Else
            Flag = True
            MessageBox.Show("Password Must Contain Numbers", "Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IsValid(TextBox1.Text)
        If Flag = True Then
        Else
            MessageBox.Show("Password Accepted", "Success!", MessageBoxButtons.OK)
        End If
    End Sub
End Class
