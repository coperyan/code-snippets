Sub SalesInput()


Dim Sales As Variant
Dim SalesNumeric As Variant
Sales = Application.InputBox("Enter Sales")

Worksheets("Sheet1").Range("CF2").Value = Sales

SalesNumeric = Worksheets("Sheet1").Range("CH2").Value

Select Case Sales
    Case Is = False
        'do nothing
    Case Is = "True"
    Case Is = "False"
        MsgBox "Please enter a numerical value"
    Case Else:
End Select

End Sub
