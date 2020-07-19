Public Class formHallOfFame
    Private arrRecordsToDisplay(0) As ScoreRecord 'List of data from previously won games, filtered/sorted appropriately.

    Private Sub btnBackToMain_Click(sender As System.Object, e As System.EventArgs) Handles btnBackToMain.Click
        formMain.Show()
        Me.Close()
    End Sub

    Private Sub formHallOfFame_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Show scores for the current player
        LoadScores()
        arrRecordsToDisplay = arrScores
        arrRecordsToDisplay = SortScores(arrRecordsToDisplay)
        arrRecordsToDisplay = FilterScoresByCurrentPlayer(arrRecordsToDisplay)
        DisplayScoresByPlayer(arrRecordsToDisplay)
    End Sub

    Private Sub ScoreButtonClick(sender As System.Object, e As System.EventArgs) Handles btnNormalScores.Click, btnEpicScores.Click, btnLegendaryScores.Click, btnMyScores.Click
        LoadScores() 'Load scores from text file into RAM
        arrRecordsToDisplay = arrScores 'copy values from public arrScores into private arrRecordsToDisplay before further processing to avoid corrupting permanent data.
        arrRecordsToDisplay = SortScores(arrRecordsToDisplay) 'Sort records by the score value, from highest to lowest.

        If sender.tag = 3 Then
            'btnMyScores was clicked
            arrRecordsToDisplay = FilterScoresByCurrentPlayer(arrRecordsToDisplay)
            DisplayScoresByPlayer(arrRecordsToDisplay)
        Else
            'btnNormalScores, btnEpicScores or btnLegendaryScores was clicked
            arrRecordsToDisplay = FilterScoresByDifficulty(arrRecordsToDisplay, sender.text) 'Note that sender.text returns either "Normal", "Epic" or "Legendary"
            DisplayScoresByDifficulty(arrRecordsToDisplay, sender.text) 'Note that sender.text returns either "Normal", "Epic" or "Legendary"
        End If
    End Sub

    Private Function SortScores(arrItems() As ScoreRecord)
        'Sort all scores (arrScores) from highest to lowest.
        Dim firstIndex As Integer = 0 'The first index to start the sort from
        Dim lastIndex As Integer = UBound(arrItems) 'The last index in the array to be sorted
        Dim endUnsortedIndex As Integer = firstIndex 'The number of items in the array that have already been sorted
        Dim currentIndex As Integer 'The index of the array element that is currently being sorted
        Dim maxItem As ScoreRecord 'The scoreRecord with the maximum score value
        Dim maxIndex As Integer 'The index of the scoreRecord with the maximum score value.
        Dim temp As ScoreRecord 'Temporary variable for holding data while elements in the array are reshuffled.

        While endUnsortedIndex < lastIndex
            currentIndex = endUnsortedIndex
            maxItem = arrItems(currentIndex)
            maxIndex = currentIndex
            While currentIndex < lastIndex
                currentIndex = currentIndex + 1
                If arrItems(currentIndex).score > maxItem.score Then
                    maxItem = arrItems(currentIndex)
                    maxIndex = currentIndex
                End If
            End While
            'swap items
            temp = arrItems(maxIndex)
            arrItems(maxIndex) = arrItems(endUnsortedIndex)
            arrItems(endUnsortedIndex) = temp
            endUnsortedIndex = endUnsortedIndex + 1
        End While
        Return arrItems
    End Function

    Private Function FilterScoresByCurrentPlayer(arrScoresToFilter() As ScoreRecord)
        'Filter the records by the current player
        Dim arrToReturn(0) As ScoreRecord 'The array to be returned after processing

        For i = 0 To UBound(arrScoresToFilter)
            If arrScoresToFilter(i).playerName = playerName Then
                Dim newID As Integer = UBound(arrToReturn) + 1
                ReDim Preserve arrToReturn(newID)
                arrToReturn(newID) = arrScoresToFilter(i)
            End If
        Next
        Return arrToReturn
    End Function

    Private Function FilterScoresByDifficulty(arrScoresToFilter() As ScoreRecord, filterDifficulty As String)
        'Note that for this function to return anything, filterDifficulty must be either "Normal", "Epic" or "Legendary"
        Dim arrToReturn(0) As ScoreRecord 'The array to be returned after processing
        For i = 0 To UBound(arrScoresToFilter)
            If arrScoresToFilter(i).difficulty = filterDifficulty Then
                Dim newID As Integer = UBound(arrToReturn) + 1 'The next ID in the array arrToReturn that we want to assign to.
                ReDim Preserve arrToReturn(newID)
                arrToReturn(newID) = arrScoresToFilter(i)
            End If
        Next
        Return arrToReturn
    End Function

    Private Sub DisplayScoresByDifficulty(arrToDisplay() As ScoreRecord, difficulty As String)
        lstScores.Items.Clear()
        lstScores.Items.Add(difficulty) 'Display the difficulty that has been selected
        lstScores.Items.Add("")
        lstScores.Items.Add("NO:" & vbTab & "PLAYER:" & vbTab & vbTab & "SCORE:")
        If UBound(arrToDisplay) <= 10 Then
            'i.e. we want to display all scores in this case
            For i = 1 To UBound(arrToDisplay) 'Note that we start from 1 as the first element in the array is always null, the useful data comes after that
                If arrToDisplay(i).playerName.Length < 9 Then
                    'We need two vbTab characters to maintain alignment
                    lstScores.Items.Add(i & vbTab & arrToDisplay(i).playerName & vbTab & vbTab & arrToDisplay(i).score)
                Else
                    'We need one vbTab character to maintain alignment
                    lstScores.Items.Add(i & vbTab & arrToDisplay(i).playerName & vbTab & arrToDisplay(i).score)
                End If
            Next
        Else
            'i.e. we only want to display the top 10 scores
            For i = 1 To 10 'Note that we start from 1 as the first element in the array is always null, the useful data comes after that
                If arrToDisplay(i).playerName.Length < 9 Then
                    'We need two vbTab characters to maintain alignment
                    lstScores.Items.Add(i & vbTab & arrToDisplay(i).playerName & vbTab & vbTab & arrToDisplay(i).score)
                Else
                    'We need one vbTab character to maintain alignment
                    lstScores.Items.Add(i & vbTab & arrToDisplay(i).playerName & vbTab & arrToDisplay(i).score)
                End If
            Next
        End If

    End Sub

    Private Sub DisplayScoresByPlayer(arrToDisplay() As ScoreRecord)
        lstScores.Items.Clear()
        lstScores.Items.Add("My Scores")
        lstScores.Items.Add("")
        If UBound(arrToDisplay) = 0 Then
            'i.e. no records to display
            lstScores.Items.Add("You have not set any highscores yet!")
        Else
            lstScores.Items.Add("NO:" & vbTab & "DIFFICULTY:" & vbTab & "SCORE:")
            For i = 1 To UBound(arrToDisplay) 'Note that we start from 1 as the first element in the array is always null, the useful data comes after that
                If arrToDisplay(i).difficulty.Length < 9 Then
                    'We need two vbTab characters to maintain alignment
                    lstScores.Items.Add(i & vbTab & arrToDisplay(i).difficulty & vbTab & vbTab & arrToDisplay(i).score)
                Else
                    'We need one vbTab character to maintain alignment
                    lstScores.Items.Add(i & vbTab & arrToDisplay(i).difficulty & vbTab & arrToDisplay(i).score)
                End If
            Next
        End If
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        MsgBox("The buttons at the top of the screen sort the highscores according to difficulty level or the current player." & (Chr(13)) &
               "Press 'Normal', 'Epic' or 'Legendary' to view the Top 10 scores for that difficulty level." & (Chr(13)) &
               "Press 'My Scores' to view all of the previous scores for the player you are logged in as." & (Chr(13)) &
               "Press 'Back To Main Menu' to return to the main menu.")
    End Sub
End Class