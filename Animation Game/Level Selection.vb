Public Class frmLevelSelection

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnLevel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel1.Click
        Me.Hide()
        frmLevel1.Show()
    End Sub

    Private Sub btnLevel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel2.Click
        Me.Hide()
        frmLevel2.Show()
    End Sub

    Private Sub btnLevel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel3.Click
        Me.Hide()
        frmLevel3.Show()
    End Sub

    Private Sub btnLevel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel4.Click
        Me.Hide()
        frmLevel4.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel5.Click
        Me.Hide()
        frmLevel5.Show()
    End Sub

    Private Sub btnLevel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel6.Click
        Me.Hide()
        frmLevel6.Show()
    End Sub
End Class