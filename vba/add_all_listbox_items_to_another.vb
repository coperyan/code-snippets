Private Sub CommandButton1_Click()
'This adds all items selected in the first listbox to the second one, looping through to make sure we're not adding dupes.

For i = 0 To ListBox1.ListCount - 1
    If ListBox1.Selected(i) = True Then ListBox2.AddItem ListBox1.List(i)
Next i

Dim k As Long
Dim j As Long
Dim nodupes As New Collection
Dim Swap1, Swap2, Item

With UserForm2.ListBox2

    For k = 0 To .ListCount - 1
        On Error Resume Next
        nodupes.Add .List(k), CStr(.List(k))
    Next k
    
    On Error GoTo 0
    
    .Clear
    
 
    For Each Item In nodupes
        .AddItem Item
    Next Item
End With
End Sub