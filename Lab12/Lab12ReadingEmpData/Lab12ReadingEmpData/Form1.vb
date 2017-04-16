Public Class Form1
    Dim A As String
    Dim file As System.IO.StreamReader
    Dim B As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

    Private Sub Form1_Load() Handles MyBase.Load
        A = InputBox("Enter File Name", "File Name", "Employee1")
        file = My.Computer.FileSystem.OpenTextFileReader(B & "\" & A & ".txt")
        TextBox8.Text = A
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox9.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        file = My.Computer.FileSystem.OpenTextFileReader(B & "\" & TextBox8.Text & ".txt")
        TextBox1.Text = file.ReadLine()
        TextBox2.Text = file.ReadLine()
        TextBox3.Text = file.ReadLine()
        TextBox4.Text = file.ReadLine()
        TextBox9.Text = file.ReadLine()
        TextBox5.Text = file.ReadLine()
        TextBox6.Text = file.ReadLine()
        TextBox7.Text = file.ReadLine()


    End Sub
End Class
