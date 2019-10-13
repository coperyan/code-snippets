Sub Password()


Dim Password As Variant
Password = Application.InputBox("Enter Password", "Password Protected")

Select Case Password
    Case Is = False
        'do nothing
    Case Is = "password"
        Worksheets("People").Range("A1").Value = "Passcode Correct"
    Case Else
        MsgBox "Incorrect Password"
        Worksheets("People").Range("A1").Value = "Passcode Incorrect"
End Select

Select Case Worksheets("People").Range("A1").Value
    Case "Passcode Correct"
        Worksheets("People").Visible = True
        Worksheets("People").Activate
    Case "Passcode Incorrect"
        Worksheets("People").Visible = False
        Worksheets("Tool").Activate
    Case Else:
        'do nothing
End Select

End Sub
