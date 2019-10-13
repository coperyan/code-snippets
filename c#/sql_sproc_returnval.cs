public string RunSp(int Param1, int Param2)
{
  //Reader to store values
  SqlDataReader sqlReader;

  //String for return
  string returnval;

  //Connection
  using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ServerName"].ConnectionString))
  {
    //Command to exec SP
    SqlCommand sqlCmd = new SqlCommand("usp_Sproc", conn);
    sqlCmd.CommandType = CommandType.StoredProcedure;

    //Adding parameters
    sqlCmd.Parameters.AddWithValue("@Param1", Param1);
    sqlCmd.Parameters.AddWithValue("@Param2", Param2);

    //Open connection
    conn.Open();

    //Execute stored procedure
    try
    {
      sqlReader = sqlCmd.ExecuteReader();

      while(sqlReader.Read())
      {
          returnval = sqlReader["ReturnVal"].ToString();
      }

      //Closing connection
      conn.Close();

      //Returning return val
      return returnval;
    }

    //If any errors, catch and display
    catch (SqlException ex)
    {
      return ex.Message.ToString();
    }

  }
}
