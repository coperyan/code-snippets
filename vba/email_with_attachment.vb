    Dim strlocation As String

    strlocation = "C:\Users\Administrator\Desktop\File.CSV"

    Dim OutApp As Object
    Dim OutMail As Object

    Set OutApp = CreateObject("Outlook.Application")
    Set OutMail = OutApp.CreateItem(0)

    On Error Resume Next
    With OutMail
        .to = "toemail1@email123.ocom"
        .CC = "ccemail1@email123.com"
        .BCC = "bccemail1@email123.com"
        .Subject = "Subject - " & Worksheets("Placeholders").Range("D7").Value
        .Body = "Bob," & vbNewLine & _
                vbNewLine & _
                "Please see the attached file." & vbNewLine & _
                vbNewLine & _
                "Thank you, " & vbNewLine & _
                "Ryan Cope " & vbNewLine & _
                "Title " & vbNewLine & _
                "Phone Number"
        .Attachments.Add (strlocation)
        .Send
    End With
    On Error GoTo 0

    Set OutMail = Nothing
    Set OutApp = Nothing



End Sub
