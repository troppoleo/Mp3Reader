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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
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
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStartAtSecond = New System.Windows.Forms.Button()
        Me.btnMark = New System.Windows.Forms.Button()
        Me.txtCurrentSecond = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(478, 71)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(100, 22)
        Me.txtSeconds.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(326, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Second"
        '
        'btnStartAtSecond
        '
        Me.btnStartAtSecond.Location = New System.Drawing.Point(584, 66)
        Me.btnStartAtSecond.Name = "btnStartAtSecond"
        Me.btnStartAtSecond.Size = New System.Drawing.Size(116, 33)
        Me.btnStartAtSecond.TabIndex = 16
        Me.btnStartAtSecond.Text = "Start from here"
        Me.btnStartAtSecond.UseVisualStyleBackColor = True
        '
        'btnMark
        '
        Me.btnMark.Location = New System.Drawing.Point(388, 68)
        Me.btnMark.Name = "btnMark"
        Me.btnMark.Size = New System.Drawing.Size(72, 33)
        Me.btnMark.TabIndex = 17
        Me.btnMark.Text = "Mark"
        Me.btnMark.UseVisualStyleBackColor = True
        '
        'txtCurrentSecond
        '
        Me.txtCurrentSecond.Location = New System.Drawing.Point(147, 100)
        Me.txtCurrentSecond.Name = "txtCurrentSecond"
        Me.txtCurrentSecond.Size = New System.Drawing.Size(100, 22)
        Me.txtCurrentSecond.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Current second:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(953, 228)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurrentSecond)
        Me.Controls.Add(Me.btnMark)
        Me.Controls.Add(Me.btnStartAtSecond)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSeconds)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStartAtSecond As System.Windows.Forms.Button
    Friend WithEvents btnMark As System.Windows.Forms.Button
    Friend WithEvents txtCurrentSecond As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
