Public Class Form2
    Public A As Integer

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		A = 0
		If CheckBox1.Checked Then
			A += 895
		End If
		If CheckBox2.Checked Then
			A += 30
		End If
		If ListBox1.SelectedIndex = 0 Then
			A += 295
		End If
		If ListBox1.SelectedIndex = 1 Then
			A += 295
		End If
		If ListBox1.SelectedIndex = 2 Then
			A += 395
		End If
		If ListBox1.SelectedIndex = 3 Then
			A += 395
		End If
		Form1.TextBox9.Text = A
		Me.Close()
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		CheckBox1.Checked = False
		CheckBox2.Checked = False
		ListBox1.ClearSelected()
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If CheckBox1.Checked Then
			ListBox1.Enabled = True
			CheckBox2.Enabled = True
		Else
			ListBox1.Enabled = False
			CheckBox2.Enabled = False
			CheckBox2.Checked = False
			ListBox1.ClearSelected()
		End If
	End Sub
End Class