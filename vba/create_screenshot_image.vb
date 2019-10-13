Sub CreateImages()

Worksheets("Sheet1").Range("V2:AI34").CopyPicture xlScreen, xlBitmap
Worksheets("ShapeSheet").Paste _
    Destination:=Worksheets("RADIATOR").Range("A2")



End Sub
