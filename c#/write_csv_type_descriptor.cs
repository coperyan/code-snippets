private void ExportCSV()
{
    //Define filename, create file path / full save path strings
    string fileName = String.Format("MyClass{0}.csv", DateTime.Now.ToString("yyyyMMdd"));
    string filePath = null;
    string savePath = null;

    //Open browser dialog to get save directory
    FolderBrowserDialog dlg = new FolderBrowserDialog();
    if (dlg.ShowDialog() == DialogResult.OK)
    {
        filePath = dlg.SelectedPath;
        savePath = String.Join("/", filePath, fileName);
    }

    //Get list of class we want to export
    var data = Db.GetData();

    //Get list of string to write
    var lines = new List<string>();

    //Get header from class property and create header 
    IEnumerable<PropertyDescriptor> props = TypeDescriptor.GetProperties(typeof(MyClass)).OfType<PropertyDescriptor>();
    var header = string.Join(",", props.ToList().Select(x => x.Name));
    lines.Add(header);

    //Create value lines based on each class in list
    var valueLines = data.Select(row => string.Join(",", header.Split(',').Select(a => row.GetType().GetProperty(a).GetValue(row, null))));
    lines.AddRange(valueLines);

    //Write file
    File.WriteAllLines(savePath, lines.ToArray());

    //Open save path
    Process.Start(filePath.ToString());
}