Public Class formLevelSelect
    Private Sub LevelSelect(sender As System.Object, e As System.EventArgs) Handles btnNormal.Click, btnEpic.Click, btnLegendary.Click
        levelDifficulty = sender.text 'Note that levelDifficulty will always be either "Normal", "Epic" or "Legendary"
        formGame.Show()
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        MsgBox("Changing the difficulty level changes the range of numbers and the number of guesses you are allowed:" & (Chr(13)) & (Chr(13)) &
               "Normal: Numbers between 1 and 10, 3 guesses." & (Chr(13)) &
               "Epic: Numbers between 1 and 100, 5 guesses." & (Chr(13)) &
               "Legendary: Numbers between 1 and 1000, 9 guesses.")
    End Sub
End Class