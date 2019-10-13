Private Sub Worksheet_Change(ByVal Target As Range)
If Not Intersect(Target, Range("$B$1")) Is Nothing Then
Call ClearForecastFilters
End If
End Sub
