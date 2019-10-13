public void DoExcelStuff(string iterationvalue)
{

//Create excel
Excel.Application xlApp = new Excel.Application();

//Create Com objects for usage
Excel.Workbook xlWorkBook;
Excel.Sheets objSheets;
Excel._Worksheet objSheet;
Excel.Range range;

//Open macro-enabled wb
xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\Administrator\Desktop\MyFile.xlsm");

//Grab the sheet you want to change a cell value on
objSheets = xlWorkBook.Worksheets;
objSheet = (Excel._Worksheet)objSheets.get_Item(2);

//Select range you want to change
range = objSheet.get_Range("B3");

//Update cell value
range.Value = iterationvalue

//Run macro
xlApp.Run("MyMacro");

//Save file txt
string fullfilename = @"C:\Users\Administrator\Desktop\UpdatedFile.xlsm"

//Save file
xlWorkBook.SaveAs(String.Format(fullfilename));

//Close file
xlWorkBook.Close(false);

//Quit excel
xlApp.Quit();

//Clear COM objects
System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
System.Runtime.InteropServices.Marshal.ReleaseComObject(objSheet);
System.Runtime.InteropServices.Marshal.ReleaseComObject(objSheets);
System.Runtime.InteropServices.Marshal.ReleaseComObject(range);

//Kill excel processes (sometimes they stay running)
System.Diagnostics.Process[] PROC = Process.GetProcessesByName("EXCEL");

foreach(System.Diagnostics.Process PK in PROC)
{
    if (PK.MainWindowTitle.Length == 0)
        PK.Kill();
}                    

}
