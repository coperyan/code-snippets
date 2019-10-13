Private Sub UserForm_Initialize()
Dim Rng As Range
Dim i As Long

Dim CountLng As Long

CountLng = Worksheets("Sheet1").Range("A2:A500").Rows.Count

Me.ListBox1.RowSource = ""
Set Rng = Range("Data!A2:A1000")
For i = 1 To Rng.Rows.Count
    If Rng(i) <> "" Then
        Me.ListBox1.AddItem Rng(i)
    End If
Next i

Dim Rng2 As Range
Dim k As Long

Me.ListBox2.RowSource = ""
Set Rng2 = Range("Selections!A2:A500")
For k = 1 To Rng2.Rows.Count
    If Rng2(k) <> "" Then
        Me.ListBox2.AddItem Rng2(k)
    End If
Next k


End Sub
