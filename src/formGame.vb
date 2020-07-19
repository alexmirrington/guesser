﻿Public Class formGame
    Private maxNum As Integer 'Maximum random number that could be generated by the program. Determined by levelDifficulty
    Private maxGuesses As Integer 'Maximum number of guesses, determined by levelDifficulty
    Private guessesRemaining As Integer 'Guesses remaining for the current game
    Private randomNum As Integer 'Random number produced by program
    Private playerGuess As Integer 'Guess entered by player
    Private score As Integer 'Score generated by game

    Private Sub formGame_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Determine maxGuesses and maxNum from levelDifficulty
        If levelDifficulty = "Normal" Then
            maxNum = 10
            maxGuesses = 3
        ElseIf levelDifficulty = "Epic" Then
            maxNum = 100
            maxGuesses = 5
        ElseIf levelDifficulty = "Legendary" Then
            maxNum = 1000
            maxGuesses = 9
        End If
        guessesRemaining = maxGuesses
        'Update labels
        lblGuessesRemaining.Text = "Guesses Remaining: " & guessesRemaining
        lblGameInstructions.Text = "Pick a Number Between 1 and " & maxNum
        lblFeedback.Text = ""
        'Generate a new random number
        randomNum = GenerateRandomNum(1, maxNum)
        'Set start score to maxNum
        score = maxNum
        'Load scores into RAM in ReadWriteData.vb
        LoadScores()
    End Sub

    Private Function GenerateRandomNum(lowerBound As Integer, upperBound As Integer)
        'Generate a new random number
        Randomize()
        Dim temp As Integer = CInt(Math.Floor((upperBound - lowerBound + 1) * Rnd())) + lowerBound 'Code from https://msdn.microsoft.com/en-us/library/f7s023d2%28v=vs.90%29.aspx, accessed 4.7.2015. temp is a Temporary variable for storing the randomly generated number.
        Return temp
    End Function

    Private Sub btnGuess_Click(sender As System.Object, e As System.EventArgs) Handles btnGuess.Click
        Dim guessOK As Boolean = IsValidGuess() 'Flag that is set to true when the guess has been validated.
        If guessOK = True Then
            UpdateScore()
            CompareGuess()
        End If
    End Sub

    Private Function IsValidGuess()
        'Check that the number in the text box is a positive integer between 1 and maxNum
        Try
            playerGuess = CInt(txtInputGuess.Text)
            If playerGuess < 1 Or playerGuess > maxNum Then
                MsgBox("Please insert a number between 1 and " & maxNum)
                txtInputGuess.Text = ""
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Please insert a number between 1 and " & maxNum)
            txtInputGuess.Text = ""
            Return False
        End Try
    End Function

    Private Sub CompareGuess()
        'Compare Player's guess to the number generated.
        If playerGuess > randomNum Then
            lblFeedback.Text = "Lower!"
            picArrowDown.Visible = True
            picArrowUp.Visible = False
            UpdateRemainingGuesses()
        ElseIf playerGuess < randomNum Then
            lblFeedback.Text = "Higher!"
            picArrowUp.Visible = True
            picArrowDown.Visible = False
            UpdateRemainingGuesses()
        Else
            lblFeedback.Text = "You Win!"
            picArrowUp.Visible = False
            picArrowDown.Visible = False
            'Write a new score record to file.
            CreateScoreRecord(levelDifficulty, playerName, score)
            SaveFile()
            'Display "You Win" message
            MsgBox("You Win! Your score was: " & score & "! Click OK to proceed to Hall of Fame.")
            formHallOfFame.Show()
            Me.Close()
        End If
    End Sub

    Private Sub UpdateScore()
        score = score - Math.Ceiling(Math.Abs((playerGuess - randomNum) / (maxGuesses - 1))) 'Player loses less score if they are closer to the target.
        'Note that minimum score occurs when randomNum = maxNum and player guesses 1 for all guesses except for the last guess, which they guess correctly.
        'This is a very rare case, but it means that 0 <= score <= maxNum always
    End Sub

    Private Sub UpdateRemainingGuesses()
        'Check if there are guesses left
        If guessesRemaining > 0 Then
            guessesRemaining = guessesRemaining - 1 'subtract 1 from remaining guesses
            lblGuessesRemaining.Text = "Guesses Remaining: " & guessesRemaining 'update label
            If guessesRemaining = 0 Then
                'Game Over
                lblFeedback.Text = "Out of Guesses!"
                picArrowUp.Visible = False
                picArrowDown.Visible = False
                MsgBox("Out of Guesses! The number was " & randomNum & "! Click OK to return to the Main Menu.")
                formMain.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        MsgBox("Pick a number between 1 and " & maxNum & ", and enter that number in the input box." & (Chr(13)) &
               "Press 'Guess!' to confirm your guess. If you guess correctly, you win the game." & (Chr(13)) &
               "If you guess incorrectly, you will be told whether your guess is higher or lower than the random number." & (Chr(13)) &
               "You lose the game when you run out of guesses." & (Chr(13)) & (Chr(13)) &
               "Good Luck!" & (Chr(13)) & (Chr(13)) &
               "Extra Tip: The closer each guess is to the random number and the fewer guesses you use, the better your score will be.")
    End Sub
End Class