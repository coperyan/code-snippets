Sub MakeComment()
'updates the comments which contains last month values for each metric

    With Worksheets(1).Range("h7").ClearComments
    End With
    With Worksheets(1).Range("h7").AddComment
        .Visible = False
        .Text "Last Month: " & _
          Format(([AT21].Value), "Currency")
    End With


End Sub
