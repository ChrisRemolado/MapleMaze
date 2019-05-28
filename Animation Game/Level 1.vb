Public Class frmLevel1

    Private intSeconds = 30



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
                    picCharacter.Location = New Point(135, 357)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter1b.Bounds) Then
                    picCharacter.Location = New Point(126, 613)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter2a.Bounds) Then
                    picCharacter.Location = New Point(379, 178)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter2b.Bounds) Then
                    picCharacter.Location = New Point(341, 48)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter3a.Bounds) Then
                    picCharacter.Location = New Point(519, 332)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter3b.Bounds) Then
                    picCharacter.Location = New Point(379, 627)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter3c.Bounds) Then
                    picCharacter.Location = New Point(379, 627)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter4a.Bounds) Then
                    picCharacter.Location = New Point(634, 624)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter4b.Bounds) Then
                    picCharacter.Location = New Point(742, 484)
                End If
        End Select

        If picCharacter.Bounds.IntersectsWith(picExit.Bounds) Then
            MessageBox.Show("You've excaped the first level. Get ready for Level 2.", "Maze Game - Level 1")
            tmrCountdown.Enabled = False
            Me.Hide()
            frmLevel2.Show()
        End If

        If WallCollisionLvl1(picCharacter) Then
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

        ' If picCharacter.Bounds.IntersectsWith(picCookie.Bounds) Then
        '      MessageBox.Show("Mmmmhhhm...", "Animation Demo")
        '       picCookie.Location = New Point(-1000, -1000)
        '    End If
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        tmrStand.Enabled = True
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lvl1walls(0) = lblWall0
        Lvl1walls(1) = lblWall1
        Lvl1walls(2) = lblWall2
        Lvl1walls(3) = lblWall3
        Lvl1walls(4) = lblWall4
        Lvl1walls(5) = lblWall5
        Lvl1walls(6) = lblWall6
        Lvl1walls(7) = lblWall7
        Lvl1walls(8) = lblWall8
        Lvl1walls(9) = lblWall9
        Lvl1walls(10) = lblWall10
        Lvl1walls(11) = lblWall11
        Lvl1walls(12) = lblWall12
        Lvl1walls(13) = lblWall13
        Lvl1walls(14) = lblWall14
        Lvl1walls(15) = lblWall15
        Lvl1walls(16) = lblWall16
        Lvl1walls(17) = lblWall17
        Lvl1walls(18) = lblWall18
        Lvl1walls(19) = lblWall19
        Lvl1walls(20) = lblWall20
        Lvl1walls(21) = lblWall21
        Lvl1walls(22) = lblWall22
        Lvl1walls(23) = lblWall23
        Lvl1walls(24) = lblWall24
        Lvl1walls(25) = lblWall25
        Lvl1walls(26) = lblWall26
        Lvl1walls(27) = lblWall27
        Lvl1walls(28) = lblWall28
        Lvl1walls(29) = lblWall29
        Lvl1walls(30) = lblWall30
        Lvl1walls(31) = lblWall31
        Lvl1walls(32) = lblWall32
        Lvl1walls(33) = lblWall33
        Lvl1walls(34) = lblWall34
        Lvl1walls(35) = lblWall35
        Lvl1walls(36) = lblWall36
        Lvl1walls(37) = lblWall37
        Lvl1walls(38) = lblWall38
        Lvl1walls(39) = lblWall39
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
            Dim dlgResult As DialogResult = MessageBox.Show("You ran out of time. Would you like to retry the level?", "Maze Game - Level 1", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgResult = Windows.Forms.DialogResult.Yes Then
                intSeconds = 30
                picCharacter.Location = New Point(12, 627)
                tmrCountdown.Enabled = True
            Else
                Me.Close()
                frmMainMenu.Show()
            End If
        End If
    End Sub
End Class