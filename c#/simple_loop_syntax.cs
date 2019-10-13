for (int x = 0; x < emaillist.Count; x++)
{
    if (emaillist[i].OwnerName == currentowner)
    {
        MessageBox.Show(emaillist[i].Email.ToString());
    }

}
