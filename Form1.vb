'Alarme par Tony Simoes.
'Vendredi 24 ao�t 2007

''' <summary>
''' Alarme param�tr�e 
''' </summary>
''' <remarks></remarks>
Public Class Form1
    Dim dernierAffichage As Integer
    Dim DateSonnerie As Date

#Region " Chargement form "
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Mise en forme du controle DateTimePicker1
        DateTimePicker1.ShowUpDown = True
        DateTimePicker1.Format = DateTimePickerFormat.Time
        btnAnnuler.Enabled = False
        Me.ToolTip1.IsBalloon = True
    End Sub
#End Region

#Region " Bouton Lancer "
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLancer.Click
        If RadioButton1.Checked = True Then
            'timespan a zero
            Dim valTimeSpan As New TimeSpan
            Dim str As String = TextBox1.Text
            'Verification de l'entr�e utilisateur
            If Not TextBox1.MaskCompleted Then
                str = "00:00:01"
            End If
            valTimeSpan = valTimeSpan.Add(TimeSpan.Parse(str))
            DateSonnerie = Now.Add(valTimeSpan)
            'todo: verifier le centrage !!!
            Label2.Text = "Prochaine alarme : " & DateSonnerie
        Else
            DateSonnerie = DateTimePicker1.Value
            Label2.Text = "Prochaine alarme : " & DateSonnerie
        End If
        TextBox2.ReadOnly = True
        btnLancer.Enabled = False
        btnAnnuler.Enabled = True
        btnNouvelle.Enabled = False
    End Sub
#End Region

#Region " Bouton Annuler "
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        'Alert voules vous vraiement annuler cette alarme ?
        'MessageBox.Show("Voulez vous vraiement annuler cette alarme")
        'todo: implementer la validation
        DateSonnerie = Now.Subtract(TimeSpan.Parse("00:00:01"))
        btnLancer.Enabled = True
        btnAnnuler.Enabled = False
        Label2.Text = ""
        TextBox1.Text = "00:00:00"
    End Sub
#End Region

#Region " Nouvelle Alarme "
    Private Sub btnNouvelle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNouvelle.Click
        RadioButton1.Checked = True
        Label2.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = "00:00:00"
        DateTimePicker1.ResetText()
        Me.BackColor = Color.Gainsboro
        TextBox2.ReadOnly = False
        btnLancer.Enabled = True
        btnAnnuler.Enabled = False
    End Sub
#End Region

#Region " Lecture sons (dans my.settings !) "
    Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound( _
         System.Media.SystemSounds.Asterisk)
    End Sub

    Public Function getRepertoireAppli() As String
        Dim maString As String = String.Empty
        ' R�cup�ration du chemin de l'application
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
                'Restaure la form si dans le tray
                If Me.WindowState = FormWindowState.Minimized Then
                    RestoreWindow()
                End If
                'change aspect
                Me.BackColor = Color.Red
                Label2.ForeColor = Color.White
                'etat des boutons
                btnLancer.Enabled = False
                btnAnnuler.Enabled = False
                btnNouvelle.Enabled = True
                'Sonne dans un autre thread !
                'PlaySoundFile()
                BackgroundWorker1.RunWorkerAsync()
            End If
        End If
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

#Region " Choix de l'entr�e de l'heure "
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        DateTimePicker1.Enabled = False
        TextBox1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = False
        DateTimePicker1.Enabled = True
    End Sub
#End Region

#Region " Traitement du thread avec BackgroundWorker "

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        PlaySoundFile()
        My.Computer.Audio.Stop()
    End Sub

#End Region

End Class
