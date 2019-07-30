Imports Toecramp_Engine
Imports Toecramp_Engine.engine
Imports Toecramp_Engine.engine.effects
Imports Toecramp_Engine.engine.rendering
Imports Toecramp_Engine.engine.physics


Public Class Form1
    Public FPS As Integer = 0
    Public tick As Integer = 0

    'Player coordinates
    Public PLAYER_X As Integer = 0
    Public PLAYER_Y As Integer = 0

    'Tiles coordinates
    Public TILE_X As Integer = 0
    Public TILE_Y As Integer = 0

    'Does the player hit any key?
    Public IsPressing As Integer = -1



    Public localRender As New Toecramp_Engine.engine.rendering
    Public localEffects As New Toecramp_Engine.engine.effects
    Public localPhysics As New Toecramp_Engine.engine.physics


    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll 'Changing the render-interval. How often is the screen refreshing.

        Render_Timer.Interval = TrackBar1.Value
        Render_Timer_Label.Text = TrackBar1.Value


    End Sub

    Private Sub Render_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Render_Timer.Tick 'Render Frame
        localRender.clear() ' Clear frame

        localRender.draw(My.Resources.background, 0, 0, 800, 600) ' Draw Background

        localRender.draw(My.Resources.player, PLAYER_X, PLAYER_Y, My.Resources.player.Width, My.Resources.player.Height) ' Draw Player
        localRender.draw(My.Resources.tile, TILE_X, TILE_Y, My.Resources.tile.Width, My.Resources.tile.Height) ' Draw Tile

        localRender.draw(My.Resources.overlay, 0, 0, 800, 600) ' Draw Overlay

        localRender.Label(FPS & " FPS // Hit F1 to reactivate the buttons & trackbars and so on")
        localRender.render(gamescreen, 800, 600) ' Render to panel "gamescreen"
        localRender.render(Gamescreen_mini, 800, 600) ' Render to picturebox "Gamescreen_mini"
        tick += 1
        TrackBar1.Value = Render_Timer.Interval

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged 'Pauses the rendering. Just the rendering!
        Render_Timer.Enabled = CheckBox1.Checked
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (IsPressing = 0 Or IsPressing = 1 Or IsPressing = 2 Or IsPressing = 3) Then

        Else
            Select Case e.KeyData

                Case Keys.W
                    IsPressing = 0

                Case Keys.S
                    IsPressing = 1

                Case Keys.A
                    IsPressing = 2

                Case Keys.D
                    IsPressing = 3

                Case Keys.F1
                    TrackBar1.Enabled = True
                    Tile_Y_Trackbar.Enabled = True
                    Tile_X_Trackbar.Enabled = True
                    Button1.Enabled = True
                    CheckBox1.Enabled = True

            End Select


        End If
    End Sub

    Private Sub Move_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Move_Timer.Tick
        ' 0 up
        ' 1 down
        ' 2 left
        ' 3 right


        If IsPressing = 0 Then
            If localPhysics.collision(PLAYER_X, PLAYER_Y - 3, My.Resources.player.Width, My.Resources.player.Height, TILE_X, TILE_Y, My.Resources.tile.Width - 1, My.Resources.tile.Height - 1) Then
            Else

                PLAYER_Y -= 3
            End If

        ElseIf IsPressing = 1 Then
            If localPhysics.collision(PLAYER_X, PLAYER_Y + 3, My.Resources.player.Width, My.Resources.player.Height, TILE_X, TILE_Y, My.Resources.tile.Width - 1, My.Resources.tile.Height - 1) Then
            Else
                PLAYER_Y += 3
            End If

        ElseIf IsPressing = 2 Then
            If localPhysics.collision(PLAYER_X - 3, PLAYER_Y, My.Resources.player.Width, My.Resources.player.Height, TILE_X, TILE_Y, My.Resources.tile.Width - 1, My.Resources.tile.Height - 1) Then
            Else
                PLAYER_X -= 3
            End If
        ElseIf IsPressing = 3 Then
            If localPhysics.collision(PLAYER_X + 3, PLAYER_Y, My.Resources.player.Width, My.Resources.player.Height, TILE_X, TILE_Y, My.Resources.tile.Width - 1, My.Resources.tile.Height - 1) Then
            Else
                PLAYER_X += 3
            End If
            End If


    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        IsPressing = -1
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Tile_Y_Trackbar.Maximum = gamescreen.Height
        Tile_X_Trackbar.Maximum = gamescreen.Width
    End Sub


    Private Sub Tile_Y_Trackbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tile_Y_Trackbar.Scroll
        TILE_Y = Tile_Y_Trackbar.Value
    End Sub

    Private Sub Tile_X_Trackbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tile_X_Trackbar.Scroll
        TILE_X = Tile_X_Trackbar.Value
    End Sub

    Private Sub FPS_Updater_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FPS_Updater.Tick
        FPS = tick
        tick = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TrackBar1.Enabled = False
        Tile_Y_Trackbar.Enabled = False
        Tile_X_Trackbar.Enabled = False
        Button1.Enabled = False
        CheckBox1.Enabled = False
    End Sub
End Class
