Public Class formSplash
    Private Sub StartGame(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        formLogin.Show()
        Me.Hide()
    End Sub
End Class
