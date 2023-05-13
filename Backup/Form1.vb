'Alarme paramétrée par Tony Simoes.
'Vendredi 24 août 2007

Public Class Form1

	Dim dernierAffichage As Integer
	Dim DateSonnerie As Date

#Region " btnLancer "
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLancer.Click
		If RadioButton1.Checked = True Then
			'timespan a zero
			Dim valTimeSpan As New TimeSpan
			Dim str As String = TextBox1.Text
			'Verification de l'entrée utilisateur
			If Not TextBox1.MaskCompleted Then
				str = "00:00:01"
			End If
			valTimeSpan = valTimeSpan.Add(TimeSpan.Parse(str))
			DateSonnerie = Now.Add(valTimeSpan)
			Label2.Text = "Alarme : " & DateSonnerie
		Else
			DateSonnerie = DateTimePicker1.Value
			Label2.Text = "Alarme : " & DateSonnerie
		End If
		btnLancer.Enabled = False
		btnAnnuler.Enabled = True
		btnNouvelle.Enabled = False
	End Sub
#End Region

#Region " Lecture sons (dans my.settings !) "
	Sub PlaySystemSound()
		My.Computer.Audio.PlaySystemSound( _
		 System.Media.SystemSounds.Asterisk)
	End Sub

	Public Function getRepertoireAppli() As String
		Dim maString As String = String.Empty
		' Récupération du chemin de l'application
		maString = My.Application.Info.DirectoryPath
		Return maString
	End Function

	Sub PlaySoundFile()
		My.Computer.Audio.Play(getRepertoireAppli() & "\" & My.Settings.Item("musiqueWav").ToString, _
		 AudioPlayMode.WaitToComplete)
	End Sub
#End Region

#Region " Timer "
	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		If dernierAffichage <> Now.Second Then
			dernierAffichage = Now.Second
			lblHorloge.Text = CStr(Now)
			If DateSonnerie.ToString = lblHorloge.Text Then
				Me.BackColor = Color.Red
				Label2.ForeColor = Color.White
				PlaySoundFile()
				My.Computer.Audio.Stop()
				btnLancer.Enabled = False
				btnAnnuler.Enabled = False
				btnNouvelle.Enabled = True
			End If
		End If
	End Sub
#End Region

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
		DateSonnerie = Now.Subtract(TimeSpan.Parse("00:00:01"))
		btnLancer.Enabled = True
		btnAnnuler.Enabled = False
		Label2.Text = ""
		TextBox1.Text = "00:00:00"
	End Sub

#Region " Chargement form "
	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'Mise en forme du controle !!!
		DateTimePicker1.ShowUpDown = True
		DateTimePicker1.Format = DateTimePickerFormat.Time
		'Me.BackColor = Color.Gainsboro
		btnAnnuler.Enabled = False
		Me.ToolTip1.IsBalloon = True
	End Sub
#End Region

#Region " Faire disparaitre la form "
	Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = FormWindowState.Minimized Then
			NotifyIcon1.Visible = True
			Me.Hide()
		End If
	End Sub
#End Region

#Region " RestaureWindows "
	Private Sub RestoreWindow()
		Me.Show()
		NotifyIcon1.Visible = False
		Me.WindowState = FormWindowState.Normal
		Me.Focus()
	End Sub
#End Region

#Region " Double clic dans le systray "
	Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
		RestoreWindow()
	End Sub
#End Region

	Private Sub btnNouvelle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNouvelle.Click
		RadioButton1.Checked = True
		Label2.Text = ""
		TextBox2.Text = ""
		TextBox1.Text = "00:00:00"
		DateTimePicker1.ResetText()
		Me.BackColor = Color.Gainsboro
		btnLancer.Enabled = True
		btnAnnuler.Enabled = False
	End Sub

#Region " Choix de l'entrée de l'heure "
	Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
		DateTimePicker1.Enabled = False
		TextBox1.Enabled = True
	End Sub

	Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
		TextBox1.Enabled = False
		DateTimePicker1.Enabled = True
	End Sub
#End Region

End Class
