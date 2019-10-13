Sub ExportFileWithImages()

Dim Wb As Workbook
Dim Name As String
Dim strPath As String
Dim strName As String
Dim strFinal As String

Set Wb = ActiveWorkbook

strPath = Wb.Path & "\"

strName = Worksheets("Data").Range("B9").Value

strFinal = strPath & strName

If Worksheets("Data").Range("B5").Value = 1 Then
    Sheets(Array(Sheet15.Name, Sheet16.Name, Sheet17.Name, Sheet18.Name, Sheet19.Name, Sheet20.Name, Sheet22.Name)).Copy
Else:
    Sheets(Array(Sheet15.Name, Sheet16.Name, Sheet17.Name, Sheet18.Name, Sheet19.Name, Sheet22.Name)).Copy
End If

ActiveWorkbook.SaveAs Filename:=strFinal
ActiveWorkbook.Close True


End Sub