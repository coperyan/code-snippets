Sub HideEmptyRows()
'We want this to be a cycling button
'People can show unused rows (if they're hidden) and hide (if they're not hidden)
Dim rngBlnk As Range
Dim rngOne As Range
Dim rngTwo As Range
Dim rngThree As Range
Dim rngFour As Range
Dim rngFive As Range

On Error Resume Next 'in case no blanks are present...
Set rngOne = Range("B8:B21").SpecialCells(xlCellTypeBlanks)
Set rngTwo = Range("B29:B42").SpecialCells(xlCellTypeBlanks)
Set rngThree = Range("B50:B63").SpecialCells(xlCellTypeBlanks)
Set rngFour = Range("B71:B84").SpecialCells(xlCellTypeBlanks)
Set rngFive = Range("B92:B105").SpecialCells(xlCellTypeBlanks)
Set rngBlnk = Union(rngOne, rngTwo, rngThree, rngFour, rngFive)
On Error GoTo 0

Application.ScreenUpdating = False

If Worksheets("Bonus").Shapes("Rectangle 7").TextFrame.Characters.Text = "Hide Unused Rows" Then
    If Not rngBlnk Is Nothing Then
        Debug.Print rngBlnk.Address()
        rngBlnk.EntireRow.Hidden = True
        Worksheets("Bonus").Shapes("Rectangle 7").TextFrame.Characters.Text = "Show Unused Rows"
    End If
Else:
        If Not rngBlnk Is Nothing Then
        Debug.Print rngBlnk.Address()
        rngBlnk.EntireRow.Hidden = False
        Call ToggleAddEnds
        Worksheets("Bonus").Shapes("Rectangle 7").TextFrame.Characters.Text = "Hide Unused Rows"
          End If
End If

Application.ScreenUpdating = True

End Sub
