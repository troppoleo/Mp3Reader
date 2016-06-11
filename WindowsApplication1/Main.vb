Imports WMPLib

Public Class Main

    Private _W As New WMPLib.WindowsMediaPlayer()

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenFileDialog1.Filter = "Mp3 file (.mp3)|*.mp3"
        '"Text Files (.txt)|*.txt
        OpenFileDialog1.FilterIndex = 1
        Dim myDr = OpenFileDialog1.ShowDialog()

        'If (mdr = ok)
        txtPath.Text = OpenFileDialog1.FileName
    End Sub


    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Dim myME As New System.Windows.Controls.MediaElement()
        'myME.Play()

        _W = New WMPLib.WindowsMediaPlayer()
        '_W.URL = "C:\Users\Administrator\Downloads\ESLPod1215.mp3"
        Dim myS = txtPath.Text.Trim()
        If (String.IsNullOrWhiteSpace(myS)) Then
            Return
        End If
        _W.URL = myS
        _W.controls.play()
        _isInPlay = True
    End Sub


    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        _W.controls.stop()

    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        _W.controls.pause()

    End Sub

    'Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
    '    _W.controls.currentPosition = _W.controls.currentPosition - 2
    'End Sub

    Private _isInPlay As Boolean
    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        _W.controls.play()
        _isInPlay = True
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
    Private Sub btnPauseResume_Click(sender As Object, e As EventArgs) Handles btnPauseResume.Click
        If (_isInPlay) Then
            If (_isInPause) Then
                _W.controls.play()
                _isInPause = False
            Else
                _W.controls.pause()
                _isInPause = True
            End If
        End If

    End Sub


End Class
