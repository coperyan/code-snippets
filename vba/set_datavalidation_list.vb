Set range2 = Worksheets("Placeholders").Range("W1:W11")

If Worksheets("Placeholders").Range("A3") = "1" Then
With Worksheets("Labor Exceptions").Range("F3").Validation
    .Delete 'delete previous validation
    .Add Type:=xlValidateList, AlertStyle:=xlValidAlertStop, _
        Formula1:="='" & "Placeholders" & "'!" & range2.Address 'referencing existing validation
End With
Else:
End If