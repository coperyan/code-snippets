Sub ToggleOnFifthWeek()
    If Worksheets("Placeholders").Range("K11") = 5 Then
        Worksheets("Forecast Detail").Columns("I:I").Hidden = False
        Worksheets("Forecast Detail").Columns("T:T").Hidden = False
        Worksheets("Forecast Detail").Columns("AE:AE").Hidden = False
        Worksheets("Forecast Detail").Columns("AP:AP").Hidden = False
        Worksheets("Forecast Detail").Columns("BA:BA").Hidden = False
        Worksheets("Forecast Detail").Columns("BL:BL").Hidden = False
        Worksheets("Forecast Detail").Columns("BW:BW").Hidden = False
    Else: Worksheets("Forecast Detail").Columns("I:I").Hidden = True
        Worksheets("Forecast Detail").Columns("T:T").Hidden = True
        Worksheets("Forecast Detail").Columns("AE:AE").Hidden = True
        Worksheets("Forecast Detail").Columns("AP:AP").Hidden = True
        Worksheets("Forecast Detail").Columns("BA:BA").Hidden = True
        Worksheets("Forecast Detail").Columns("BL:BL").Hidden = True
        Worksheets("Forecast Detail").Columns("BW:BW").Hidden = True
    End If
End Sub