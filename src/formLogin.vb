Public Class formLogin
    Private Sub SubmitPlayername(sender As System.Object, e As System.EventArgs) Handles btnSubmitPlayername.Click
        If txtInputPlayername.Text = "" Then 'i.e. nothing in the text box
            MsgBox("Please Enter a Playername!")
        ElseIf txtInputPlayername.Text.Length > 16 Then 'i.e. playername too long
            MsgBox("Playername must be less than or equal to 16 characters long")
        Else
            playerName = txtInputPlayername.Text 'set playerName variable to what's in the textbox
            txtInputPlayername.Text = "" 'Reset textbox
            formMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ClearPlayername(sender As System.Object, e As System.EventArgs) Handles btnClearPlayername.Click
        txtInputPlayername.Text = "" 'Reset textbox
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        MsgBox("The playername that you choose is the one that will be displayed in the Hall of Fame. Choosing the same playername each time you play will also allow you to see all of your previous scores in the Hall of Fame.")
    End Sub
End Class