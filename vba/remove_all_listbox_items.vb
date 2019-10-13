Private Sub CommandButton2_Click()
'Removes all selected items in the second listbox

Dim counter As Integer
counter = 0

For i = 0 To ListBox2.ListCount - 1
    If ListBox2.Selected(i - counter) Then
        ListBox2.RemoveItem (i - counter)
        counter = counter + 1
    End If
Next i

CheckBox2.Value = False

End Sub