If Sheets("Targets").AutoFilterMode = True Then
    'Do Nothing
Else
Sheets("Targets").Range("A1:L1").AutoFilter
End If