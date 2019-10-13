Private Sub Worksheet_Change(ByVal Target As Range)
If Target.Address(True, True) = "$B$1" Then
    Select Case Target
        Case "Jan-17 Financials"
            Call JanSelection
        Case "Feb-17 Financials"
            Call FebSelection
        Case Else
            'Do Nothing
    End Select
End If

End Sub
