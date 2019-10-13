Worksheets("Selections").Range("A2:A500").Clear

With UserForm2.ListBox2
    If .ListCount = 0 Then
        Worksheets("Selections").Range("A2:A500").Clear
    Else:  Worksheets("Selections").Range("A2").Resize(RowSize:=.ListCount).Value = .List
    
    End If
    
    End With
  MsgBox "This may take ~30 seconds."
  Call ChangeViews
  Me.Hide
End Sub