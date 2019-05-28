Public Class frmLevel6

    Private intSeconds = 60
    Private intCookies = 0

   
    Private Sub tmrStand_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStand.Tick
        If intCharacterDirection = WEST Then
            picCharacter.Image = ChangeImage(charStandWest)
        ElseIf intCharacterDirection = EAST Then
            picCharacter.Image = ChangeImage(charStandEast)
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        tmrStand.Enabled = False

        Select Case e.KeyCode
            Case Keys.Left, Keys.A
                intCharacterDirection = WEST
                picCharacter.Image = ChangeImage(charWalkWest)
                If Not (picCharacter.Location.X - SPEED < 0) Then
                    picCharacter.Location = CharMove(picCharacter, intCharacterDirection)
                End If

            Case Keys.Right, Keys.D
                intCharacterDirection = EAST
                picCharacter.Image = ChangeImage(charWalkEast)
                If Not (picCharacter.Location.X + SPEED > Me.Width - picCharacter.Width - 13) Then
                    picCharacter.Location = CharMove(picCharacter, intCharacterDirection)
                End If

            Case Keys.Up, Keys.W
                intCharacterDirection = NORTH
                picCharacter.Image = ChangeImage(charClimbNorth)
                If Not (picCharacter.Location.Y - SPEED < 0) Then
                    picCharacter.Location = CharMove(picCharacter, intCharacterDirection)
                End If

            Case Keys.Down, Keys.S
                intCharacterDirection = SOUTH
                picCharacter.Image = ChangeImage(charClimbSouth)
                If Not (picCharacter.Location.Y + SPEED > Me.Height - picCharacter.Height - 37) Then
                    picCharacter.Location = CharMove(picCharacter, intCharacterDirection)
                End If

            Case Keys.Space
                If picCharacter.Bounds.IntersectsWith(picTeleporter1a.Bounds) Then
                    picCharacter.Location = New Point(894, 567)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter1b.Bounds) Then
                    picCharacter.Location = New Point(777, 12)
                ElseIf picCharacter.Bounds.IntersectsWith(picLever1.Bounds) Then
                    picLever1.Image = My.Resources.lever1
                    lblDoor1.Location = New Point(2000, 2000)
                End If
        End Select

        If picCharacter.Bounds.IntersectsWith(picExit.Bounds) Then
            MessageBox.Show("You've excaped the sixth level. Congratulations, you have beaten the Maze Game!", "Maze Game - Level 6")
            tmrCountdown.Enabled = False
            Me.Hide()
            frmMainMenu.Show()
        End If

        If WallCollisionLvl6(picCharacter) Then
            If intCharacterDirection = WEST Then
                picCharacter.Location = CharMove(picCharacter, EAST)
            ElseIf intCharacterDirection = EAST Then
                picCharacter.Location = CharMove(picCharacter, WEST)
            ElseIf intCharacterDirection = NORTH Then
                picCharacter.Location = CharMove(picCharacter, SOUTH)
            ElseIf intCharacterDirection = SOUTH Then
                picCharacter.Location = CharMove(picCharacter, NORTH)
            End If
        End If

        If picCharacter.Bounds.IntersectsWith(picCookie1.Bounds) Then
            picCookie1.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        End If

        lblCoins.Text = intCookies & " / 1 coins"

        If intCookies = 1 Then
            lblCoinDoor.Location = New Point(2000, 2000)
        End If

        ' If picCharacter.Bounds.IntersectsWith(picCookie.Bounds) Then
        '      MessageBox.Show("Mmmmhhhm...", "Animation Demo")
        '       picCookie.Location = New Point(-1000, -1000)
        '    End If
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        tmrStand.Enabled = True
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lvl6walls(0) = lblWall0
        Lvl6walls(1) = lblWall1
        Lvl6walls(2) = lblWall2
        Lvl6walls(3) = lblWall3
        Lvl6walls(4) = lblWall4
        Lvl6walls(5) = lblWall5
        Lvl6walls(6) = lblWall6
        Lvl6walls(7) = lblWall7
        Lvl6walls(8) = lblWall8
        Lvl6walls(9) = lblWall9
        Lvl6walls(10) = lblWall10
        Lvl6walls(11) = lblWall11
        Lvl6walls(12) = lblWall12
        Lvl6walls(13) = lblWall13
        Lvl6walls(14) = lblWall14
        Lvl6walls(15) = lblWall15
        Lvl6walls(16) = lblWall16
        Lvl6walls(17) = lblWall17
        Lvl6walls(18) = lblWall18
        Lvl6walls(19) = lblWall19
        Lvl6walls(20) = lblWall20
        Lvl6walls(21) = lblWall21
        Lvl6walls(22) = lblWall22
        Lvl6walls(23) = lblWall23
        Lvl6walls(24) = lblWall24
        Lvl6walls(25) = lblWall25
        Lvl6walls(26) = lblDoor1
        Lvl6walls(27) = lblCoinDoor
    End Sub

    'Private Sub tmrCookie_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCookie.Tick
    'If intCookieDirection = NORTH Then
    '   picCookie.Location = New Point(picCookie.Location.X, picCookie.Location.Y - 5)
    'ElseIf intCookieDirection = SOUTH Then
    '   picCookie.Location = New Point(picCookie.Location.X, picCookie.Location.Y + 5)
    'End If

    'If picCookie.Bounds.IntersectsWith(lblCookie1.Bounds) Then
    '   intCookieDirection = SOUTH
    'ElseIf picCookie.Bounds.IntersectsWith(lblCookie2.Bounds) Then
    '   intCookieDirection = NORTH
    'End If
    'End Sub

    Private Sub tmrCountdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCountdown.Tick
        intSeconds = intSeconds - 1
        lblCountdown.Text = intSeconds.ToString

        If intSeconds = 0 Then
            tmrCountdown.Enabled = False
            Dim dlgResult As DialogResult = MessageBox.Show("You ran out of time. Would you like to retry the level?", "Maze Game - Level 6", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgResult = Windows.Forms.DialogResult.Yes Then
                intSeconds = 60
                picCharacter.Location = New Point(12, 627)
                tmrCountdown.Enabled = True
            Else
                Me.Close()
                frmMainMenu.Show()
            End If
        End If
    End Sub
End Class