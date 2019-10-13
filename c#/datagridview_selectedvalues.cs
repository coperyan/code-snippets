//If user is selected in displayed grid
if (UserListGrid.SelectedCells.Count > 0)
{
    //Declaring selected row
    int index = UserListGrid.SelectedCells[0].RowIndex;
    DataGridViewRow selectedRow = UserListGrid.Rows[index];

    //First cell index is selected username
    string selectedUser = selectedRow.Cells[0].Value.ToString();

    //Second cell index is user's full name
    string selectedFullName = selectedRow.Cells[1].Value.ToString();
}