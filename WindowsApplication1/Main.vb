Imports WMPLib

Public Class Main

    Private _W As WMPLib.WindowsMediaPlayer = Nothing

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Filter = "Mp3 file (.mp3)|*.mp3"
        '"Text Files (.txt)|*.txt
        OpenFileDialog1.FilterIndex = 1

        Dim myDr = OpenFileDialog1.ShowDialog()

        'If (mdr = ok)
        txtPath.Text = OpenFileDialog1.FileName

        If (Not String.IsNullOrWhiteSpace(txtPath.Text)) Then
            PlayMp3()
        End If

    End Sub


    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Dim myME As New System.Windows.Controls.MediaElement()
        'myME.Play()

        PlayMp3()
    End Sub

    Private Sub PlayMp3()
        If (Not _W Is Nothing) Then
            _W.close()
        End If
        _W = New WMPLib.WindowsMediaPlayer()

        AddHandler _W.PlayStateChange, AddressOf PlayStateChange

        '_W.URL = "C:\Users\Administrator\Downloads\ESLPod1215.mp3"
        Dim myS = txtPath.Text.Trim()
        If (String.IsNullOrWhiteSpace(myS)) Then
            Return
        End If
        _W.URL = myS

        _W.controls.play()
        IsInPause = False
        '_isInPlay = True


    End Sub


    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        _W.controls.stop()

    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        _W.controls.pause()

    End Sub


    'Private _isInPlay As Boolean
    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        _W.controls.play()
        Timer1.Enabled = True
        '_isInPlay = True
    End Sub


    Private Sub btnPrev10_Click(sender As Object, e As EventArgs) Handles btnPrev10.Click
        _W.controls.currentPosition = _W.controls.currentPosition - 10
    End Sub

    Private Sub btnPrev5_Click(sender As Object, e As EventArgs) Handles btnPrev5.Click
        _W.controls.currentPosition = _W.controls.currentPosition - 5
    End Sub

    Private Sub btnPrev2_Click(sender As Object, e As EventArgs) Handles btnPrev2.Click
        _W.controls.currentPosition = _W.controls.currentPosition - 2
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        _W.controls.currentPosition = _W.controls.currentPosition + 2
    End Sub

    Private Sub btnNext5_Click(sender As Object, e As EventArgs) Handles btnNext5.Click
        _W.controls.currentPosition = _W.controls.currentPosition + 5
    End Sub

    Private Sub btnNext10_Click(sender As Object, e As EventArgs) Handles btnNext10.Click
        _W.controls.currentPosition = _W.controls.currentPosition + 10
    End Sub

    Private _isInPause As Boolean = False
    Private Property IsInPause As Boolean
        Get
            Return _isInPause
        End Get
        Set(value As Boolean)
            If (value) Then
                _W.controls.pause()
            Else
                _W.controls.play()
            End If

            _isInPause = value
            Timer1.Enabled = Not value
        End Set
    End Property

    ''' <summary>
    ''' totale durata in secondi
    ''' </summary>
    ''' <remarks></remarks>
    Private _TotDurtion As Double

    Private Sub btnPauseResume_Click(sender As Object, e As EventArgs) Handles btnPauseResume.Click
        
        If (_W Is Nothing) Then
            PlayMp3()
        Else
            If (IsInPause) Then
                '_W.controls.play()
                IsInPause = False
            Else
                '_W.controls.pause()
                IsInPause = True
            End If
        End If

    End Sub


    Private Sub btnStartAtSecond_Click(sender As Object, e As EventArgs) Handles btnStartAtSecond.Click
        Try
            ' _W.controls.play()
            IsInPause = False
            _W.controls.currentPosition = Double.Parse(txtSeconds.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMark_Click(sender As Object, e As EventArgs) Handles btnMark.Click
        txtSeconds.Text = _W.controls.currentPosition
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim myCurr =  _W.controls.currentPosition
        txtCurrentSecond.Text = myCurr.ToString("N0")

        Dim mt As TimeSpan = TimeSpan.FromSeconds(_TotDurtion - myCurr)
        lblLeft.Text = String.Format("{0}:{1}", mt.Minutes, mt.Seconds)
    End Sub

    Private Sub txtSeconds_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSeconds.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnStartAtSecond_Click(sender, e)
        End If
    End Sub


    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Space) Then
            btnPauseResume_Click(sender, e)
        End If
    End Sub

 

    Private Sub PauseResumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseResumeToolStripMenuItem.Click
        btnPauseResume_Click(sender, e)
    End Sub

    Private Sub MarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkToolStripMenuItem.Click
        btnMark_Click(sender, e)
    End Sub

    Private Sub StartFromHereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartFromHereToolStripMenuItem.Click
        btnStartAtSecond_Click(sender, e)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'Private Sub PlayStateChanged(sender As Object, e As _wmpocXEVENTS_playStateChangeHandler)
    '    Throw New NotImplementedException
    'End Sub

    'Public Sub player_PlayStateChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles player.PlayStateChange

    '    ' Test the current state of the player, display a message for each state.
    '    Select Case e.newState

    '        Case 0 ' Undefined
    '            currentStateLabel.Text = "Undefined"

    '        Case 1 ' Stopped
    '            currentStateLabel.Text = "Stopped"

    '        Case 2 ' Paused
    '            currentStateLabel.Text = "Paused"

    '        Case 3 ' Playing
    '            currentStateLabel.Text = "Playing"

    '        Case 4 ' ScanForward
    '            currentStateLabel.Text = "ScanForward"

    '        Case 5 ' ScanReverse
    '            currentStateLabel.Text = "ScanReverse"

    '        Case 6 ' Buffering
    '            currentStateLabel.Text = "Buffering"

    '        Case 7 ' Waiting
    '            currentStateLabel.Text = "Waiting"

    '        Case 8 ' MediaEnded
    '            currentStateLabel.Text = "MediaEnded"

    '        Case 9 ' Transitioning
    '            currentStateLabel.Text = "Transitioning"

    '        Case 10 ' Ready
    '            currentStateLabel.Text = "Ready"

    '        Case 11 ' Reconnecting
    '            currentStateLabel.Text = "Reconnecting"

    '        Case 12 ' Last
    '            currentStateLabel.Text = "Last"

    '        Case Else
    '            currentStateLabel.Text = ("Unknown State: " + e.newState.ToString())

    '    End Select

    'End Sub


    Private Sub PlayStateChange(pNewState As Integer)
        Select Case pNewState

            Case 0 ' Undefined
                'currentStateLabel.Text = "Undefined"

            Case 1 ' Stopped
                'currentStateLabel.Text = "Stopped"

            Case 2 ' Paused
                'currentStateLabel.Text = "Paused"

            Case 3 ' Playing
                'currentStateLabel.Text = "Playing"
                _TotDurtion = _W.currentMedia.duration
                lblTime.Text = _W.currentMedia.durationString


            Case 4 ' ScanForward
                'currentStateLabel.Text = "ScanForward"

            Case 5 ' ScanReverse
                'currentStateLabel.Text = "ScanReverse"

            Case 6 ' Buffering
                ' currentStateLabel.Text = "Buffering"

            Case 7 ' Waiting
                ' currentStateLabel.Text = "Waiting"

            Case 8 ' MediaEnded
                ' currentStateLabel.Text = "MediaEnded"

            Case 9 ' Transitioning
                ' currentStateLabel.Text = "Transitioning"

            Case 10 ' Ready
                ' currentStateLabel.Text = "Ready"

            Case 11 ' Reconnecting
                'currentStateLabel.Text = "Reconnecting"

            Case 12 ' Last
                ' currentStateLabel.Text = "Last"

            Case Else
                ' currentStateLabel.Text = ("Unknown State: " + e.newState.ToString())

        End Select
    End Sub

End Class
