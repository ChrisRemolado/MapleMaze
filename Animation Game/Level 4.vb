Public Class frmLevel4

    Private intSeconds = 105



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
                    picCharacter.Location = New Point(138, 519)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter1b.Bounds) Then
                    picCharacter.Location = New Point(30, 413)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter2a.Bounds) Then
                    picCharacter.Location = New Point(468, 30)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter2b.Bounds) Then
                    picCharacter.Location = New Point(28, 200)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter3a.Bounds) Then
                    picCharacter.Location = New Point(353, 525)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter3b.Bounds) Then
                    picCharacter.Location = New Point(914, 20)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter4a.Bounds) Then
                    picCharacter.Location = New Point(914, 525)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter4b.Bounds) Then
                    picCharacter.Location = New Point(252, 525)
                ElseIf picCharacter.Bounds.IntersectsWith(picLever1.Bounds) Then
                    picLever1.Image = My.Resources.lever1
                    lblDoor1.Location = New Point(2000, 2000)
                ElseIf picCharacter.Bounds.IntersectsWith(picLever2.Bounds) Then
                    picLever2.Image = My.Resources.lever1
                    lblDoor2.Location = New Point(2000, 2000)
                ElseIf picCharacter.Bounds.IntersectsWith(picLever3.Bounds) Then
                    picLever3.Image = My.Resources.lever1
                    lblDoor3.Location = New Point(2000, 2000)
                ElseIf picCharacter.Bounds.IntersectsWith(picLever4.Bounds) Then
                    picLever4.Image = My.Resources.lever1
                    lblDoor4.Location = New Point(2000, 2000)
                ElseIf picCharacter.Bounds.IntersectsWith(picLever5.Bounds) Then
                    picLever5.Image = My.Resources.lever1
                    lblDoor5.Location = New Point(2000, 2000)
                End If
        End Select

        If picCharacter.Bounds.IntersectsWith(picExit.Bounds) Then
            MessageBox.Show("You've excaped the fourth level. Get ready for Level 5.", "Maze Game - Level 4")
            tmrCountdown.Enabled = False
            Me.Hide()
            frmLevel5.Show()
        End If

        If WallCollisionLvl4(picCharacter) Then
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
        Lvl4walls(0) = lblWall0
        Lvl4walls(1) = lblWall1
        Lvl4walls(2) = lblWall2
        Lvl4walls(3) = lblWall3
        Lvl4walls(4) = lblWall4
        Lvl4walls(5) = lblWall5
        Lvl4walls(6) = lblWall6
        Lvl4walls(7) = lblWall7
        Lvl4walls(8) = lblWall8
        Lvl4walls(9) = lblWall9
        Lvl4walls(10) = lblWall10
        Lvl4walls(11) = lblWall11
        Lvl4walls(12) = lblWall12
        Lvl4walls(13) = lblWall13
        Lvl4walls(14) = lblWall14
        Lvl4walls(15) = lblWall15
        Lvl4walls(16) = lblWall16
        Lvl4walls(17) = lblWall17
        Lvl4walls(18) = lblWall18
        Lvl4walls(19) = lblWall19
        Lvl4walls(20) = lblWall20
        Lvl4walls(21) = lblWall21
        Lvl4walls(22) = lblWall22
        Lvl4walls(23) = lblWall23
        Lvl4walls(24) = lblWall24
        Lvl4walls(25) = lblWall25
        Lvl4walls(26) = lblWall26
        Lvl4walls(27) = lblWall27
        Lvl4walls(28) = lblWall28
        Lvl4walls(29) = lblWall29
        Lvl4walls(30) = lblWall30
        Lvl4walls(31) = lblWall31
        Lvl4walls(32) = lblWall32
        Lvl4walls(33) = lblWall33
        Lvl4walls(34) = lblWall34
        Lvl4walls(35) = lblWall35
        Lvl4walls(36) = lblWall36
        Lvl4walls(37) = lblWall37
        Lvl4walls(38) = lblWall38
        Lvl4walls(39) = lblWall39
        Lvl4walls(40) = lblDoor1
        Lvl4walls(41) = lblDoor2
        Lvl4walls(42) = lblDoor3
        Lvl4walls(43) = lblDoor4
        Lvl4walls(44) = lblDoor5
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
            Dim dlgResult As DialogResult = MessageBox.Show("You ran out of time. Would you like to retry the level?", "Maze Game - Level 4", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgResult = Windows.Forms.DialogResult.Yes Then
                intSeconds = 105
                picCharacter.Location = New Point(12, 627)
                tmrCountdown.Enabled = True
            Else
                Me.Close()
                frmMainMenu.Show()
            End If
        End If
    End Sub
End Class