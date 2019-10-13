Sub SaveThePDF()
Dim wsA As Worksheet
Dim wbA As Workbook
Dim strName As String
Dim strPath As String
Dim strFile As String
Dim strPathFile As String
Dim myFile As Variant

Set wbA = ActiveWorkbook
Set wsA = ActiveSheet

strPath = wbA.Path & "\"

strName = wsA.Range("F1").Value & ".pdf"

strPathFile = strPath & strName

wsA.ExportAsFixedFormat _
    Type:=xlTypePDF, _
    Filename:=strPathFile, _
    Quality:=xlQualityStandard, _
    IncludeDocProperties:=True, _
    IgnorePrintAreas:=False, _
    OpenAfterPublish:=False

End Sub
