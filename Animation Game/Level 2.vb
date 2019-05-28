Public Class frmLevel2

    Private intSeconds = 75


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
                If picCharacter.Bounds.IntersectsWith(picLever1.Bounds) Then
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
            MessageBox.Show("You've excaped the second level. Get ready for Level 3.", "Maze Game - Level 2")
            tmrCountdown.Enabled = False
            Me.Hide()
            frmLevel3.Show()
        End If

        If WallCollisionLvl2(picCharacter) Then
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
        Lvl2walls(0) = lblWall0
        Lvl2walls(1) = lblWall1
        Lvl2walls(2) = lblWall2
        Lvl2walls(3) = lblWall3
        Lvl2walls(4) = lblWall4
        Lvl2walls(5) = lblWall5
        Lvl2walls(6) = lblWall6
        Lvl2walls(7) = lblWall7
        Lvl2walls(8) = lblWall8
        Lvl2walls(9) = lblWall9
        Lvl2walls(10) = lblWall10
        Lvl2walls(11) = lblWall11
        Lvl2walls(12) = lblWall12
        Lvl2walls(13) = lblWall13
        Lvl2walls(14) = lblWall14
        Lvl2walls(15) = lblWall15
        Lvl2walls(16) = lblWall16
        Lvl2walls(17) = lblWall17
        Lvl2walls(18) = lblWall18
        Lvl2walls(19) = lblWall19
        Lvl2walls(20) = lblWall20
        Lvl2walls(21) = lblWall21
        Lvl2walls(22) = lblWall22
        Lvl2walls(23) = lblWall23
        Lvl2walls(24) = lblWall24
        Lvl2walls(25) = lblWall25
        Lvl2walls(26) = lblWall26
        Lvl2walls(27) = lblWall27
        Lvl2walls(28) = lblWall28
        Lvl2walls(29) = lblWall29
        Lvl2walls(30) = lblWall30
        Lvl2walls(31) = lblWall31
        Lvl2walls(32) = lblWall32
        Lvl2walls(33) = lblWall33
        Lvl2walls(34) = lblWall34
        Lvl2walls(35) = lblWall35
        Lvl2walls(36) = lblWall36
        Lvl2walls(37) = lblWall37
        Lvl2walls(38) = lblWall38
        Lvl2walls(39) = lblWall39
        Lvl2walls(40) = lblWall40
        Lvl2walls(41) = lblWall41
        Lvl2walls(42) = lblWall42
        Lvl2walls(43) = lblWall43
        Lvl2walls(44) = lblWall44
        Lvl2walls(45) = lblWall45
        Lvl2walls(46) = lblWall46
        Lvl2walls(47) = lblWall47
        Lvl2walls(48) = lblWall48
        Lvl2walls(49) = lblWall49
        Lvl2walls(50) = lblWall50
        Lvl2walls(51) = lblWall51
        Lvl2walls(52) = lblWall52
        Lvl2walls(53) = lblDoor1
        Lvl2walls(54) = lblDoor2
        Lvl2walls(55) = lblDoor3
        Lvl2walls(56) = lblDoor4
        Lvl2walls(57) = lblDoor5
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
            Dim dlgResult As DialogResult = MessageBox.Show("You ran out of time. Would you like to retry the level?", "Maze Game - Level 2", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgResult = Windows.Forms.DialogResult.Yes Then
                intSeconds = 75
                picCharacter.Location = New Point(12, 627)
                tmrCountdown.Enabled = True
            Else
                Me.Close()
                frmMainMenu.Show()
            End If
        End If
    End Sub
End Class