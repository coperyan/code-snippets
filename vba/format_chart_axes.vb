    With Sheets("Analysis").ChartObjects("Chart 2").Chart
        .Axes(xlValue).MaximumScale = Sheets("Analysis").Range("AH15").Value
        .Axes(xlValue).MinimumScale = Sheets("Analysis").Range("AH16").Value
        .Axes(xlValue).MajorUnit = Sheets("Analysis").Range("AH17").Value
  End With