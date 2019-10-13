Sub ExecuteSproc()

'Creating variables
Dim conn As ADODB.Connection
Dim cmd As ADODB.Command

Set conn = New ADODB.Connection
conn.ConnectionString = "Provider=SQLOLEDB;Data Source=ServerName;Initial Catalog=DatabaseName;" & _
                  "Integrated Security=SSPI;"
conn.Open

Set cmd = New ADODB.Command
cmd.CommandTimeout = 400
cmd.ActiveConnection = conn
cmd.CommandType = adCmdStoredProc
cmd.CommandText = "usp_RandomStoredProcedure"
cmd.Parameters("@DATE").Value = Worksheets("Placeholders").Range("B1").Value
cmd.Execute
conn.Close

Set conn = Nothing
Set cmd = Nothing

End Sub
