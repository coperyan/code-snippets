Sub ExecuteSQLPasteData()

'Clearing old contents
Worksheets("Data").Range("A2:AZ50000").ClearContents

'Starting connection

Dim conn As ADODB.Connection
Dim rs As ADODB.Recordset
Dim sConnString As String



'Creating connection string
    sConnString = "Provider=SQLOLEDB;Data Source=ServerName;" & _
                  "Integrated Security=SSPI;"



'Create connection & recordset objects
Set conn = New ADODB.Connection
Set rs = New ADODB.Recordset

'Open the connection and execute
conn.Open sConnString

'Sets the timeout to wait 400 seconds rather than 30 secs
conn.CommandTimeout = 400

'Declare the string to be the query you want
Set rs = conn.Execute(" SELECT * " & _
                        " FROM Table " & _
                        " WHERE Date BETWEEN '" & Worksheets("Placeholders").Range("B3").Value & "' AND '" & Worksheets("Placeholders").Range("C3").Value & "'" & _
                        " AND Name IN ( " & Worksheets("Placeholders").Range("AC3").Value & " ) " & _
                        ";")

'Pasting data found in rs variable
ActiveWorkbook.Sheets("Data").Range("A2").CopyFromRecordset rs

'Close recordset
rs.Close

'Clean up
If CBool(conn.State And adStateOpen) Then conn.Close
Set conn = Nothing
Set rs = Nothing

End Sub
