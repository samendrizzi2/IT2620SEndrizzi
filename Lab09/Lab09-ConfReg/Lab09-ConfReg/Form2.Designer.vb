<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.CheckBox2)
		Me.Panel1.Controls.Add(Me.CheckBox1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Location = New System.Drawing.Point(13, 13)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(295, 169)
		Me.Panel1.TabIndex = 0
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Enabled = False
		Me.CheckBox2.Location = New System.Drawing.Point(35, 102)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(215, 17)
		Me.CheckBox2.TabIndex = 2
		Me.CheckBox2.Text = "Opening Night Dinner and Keynote: $30"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(35, 50)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(170, 17)
		Me.CheckBox1.TabIndex = 1
		Me.CheckBox1.Text = "Conference Registration: $895"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(14, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(62, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Conference"
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.Label3)
		Me.Panel2.Controls.Add(Me.ListBox1)
		Me.Panel2.Controls.Add(Me.Label2)
		Me.Panel2.Location = New System.Drawing.Point(315, 13)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(242, 169)
		Me.Panel2.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(34, 31)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 13)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Select One"
		'
		'ListBox1
		'
		Me.ListBox1.Enabled = False
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Items.AddRange(New Object() {"Intro to E-Commerce", "The Future of the Web", "Advanced Visual Basic", "Network Security"})
		Me.ListBox1.Location = New System.Drawing.Point(34, 50)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(178, 95)
		Me.ListBox1.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(13, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(134, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Preconference Workshops"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(315, 220)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Reset"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(452, 220)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "Close"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(579, 261)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "Form2"
		Me.Text = "Conference Options"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
