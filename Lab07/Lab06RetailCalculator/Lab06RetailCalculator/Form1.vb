Public Class Form1
    Dim a As Decimal
    Dim b As Decimal
    Private Sub CalculateRetail()
        a = Convert.ToDecimal(TextBox1.Text)
        b = Convert.ToDecimal(TextBox2.Text) / 100
        TextBox3.Text = a * b + a
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateRetail()
    End Sub
End Class
