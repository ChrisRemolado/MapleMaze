Public Class frmAbout

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGame.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub
End Class