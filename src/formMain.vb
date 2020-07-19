Public Class formMain
    Private Sub FormMainLoadEvent(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & playerName & "!" 'Display welcome message
    End Sub
    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        formLevelSelect.Show()
        Me.Close()
    End Sub

    Private Sub btnHallOfFame_Click(sender As System.Object, e As System.EventArgs) Handles btnHallOfFame.Click
        formHallOfFame.Show()
        Me.Close()
    End Sub

    Private Sub btnSwitchPlayer_Click(sender As System.Object, e As System.EventArgs) Handles btnSwitchPlayer.Click
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        MsgBox("Press 'Play' to play Minimax." & (Chr(13)) &
               "Press 'Hall of Fame' to view highscores." & (Chr(13)) &
               "Press 'Switch User' to change your playername.")
    End Sub
End Class