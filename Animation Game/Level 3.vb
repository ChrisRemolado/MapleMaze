Public Class frmLevel3

    Private intSeconds = 99
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
        End Select

        If picCharacter.Bounds.IntersectsWith(picExit.Bounds) Then
            MessageBox.Show("You've excaped the third level. Get ready for Level 4.", "Maze Game - Level 3")
            tmrCountdown.Enabled = False
            Me.Hide()
            frmLevel4.Show()
        End If

        If WallCollisionLvl3(picCharacter) Then
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
        End If

        lblCoins.Text = intCookies & " / 7 coins"

        If intCookies = 7 Then
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
        Lvl3walls(0) = lblWall0
        Lvl3walls(1) = lblWall1
        Lvl3walls(2) = lblWall2
        Lvl3walls(3) = lblWall3
        Lvl3walls(4) = lblWall4
        Lvl3walls(5) = lblWall5
        Lvl3walls(6) = lblWall6
        Lvl3walls(7) = lblWall7
        Lvl3walls(8) = lblWall8
        Lvl3walls(9) = lblWall9
        Lvl3walls(10) = lblWall10
        Lvl3walls(11) = lblWall11
        Lvl3walls(12) = lblWall12
        Lvl3walls(13) = lblWall13
        Lvl3walls(14) = lblWall14
        Lvl3walls(15) = lblWall15
        Lvl3walls(16) = lblWall16
        Lvl3walls(17) = lblWall17
        Lvl3walls(18) = lblWall18
        Lvl3walls(19) = lblWall19
        Lvl3walls(20) = lblWall20
        Lvl3walls(21) = lblWall21
        Lvl3walls(22) = lblWall22
        Lvl3walls(23) = lblWall23
        Lvl3walls(24) = lblWall24
        Lvl3walls(25) = lblWall25
        Lvl3walls(26) = lblWall26
        Lvl3walls(27) = lblWall27
        Lvl3walls(28) = lblWall28
        Lvl3walls(29) = lblWall29
        Lvl3walls(30) = lblWall30
        Lvl3walls(31) = lblWall31
        Lvl3walls(32) = lblWall32
        Lvl3walls(33) = lblWall33
        Lvl3walls(34) = lblWall34
        Lvl3walls(35) = lblWall35
        Lvl3walls(36) = lblWall36
        Lvl3walls(37) = lblCoinDoor
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
            Dim dlgResult As DialogResult = MessageBox.Show("You ran out of time. Would you like to retry the level?", "Maze Game - Level 3", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dlgResult = Windows.Forms.DialogResult.Yes Then
                intSeconds = 99
                picCharacter.Location = New Point(12, 627)
                tmrCountdown.Enabled = True
            Else
                Me.Close()
                frmMainMenu.Show()
            End If
        End If
    End Sub
End Class