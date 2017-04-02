Public Class Form1
    Public A As Decimal
    Public B As Decimal
    Public C As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListBox1.Items.Clear()
            A = 0
            TextBox1.Text = A
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Me.Close()
        End If
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
            ComboBox3.SelectedIndex = -1
            My.Forms.Form2.Show()
        End If
        If ComboBox2.SelectedIndex = 1 Then
            ComboBox3.SelectedIndex = -1
            My.Forms.Form3.Show()
        End If
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 0 Then
            ComboBox3.SelectedIndex = -1
            MessageBox.Show("This Product was developed by no one.")
        End If
        ComboBox3.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "I Did it Your Way (Print)" Then
            A += -11.95
        End If
        If ListBox1.SelectedItem = "The History of Scotland (Print)" Then
            A += -14.5
        End If
        If ListBox1.SelectedItem = "Learn Calculus in One Day (Print)" Then
            A += -29.95
        End If
        If ListBox1.SelectedItem = "Feel the Stress (Print)" Then
            A += -18.5
        End If
        If ListBox1.SelectedItem = "Learn Calculus in One Day (Audio)" Then
            A += -29.95
        End If
        If ListBox1.SelectedItem = "The History of Scotland (Audio)" Then
            A += -14.5
        End If
        If ListBox1.SelectedItem = "The Science of Body Language (Audio)" Then
            A += -12.95
        End If
        If ListBox1.SelectedItem = "Relaxation Techniques (Audio)" Then
            A += -11.5
        End If
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        TextBox1.Text = A
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        B = Math.Round(A * 0.06, 2)
        TextBox2.Text = B
        C = ListBox1.Items.Count * 2
        TextBox3.Text = C
        TextBox4.Text = A + B + C
    End Sub
End Class
