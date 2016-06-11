<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnPrev2 = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnNext5 = New System.Windows.Forms.Button()
        Me.btnPrev5 = New System.Windows.Forms.Button()
        Me.btnPauseResume = New System.Windows.Forms.Button()
        Me.btnNext10 = New System.Windows.Forms.Button()
        Me.btnPrev10 = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(100, 55)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 38)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(718, 12)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(97, 81)
        Me.btnPause.TabIndex = 1
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        Me.btnPause.Visible = False
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(839, 26)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(97, 52)
        Me.btnResume.TabIndex = 3
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = True
        Me.btnResume.Visible = False
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(100, 27)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(836, 22)
        Me.txtPath.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(13, 27)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 51)
        Me.btnOpen.TabIndex = 5
        Me.btnOpen.Text = "Open MP3"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnPrev2
        '
        Me.btnPrev2.Location = New System.Drawing.Point(225, 140)
        Me.btnPrev2.Name = "btnPrev2"
        Me.btnPrev2.Size = New System.Drawing.Size(99, 67)
        Me.btnPrev2.TabIndex = 6
        Me.btnPrev2.Text = "< Prev 2 second"
        Me.btnPrev2.UseVisualStyleBackColor = True
        '
        'btnNext2
        '
        Me.btnNext2.Location = New System.Drawing.Point(611, 140)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(99, 67)
        Me.btnNext2.TabIndex = 7
        Me.btnNext2.Text = "Next 2 second >"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'btnNext5
        '
        Me.btnNext5.Location = New System.Drawing.Point(716, 140)
        Me.btnNext5.Name = "btnNext5"
        Me.btnNext5.Size = New System.Drawing.Size(99, 67)
        Me.btnNext5.TabIndex = 8
        Me.btnNext5.Text = "Next 5 second >"
        Me.btnNext5.UseVisualStyleBackColor = True
        '
        'btnPrev5
        '
        Me.btnPrev5.Location = New System.Drawing.Point(120, 140)
        Me.btnPrev5.Name = "btnPrev5"
        Me.btnPrev5.Size = New System.Drawing.Size(99, 67)
        Me.btnPrev5.TabIndex = 9
        Me.btnPrev5.Text = "< Prev 5 second"
        Me.btnPrev5.UseVisualStyleBackColor = True
        '
        'btnPauseResume
        '
        Me.btnPauseResume.Location = New System.Drawing.Point(419, 133)
        Me.btnPauseResume.Name = "btnPauseResume"
        Me.btnPauseResume.Size = New System.Drawing.Size(130, 81)
        Me.btnPauseResume.TabIndex = 10
        Me.btnPauseResume.Text = "Pause/Resume"
        Me.btnPauseResume.UseVisualStyleBackColor = True
        '
        'btnNext10
        '
        Me.btnNext10.Location = New System.Drawing.Point(821, 140)
        Me.btnNext10.Name = "btnNext10"
        Me.btnNext10.Size = New System.Drawing.Size(99, 67)
        Me.btnNext10.TabIndex = 11
        Me.btnNext10.Text = "Next 10 second >"
        Me.btnNext10.UseVisualStyleBackColor = True
        '
        'btnPrev10
        '
        Me.btnPrev10.Location = New System.Drawing.Point(12, 140)
        Me.btnPrev10.Name = "btnPrev10"
        Me.btnPrev10.Size = New System.Drawing.Size(99, 67)
        Me.btnPrev10.TabIndex = 12
        Me.btnPrev10.Text = "< Prev 10 second"
        Me.btnPrev10.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(211, 55)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 38)
        Me.btnStop.TabIndex = 13
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(953, 228)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPrev10)
        Me.Controls.Add(Me.btnNext10)
        Me.Controls.Add(Me.btnPauseResume)
        Me.Controls.Add(Me.btnPrev5)
        Me.Controls.Add(Me.btnNext5)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.btnPrev2)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Main"
        Me.Text = "Play MP3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnPrev2 As System.Windows.Forms.Button
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnNext5 As System.Windows.Forms.Button
    Friend WithEvents btnPrev5 As System.Windows.Forms.Button
    Friend WithEvents btnPauseResume As System.Windows.Forms.Button
    Friend WithEvents btnNext10 As System.Windows.Forms.Button
    Friend WithEvents btnPrev10 As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button

End Class
