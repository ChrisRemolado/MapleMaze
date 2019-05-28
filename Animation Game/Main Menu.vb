Public Class frmMainMenu

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        charStandWest(0) = My.Resources.stand1_0
        charStandWest(1) = My.Resources.stand1_1
        charStandWest(2) = My.Resources.stand1_2
        charStandWest(3) = My.Resources.stand1_3
        charStandWest(4) = My.Resources.stand1_4

        charStandEast(0) = New Bitmap(My.Resources.stand1_0)
        charStandEast(1) = New Bitmap(My.Resources.stand1_1)
        charStandEast(2) = New Bitmap(My.Resources.stand1_2)
        charStandEast(3) = New Bitmap(My.Resources.stand1_3)
        charStandEast(4) = New Bitmap(My.Resources.stand1_4)
        charStandEast(0).RotateFlip(RotateFlipType.RotateNoneFlipX)
        charStandEast(1).RotateFlip(RotateFlipType.RotateNoneFlipX)
        charStandEast(2).RotateFlip(RotateFlipType.RotateNoneFlipX)
        charStandEast(3).RotateFlip(RotateFlipType.RotateNoneFlipX)
        charStandEast(4).RotateFlip(RotateFlipType.RotateNoneFlipX)

        charWalkWest(0) = My.Resources.walk1_0
        charWalkWest(1) = My.Resources.walk1_1
        charWalkWest(2) = My.Resources.walk1_2
        charWalkWest(3) = My.Resources.walk1_3

        charWalkEast(0) = New Bitmap(My.Resources.walk1_0)
        charWalkEast(1) = New Bitmap(My.Resources.walk1_1)
        charWalkEast(2) = New Bitmap(My.Resources.walk1_2)
        charWalkEast(3) = New Bitmap(My.Resources.walk1_3)
        charWalkEast(0).RotateFlip(RotateFlipType.RotateNoneFlipX)
        charWalkEast(1).RotateFlip(RotateFlipType.RotateNoneFlipX)
        charWalkEast(2).RotateFlip(RotateFlipType.RotateNoneFlipX)
        charWalkEast(3).RotateFlip(RotateFlipType.RotateNoneFlipX)

        charClimbNorth(0) = My.Resources.ladder_0
        charClimbNorth(1) = My.Resources.ladder_1
        charClimbSouth(0) = My.Resources.ladder_0
        charClimbSouth(1) = My.Resources.ladder_1
    End Sub
    Private Sub tmrStand_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStand.Tick
        If intCharacterDirection = WEST Then
            picCharacter.Image = ChangeImage(charStandWest)
        ElseIf intCharacterDirection = EAST Then
            picCharacter.Image = ChangeImage(charStandEast)
        End If
    End Sub

    Private Sub btnStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGame.Click
        Me.Hide()
        frmLevel1.Show()
    End Sub

    Private Sub btnLevelSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevelSelection.Click
        Me.Hide()
        frmLevelSelection.Show()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Me.Hide()
        frmHelp.Show()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Me.Hide()
        frmAbout.Show()
    End Sub
End Class
