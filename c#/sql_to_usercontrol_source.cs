private void PopulateShiftDropdown()
{
    //Getting connection string
    string connectionString = ConfigurationManager.ConnectionStrings["ServerName"].ConnectionString;

    //Creating new connection
    SqlConnection connection = new SqlConnection(connectionString);

    //Setting SQL command
    SqlCommand sqlCmd = new SqlCommand("SELECT TOP 5 * FROM Table", connection);

    //Opening connection
    connection.Open();

    //Grabbing data
    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

    //Looping through items
    while (sqlReader.Read())
    {
        //Adding values to dropdown
        ShiftDropdown.Items.Add(sqlReader["ColumnName"].ToString());
    }

    //Closing sql reader
    sqlReader.Close();

    //Closing Sql connection
    connection.Close();
}
