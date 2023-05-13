<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Label1 = New System.Windows.Forms.Label
		Me.btnLancer = New System.Windows.Forms.Button
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblHorloge = New System.Windows.Forms.Label
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
		Me.btnAnnuler = New System.Windows.Forms.Button
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.TextBox2 = New System.Windows.Forms.TextBox
		Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.RadioButton1 = New System.Windows.Forms.RadioButton
		Me.RadioButton2 = New System.Windows.Forms.RadioButton
		Me.Label4 = New System.Windows.Forms.Label
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.btnNouvelle = New System.Windows.Forms.Button
		Me.TextBox1 = New System.Windows.Forms.MaskedTextBox
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(23, 79)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Heure de la sonnerie"
		'
		'btnLancer
		'
		Me.btnLancer.Location = New System.Drawing.Point(26, 224)
		Me.btnLancer.Name = "btnLancer"
		Me.btnLancer.Size = New System.Drawing.Size(75, 23)
		Me.btnLancer.TabIndex = 2
		Me.btnLancer.Text = "Lancer"
		Me.btnLancer.UseVisualStyleBackColor = True
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		'
		'lblHorloge
		'
		Me.lblHorloge.AutoSize = True
		Me.lblHorloge.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHorloge.Location = New System.Drawing.Point(84, 7)
		Me.lblHorloge.Name = "lblHorloge"
		Me.lblHorloge.Size = New System.Drawing.Size(124, 22)
		Me.lblHorloge.TabIndex = 3
		Me.lblHorloge.Text = "Date et heure"
		Me.lblHorloge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.DateTimePicker1.Location = New System.Drawing.Point(143, 75)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(89, 20)
		Me.DateTimePicker1.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Heure exacte de la sonnerie !")
		'
		'btnAnnuler
		'
		Me.btnAnnuler.Location = New System.Drawing.Point(139, 224)
		Me.btnAnnuler.Name = "btnAnnuler"
		Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
		Me.btnAnnuler.TabIndex = 5
		Me.btnAnnuler.Text = "Annuler"
		Me.btnAnnuler.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.Red
		Me.Label2.Location = New System.Drawing.Point(103, 28)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(0, 13)
		Me.Label2.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(23, 106)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(36, 13)
		Me.Label3.TabIndex = 7
		Me.Label3.Text = "Memo"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(26, 126)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(299, 76)
		Me.TextBox2.TabIndex = 8
		'
		'NotifyIcon1
		'
		Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
		Me.NotifyIcon1.Text = "Alarme"
		Me.NotifyIcon1.Visible = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Location = New System.Drawing.Point(258, 51)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(60, 17)
		Me.RadioButton1.TabIndex = 9
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Manuel"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(258, 77)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
		Me.RadioButton2.TabIndex = 10
		Me.RadioButton2.Text = "Assisté"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(23, 51)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 13)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Heure de la sonnerie"
		'
		'btnNouvelle
		'
		Me.btnNouvelle.Location = New System.Drawing.Point(250, 224)
		Me.btnNouvelle.Name = "btnNouvelle"
		Me.btnNouvelle.Size = New System.Drawing.Size(75, 23)
		Me.btnNouvelle.TabIndex = 12
		Me.btnNouvelle.Text = "Nouvelle"
		Me.btnNouvelle.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(143, 49)
		Me.TextBox1.Mask = "00:00:00"
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(89, 20)
		Me.TextBox1.TabIndex = 13
		Me.TextBox1.Text = "000000"
		Me.ToolTip1.SetToolTip(Me.TextBox1, "Heure a additionner à l'heure actuelle")
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(353, 267)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.btnNouvelle)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.RadioButton2)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnAnnuler)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Controls.Add(Me.lblHorloge)
		Me.Controls.Add(Me.btnLancer)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Alarme"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnLancer As System.Windows.Forms.Button
	Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents lblHorloge As System.Windows.Forms.Label
	Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
	Friend WithEvents btnAnnuler As System.Windows.Forms.Button
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
	Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents btnNouvelle As System.Windows.Forms.Button
	Friend WithEvents TextBox1 As System.Windows.Forms.MaskedTextBox

End Class
