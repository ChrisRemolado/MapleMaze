Public Class frmLevel5

    Private intSeconds = 120
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
                    picCharacter.Location = New Point(167, 361)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter1b.Bounds) Then
                    picCharacter.Location = New Point(260, 551)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter2a.Bounds) Then
                    picCharacter.Location = New Point(898, 566)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter2b.Bounds) Then
                    picCharacter.Location = New Point(460, 361)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter3a.Bounds) Then
                    picCharacter.Location = New Point(552, 635)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter3b.Bounds) Then
                    picCharacter.Location = New Point(915, 90)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter4a.Bounds) Then
                    picCharacter.Location = New Point(298, 5)
                ElseIf picCharacter.Bounds.IntersectsWith(picTeleporter4b.Bounds) Then
                    picCharacter.Location = New Point(459, 252)
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
            MessageBox.Show("You've excaped the fifth level. Get ready for Level 6.", "Maze Game - Level 5")
            tmrCountdown.Enabled = False
            Me.Hide()
            frmLevel6.Show()
        End If

        If WallCollisionLvl5(picCharacter) Then
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
        ElseIf picCharacter.Bounds.IntersectsWith(picCookie2.Bounds) Then
            picCookie2.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        ElseIf picCharacter.Bounds.IntersectsWith(picCookie3.Bounds) Then
            picCookie3.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        ElseIf picCharacter.Bounds.IntersectsWith(picCookie4.Bounds) Then
            picCookie4.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        ElseIf picCharacter.Bounds.IntersectsWith(picCookie5.Bounds) Then
            picCookie5.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        ElseIf picCharacter.Bounds.IntersectsWith(picCookie6.Bounds) Then
            picCookie6.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        ElseIf picCharacter.Bounds.IntersectsWith(picCookie7.Bounds) Then
            picCookie7.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        ElseIf picCharacter.Bounds.IntersectsWith(picCookie8.Bounds) Then
            picCookie8.Location = New Point(2000, 2000)
            intCookies = intCookies + 1
        End If

        lblCoins.Text = intCookies & " / 8 coins"

        If intCookies = 8 Then
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
        Lvl5walls(0) = lblWall0
        Lvl5walls(1) = lblWall1
        Lvl5walls(2) = lblWall2
        Lvl5walls(3) = lblWall3
        Lvl5walls(4) = lblWall4
        Lvl5walls(5) = lblWall5
        Lvl5walls(6) = lblWall6
        Lvl5walls(7) = lblWall7
        Lvl5walls(8) = lblWall8
        Lvl5walls(9) = lblWall9
        Lvl5walls(10) = lblWall10
        Lvl5walls(11) = lblWall11
        Lvl5walls(12) = lblWall12
        Lvl5walls(13) = lblWall13
        Lvl5walls(14) = lblWall14
        Lvl5walls(15) = lblWall15
        Lvl5walls(16) = lblWall16
        Lvl5walls(17) = lblWall17
        Lvl5walls(18) = lblWall18
        Lvl5walls(19) = lblWall19
        Lvl5walls(20) = lblWall20
        Lvl5walls(21) = lblWall21
        Lvl5walls(22) = lblWall22
        Lvl5walls(23) = lblWall23
        Lvl5walls(24) = lblWall24
        Lvl5walls(25) = lblWall25
        Lvl5walls(26) = lblWall26
        Lvl5walls(27) = lblWall27
        Lvl5walls(28) = lblWall28
        Lvl5walls(29) = lblDoor1
        Lvl5walls(30) = lblDoor2
        Lvl5walls(31) = lblDoor3
        Lvl5walls(32) = lblDoor4
        Lvl5walls(33) = lblDoor5
        Lvl5walls(34) = lblCoinDoor
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
            Dim dlgResult As DialogResult = MessageBox.Show("You ran out of time. Would you like to retry the level?", "Maze Game - Level 5", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgResult = Windows.Forms.DialogResult.Yes Then
                intSeconds = 120
                picCharacter.Location = New Point(12, 627)
                tmrCountdown.Enabled = True
            Else
                Me.Close()
                frmMainMenu.Show()
            End If
        End If
    End Sub
End Class