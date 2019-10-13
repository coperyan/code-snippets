public void ChooseFolder()
{
    FolderBrowserDialog dlg = new FolderBrowserDialog();

    if (dlg.ShowDialog() == DialogResult.OK)
    {
        SaveFolderTextBox.Text = dlg.SelectedPath;
    }
    else
    {

    }
