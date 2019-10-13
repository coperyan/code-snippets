Sub ToggleAddEnds()
Application.ScreenUpdating = False
    If Worksheets("Bonus").Rows("17:20").Hidden = False Then
        Worksheets("Bonus").Rows("17:20").Hidden = True
        Worksheets("Bonus").Rows("38:41").Hidden = True
        Worksheets("Bonus").Rows("59:62").Hidden = True
        Worksheets("Bonus").Rows("80:83").Hidden = True
        Worksheets("Bonus").Rows("101:104").Hidden = True
        Worksheets("Bonus").Rows("122:125").Hidden = True
        
    Else:       Worksheets("Bonus").Rows("17:20").Hidden = False
        Worksheets("Bonus").Rows("38:41").Hidden = False
        Worksheets("Bonus").Rows("59:62").Hidden = False
        Worksheets("Bonus").Rows("80:83").Hidden = False
        Worksheets("Bonus").Rows("101:104").Hidden = False
        Worksheets("Bonus").Rows("122:125").Hidden = False
        
    End If
Application.ScreenUpdating = True
End Sub