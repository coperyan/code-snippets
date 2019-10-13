private void PopulateDropdown()
      {
          //Getting connection string
          string connectionString = ConfigurationManager.ConnectionStrings["ServerConn"].ConnectionString;

          //Creating new connection
          SqlConnection connection = new SqlConnection(connectionString);

          //Setting SQL command
          SqlCommand sqlCmd = new SqlCommand("SELECT * FROM table", connection);

          //Opening connection
          connection.Open();

          //Grabbing data
          SqlDataReader sqlReader = sqlCmd.ExecuteReader();

          //Looping through items
          while (sqlReader.Read())
          {
              //Adding values to dropdown
              Dropdown.Items.Add(sqlReader["Column"].ToString());
          }

          //Closing sql reader
          sqlReader.Close();

          //Closing Sql connection
          connection.Close();
      }
