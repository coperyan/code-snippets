private void DataGridView_DragOver(object sender, DragEventArgs e)
{
    e.Effect = DragDropEffects.Move;

    //Converts window position to user control position (otherwise you can use MousePosition.Y)
    int mousepos = PointToClient(Cursor.Position).Y;

    //If the mouse is hovering over the bottom 5% of the grid
    if (mousepos > (DataGridView.Location.Y + (DataGridView.Height * 0.95)))
    {
        //If the first row displayed isn't the last row in the grid
        if (DataGridView.FirstDisplayedScrollingRowIndex < DataGridView.RowCount - 1)
        {
            //Increase the first row displayed index by 1 (scroll down 1 row)
            DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.FirstDisplayedScrollingRowIndex + 1;
        }
    }

    //If the mouse is hovering over the top 5% of the grid
    if (mousepos < (DataGridView.Location.Y + (DataGridView.Height * 0.05)))
    {
        //If the first row displayed isn't the first row in the grid
        if (DataGridView.FirstDisplayedScrollingRowIndex > 0)
        {
            //Decrease the first row displayed index by 1 (scroll up 1 row)
            DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.FirstDisplayedScrollingRowIndex - 1;
        }
    }
}
