Public Class Form1
    Dim A As String
    Dim file As System.IO.StreamWriter
    Dim B As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    Private Sub Form1_Load() Handles MyBase.Load
        A = InputBox("Enter File Name", "File Name", "Employee1")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        file = My.Computer.FileSystem.OpenTextFileWriter(B & "\" & A & ".txt", True)
        file.WriteLine(TextBox1.Text)
        file.WriteLine(TextBox2.Text)
        file.WriteLine(TextBox3.Text)
        file.WriteLine(TextBox4.Text)
        file.WriteLine(ComboBox1.Text)
        file.WriteLine(TextBox5.Text)
        file.WriteLine(TextBox6.Text)
        file.WriteLine(TextBox7.Text)
        file.Close()
    End Sub
End Class
