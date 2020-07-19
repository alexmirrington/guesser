Imports System.IO

Module ReadWriteData
    'Define new ScoreRecord structure for keeping track of scores and players, etc.
    Public Structure ScoreRecord
        Dim scoreID As Integer 'ID for reference
        Dim difficulty As String 'The difficulty level that the game was played on
        Dim playerName As String 'the player who set the score
        Dim score As Integer 'The score for the game
    End Structure

    Public arrScores(0) As ScoreRecord 'List of all data from previously won games.
    Public filePath As String = Application.StartupPath 'The file path of the project

    Public Sub LoadScores()
        'Loads order data from text file and places it in the "arrScores" array
        arrScores = {} 'reset arrScores, in case LoadScores() has previously been called
        Dim oRead As System.IO.StreamReader 'For sequentially accessing the contents of text files.
        Dim lineIn As String 'The line read by oRead that is then processed.
        Dim tmp 'Temporary variable for storing data while it is processed and placed into arrScores.

        oRead = File.OpenText(filePath & "\scores.txt") 'Locate text file

        While oRead.Peek <> -1 'while there are still lines left to read 
            lineIn = oRead.ReadLine() 'Set lineIn to current line
            If Mid(lineIn, 1, 1) <> "" Then 'if there are characters on the line
                tmp = Split(lineIn, "|") 'Split the line, separating the elements by the “|” character
                ReDim Preserve arrScores(UBound(arrScores) + 1) 'Open up a new element in arrScores array
                'Assign to the element in arrScores that we just created
                arrScores(CInt(tmp(0))).scoreID = tmp(0)
                arrScores(CInt(tmp(0))).difficulty = tmp(1)
                arrScores(CInt(tmp(0))).playerName = tmp(2)
                arrScores(CInt(tmp(0))).score = tmp(3)
            End If
        End While
        oRead.Close()
    End Sub

    Private Function FindNextID() 'sets id for next record +1
        Dim x As Integer = 0 'The previous last ID in arrScores
        For i = 0 To UBound(arrScores)
            If arrScores(i).scoreID > x Then
                x = arrScores(i).scoreID
            End If
        Next
        FindNextID = x + 1
    End Function

    Public Sub CreateScoreRecord(ByVal difficulty As String, ByVal playerName As String, ByVal score As Integer)
        Dim NextID As Integer = FindNextID() 'The next ID in the array arrScores that we want to assign to.
        ReDim Preserve arrScores(NextID) 'opens up another element at end of array, ready for accepting next record.
        'assign to this new element of the array that we just created.
        arrScores(NextID).scoreID = NextID
        arrScores(NextID).difficulty = difficulty
        arrScores(NextID).playerName = playerName
        arrScores(NextID).score = score
    End Sub

    Public Sub SaveFile()
        Dim sep As Char = "|" 'The separator character between elements in the text file.
        Dim writeLine As String = "" 'The string to be written to file
        For i = 0 To UBound(arrScores)
            writeLine &= arrScores(i).scoreID & sep & arrScores(i).difficulty & sep & arrScores(i).playerName & sep & arrScores(i).score & vbCrLf
        Next
        'override the text file
        File.WriteAllText(filePath & "\scores.txt", writeLine)
    End Sub
End Module
