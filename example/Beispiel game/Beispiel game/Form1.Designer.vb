<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gamescreen = New System.Windows.Forms.Panel()
        Me.Render_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Move_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Render_Timer_Label = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Tile_Y_Trackbar = New System.Windows.Forms.TrackBar()
        Me.Tile_X_Trackbar = New System.Windows.Forms.TrackBar()
        Me.Gamescreen_mini = New System.Windows.Forms.PictureBox()
        Me.Tile_Y_Label = New System.Windows.Forms.Label()
        Me.Tile_X_Label = New System.Windows.Forms.Label()
        Me.FPS_Updater = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile_Y_Trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tile_X_Trackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gamescreen_mini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gamescreen
        '
        Me.gamescreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gamescreen.BackColor = System.Drawing.Color.Black
        Me.gamescreen.Location = New System.Drawing.Point(12, 12)
        Me.gamescreen.Name = "gamescreen"
        Me.gamescreen.Size = New System.Drawing.Size(613, 379)
        Me.gamescreen.TabIndex = 0
        '
        'Render_Timer
        '
        Me.Render_Timer.Enabled = True
        '
        'Move_Timer
        '
        Me.Move_Timer.Enabled = True
        Me.Move_Timer.Interval = 1
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.BackColor = System.Drawing.Color.Gray
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(12, 397)
        Me.TrackBar1.Maximum = 1000
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(100, 45)
        Me.TrackBar1.TabIndex = 1
        Me.TrackBar1.Value = 1
        '
        'Render_Timer_Label
        '
        Me.Render_Timer_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Render_Timer_Label.AutoSize = True
        Me.Render_Timer_Label.Location = New System.Drawing.Point(125, 405)
        Me.Render_Timer_Label.Name = "Render_Timer_Label"
        Me.Render_Timer_Label.Size = New System.Drawing.Size(29, 13)
        Me.Render_Timer_Label.TabIndex = 2
        Me.Render_Timer_Label.Text = "NUL"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(128, 425)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Render"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Tile_Y_Trackbar
        '
        Me.Tile_Y_Trackbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tile_Y_Trackbar.Location = New System.Drawing.Point(470, 397)
        Me.Tile_Y_Trackbar.Name = "Tile_Y_Trackbar"
        Me.Tile_Y_Trackbar.Size = New System.Drawing.Size(104, 45)
        Me.Tile_Y_Trackbar.TabIndex = 4
        '
        'Tile_X_Trackbar
        '
        Me.Tile_X_Trackbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tile_X_Trackbar.Location = New System.Drawing.Point(470, 425)
        Me.Tile_X_Trackbar.Name = "Tile_X_Trackbar"
        Me.Tile_X_Trackbar.Size = New System.Drawing.Size(104, 45)
        Me.Tile_X_Trackbar.TabIndex = 5
        '
        'Gamescreen_mini
        '
        Me.Gamescreen_mini.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gamescreen_mini.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gamescreen_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Gamescreen_mini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Gamescreen_mini.Location = New System.Drawing.Point(249, 393)
        Me.Gamescreen_mini.MaximumSize = New System.Drawing.Size(115, 77)
        Me.Gamescreen_mini.MinimumSize = New System.Drawing.Size(115, 77)
        Me.Gamescreen_mini.Name = "Gamescreen_mini"
        Me.Gamescreen_mini.Size = New System.Drawing.Size(115, 77)
        Me.Gamescreen_mini.TabIndex = 0
        Me.Gamescreen_mini.TabStop = False
        '
        'Tile_Y_Label
        '
        Me.Tile_Y_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tile_Y_Label.AutoSize = True
        Me.Tile_Y_Label.Location = New System.Drawing.Point(580, 397)
        Me.Tile_Y_Label.Name = "Tile_Y_Label"
        Me.Tile_Y_Label.Size = New System.Drawing.Size(29, 13)
        Me.Tile_Y_Label.TabIndex = 6
        Me.Tile_Y_Label.Text = "NUL"
        '
        'Tile_X_Label
        '
        Me.Tile_X_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tile_X_Label.AutoSize = True
        Me.Tile_X_Label.Location = New System.Drawing.Point(580, 429)
        Me.Tile_X_Label.Name = "Tile_X_Label"
        Me.Tile_X_Label.Size = New System.Drawing.Size(29, 13)
        Me.Tile_X_Label.TabIndex = 7
        Me.Tile_X_Label.Text = "NUL"
        '
        'FPS_Updater
        '
        Me.FPS_Updater.Enabled = True
        Me.FPS_Updater.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(370, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Control"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 469)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tile_X_Label)
        Me.Controls.Add(Me.Tile_Y_Label)
        Me.Controls.Add(Me.Gamescreen_mini)
        Me.Controls.Add(Me.Tile_X_Trackbar)
        Me.Controls.Add(Me.Tile_Y_Trackbar)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Render_Timer_Label)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.gamescreen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile_Y_Trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tile_X_Trackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gamescreen_mini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gamescreen As System.Windows.Forms.Panel
    Friend WithEvents Render_Timer As System.Windows.Forms.Timer
    Friend WithEvents Move_Timer As System.Windows.Forms.Timer
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Render_Timer_Label As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Tile_Y_Trackbar As System.Windows.Forms.TrackBar
    Friend WithEvents Tile_X_Trackbar As System.Windows.Forms.TrackBar
    Friend WithEvents Gamescreen_mini As System.Windows.Forms.PictureBox
    Friend WithEvents Tile_Y_Label As System.Windows.Forms.Label
    Friend WithEvents Tile_X_Label As System.Windows.Forms.Label
    Friend WithEvents FPS_Updater As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
