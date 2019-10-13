Private Sub Workbook_Open()
Worksheets("Rep List").Activate

Worksheets("Rep List").CheckBox1 = False
Worksheets("Rep List").CheckBox2 = False
Worksheets("Rep List").CheckBox3 = False
Worksheets("Rep List").CheckBox4 = False
Worksheets("Rep List").CheckBox5 = False
Worksheets("Rep List").CheckBox6 = False

MsgBox "Please filter reps."
End Sub
