Dim lastrow As Long
Dim lastrowfinal As Long
Dim range1 As Range
Dim validationcell As Range

lastrow = Cells(Rows.Count, 2).End(xlUp).row
lastrowfinal = lastrow + 1

Range("B" & lastrowfinal).Value = InputBox("Enter employee name")
