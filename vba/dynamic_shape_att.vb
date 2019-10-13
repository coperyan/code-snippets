Sub FormatArrows()

'Top arrow first
If Worksheets("Summary").Range("D5").Value <= 6 Then
    Worksheets("Summary").Shapes("Arrow: Right 7").Rotation = 90
    Worksheets("Summary").Shapes("Arrow: Right 7").Fill.ForeColor.RGB = RGB(255, 0, 0)
Else:
End If




End Sub
