    For Each area In Worksheets("PasteHere").Columns("B:B").SpecialCells(xlCellTypeBlanks)
        If area.Cells.Row <= ActiveSheet.UsedRange.Rows.Count Then
            area.Cells = Range(area.Address).Offset(-1, 0).Value
        End If
    Next area
