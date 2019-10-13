Private Sub CheckBox2_Click()
'This selects all items in the second listbox

If CheckBox2.Value = True Then
    For i = 0 To ListBox2.ListCount - 1
        ListBox2.Selected(i) = True
    Next i
End If

If CheckBox2.Value = False Then
    For i = 0 To ListBox2.ListCount - 1
        ListBox2.Selected(i) = False
    Next i
End If
End Sub