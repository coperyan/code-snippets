Sub CreatePastedSht()
Dim Name As String
Name = "Copy File"
relativePath = ThisWorkbook.Path & "\" & Name
ThisWorkbook.Sheets("Sheet1").Copy
ActiveWorkbook.Sheets("Sheet1").Range("B2:N1000").Copy
ActiveWorkbook.Sheets("Sheet1").Range("B2:N1000").PasteSpecial xlPasteValues
ActiveWorkbook.SaveAs Filename:=relativePath
End Sub
