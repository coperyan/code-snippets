
private string ExecSP(string param1, string param2)
{
    //Getting connection string
    string connectionString = ConfigurationManager.ConnectionStrings["ServerConn"].ConnectionString;

    //Creating new connection
    SqlConnection connection = new SqlConnection(connectionString);

    //Referencing class of parameters needed to add rep
    List<SPList> theSPlist = new List<SPList>();

    //Setting values in class based on variables passed to this class
    theSPList.Add(new SPList { Param1 = param1, Param2 = param2 });

    //Trying to execute SP
    try
    {
       //Executing stored procedure, setting reply as variable
        var SPresult = connection.Query<SPList>("EXECUTE dbo.usp_SP @Param1, @Param2", new { Param1 = param1, Param2 = param2 }).ToList();

        //closing SQL connection
        connection.Close();

        //Returning success message
        return SPresult[0].ReturnMsg;
    }

    //If any errors thrown in SQL, catching process
    catch (SqlException ex)
    {
        //Returning user-friendly error message
        return ex.Message.ToString();

    }
