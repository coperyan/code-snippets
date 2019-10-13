Private Sub CheckBox1_Click()
 If CheckBox1 = True Then
        Worksheets("Sheet1").Rows("5:25").Hidden = False
        Worksheets("Sheet1").Rows("17:20").Hidden = True
        Call HideEmptyRows
    Else: Worksheets("Sheet1").Rows("5:25").Hidden = True
    End If
End Sub
