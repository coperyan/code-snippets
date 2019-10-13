With Worksheets("Sheet1").PivotTables("PivotTable1").PivotFields("CustomerName")
    For i = 1 To .PivotItems.Count
        If i >= 1 And i <= 2 Then
            .PivotItems(i).Visible = True
        Else
            .PivotItems(i).Visible = False
        End If
    Next i
End With
