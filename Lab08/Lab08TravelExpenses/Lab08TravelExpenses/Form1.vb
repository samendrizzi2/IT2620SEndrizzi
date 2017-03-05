Public Class Form1
    Dim Allowance As Decimal
    Dim TotalExpenses As Decimal
    Dim Excess As Decimal
    Dim Saved As Decimal
    Dim Reimbursed As Decimal
    Private Sub CalcMeals()
        Allowance += Convert.ToDecimal(TextBox1.Text) * 37
        TotalExpenses += Convert.ToDecimal(TextBox3.Text)
        If (Convert.ToDecimal(TextBox1.Text) * 37) >= Convert.ToDecimal(TextBox3.Text) Then
            Saved += (Convert.ToDecimal(TextBox1.Text) * 37) - Convert.ToDecimal(TextBox3.Text)
        Else
            Excess += Convert.ToDecimal(TextBox3.Text) - (Convert.ToDecimal(TextBox1.Text) * 37)
        End If
    End Sub
    Private Sub CalcMileage()
        TotalExpenses += Convert.ToDecimal(TextBox5.Text) * 0.27
        Allowance += Convert.ToDecimal(TextBox5.Text) * 0.27
    End Sub
    Private Sub CalcParkingFees()
        TotalExpenses += Convert.ToDecimal(TextBox6.Text)
        Allowance += Convert.ToDecimal(TextBox1.Text) * 10
        If (Convert.ToDecimal(TextBox1.Text) * 10) >= Convert.ToDecimal(TextBox6.Text) Then
            Saved += (Convert.ToDecimal(TextBox1.Text) * 10) - Convert.ToDecimal(TextBox6.Text)
        Else
            Excess += Convert.ToDecimal(TextBox6.Text) - (Convert.ToDecimal(TextBox1.Text) * 10)
        End If
    End Sub
    Private Sub CalcTaxiFees()
        TotalExpenses += Convert.ToDecimal(TextBox7.Text)
        Allowance += Convert.ToDecimal(TextBox1.Text) * 20
        If (Convert.ToDecimal(TextBox1.Text) * 20) >= Convert.ToDecimal(TextBox7.Text) Then
            Saved += (Convert.ToDecimal(TextBox1.Text) * 20) - Convert.ToDecimal(TextBox7.Text)
        Else
            Excess += Convert.ToDecimal(TextBox7.Text) - (Convert.ToDecimal(TextBox1.Text) * 20)
        End If
    End Sub
    Private Sub CalcLodging()
        TotalExpenses += (Convert.ToDecimal(TextBox1.Text) - 1) * Convert.ToDecimal(TextBox8.Text)
        Allowance += (Convert.ToDecimal(TextBox1.Text) - 1) * 95
        If ((Convert.ToDecimal(TextBox1.Text) - 1) * 95) >= (Convert.ToDecimal(TextBox1.Text) - 1) * Convert.ToDecimal(TextBox8.Text) Then
            Saved += ((Convert.ToDecimal(TextBox1.Text) - 1) * 95) - (Convert.ToDecimal(TextBox1.Text) - 1) * Convert.ToDecimal(TextBox8.Text)
        Else
            Excess += (Convert.ToDecimal(TextBox1.Text) - 1) * Convert.ToDecimal(TextBox8.Text) - ((Convert.ToDecimal(TextBox1.Text) - 1) * 95)
        End If
    End Sub
    Private Sub CalcTotalReimbursement()
        TotalExpenses += Convert.ToDecimal(TextBox2.Text) + Convert.ToDecimal(TextBox4.Text) + Convert.ToDecimal(TextBox7.Text)
        Reimbursed = TotalExpenses - Excess
        TextBox10.Text = TotalExpenses
        TextBox11.Text = Allowance
    End Sub
    Private Sub CalcUnallowed()
        TextBox12.Text = Excess
    End Sub
    Private Sub CalcSaved()
        TextBox13.Text = Saved
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Allowance = 0
        TotalExpenses = 0
        Excess = 0
        Saved = 0
        Try
            If (Convert.ToDecimal(TextBox1.Text) >= 1) And (Convert.ToDecimal(TextBox2.Text) >= 0) And (Convert.ToDecimal(TextBox3.Text) >= 0) And (Convert.ToDecimal(TextBox4.Text) >= 0) And (Convert.ToDecimal(TextBox5.Text) >= 0) And (Convert.ToDecimal(TextBox6.Text) >= 0) And (Convert.ToDecimal(TextBox7.Text) >= 0) And (Convert.ToDecimal(TextBox8.Text) >= 0) And (Convert.ToDecimal(TextBox8.Text) >= 0) Then
                CalcMeals()
                CalcMileage()
                CalcParkingFees()
                CalcTaxiFees()
                CalcLodging()
                CalcTotalReimbursement()
                CalcUnallowed()
                CalcSaved()
            Else
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK)
            End If
        Catch
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
