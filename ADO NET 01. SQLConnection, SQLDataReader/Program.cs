#region ADO
/*
ADO .NET -  ActiveX Data Object for .NET

// MMSQL Server, Oracle, OLE DB, ODBC
 

ADO Classes
 - DBConnection (SqlConnection, ...)
 - DBCommand
 - DBDataReader
 - DBDataAdapter,
 - ...

ADO Datatype for DB
 - DataTable
 - DataSet
 - ...

Connection modes:
    - Connnected Mode
    - Disconnected Mode
*/
#endregion

#region ConnectionStrings
// https://www.connectionstrings.com/

// Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
// Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;

// Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate=True; Application Intent = ReadWrite; Multi Subnet Failover=False;

#endregion

using Microsoft.Data.SqlClient;

SqlConnection sqlConnection = default!;

string connectionString = @"Server=STHQ0124-01; Database=AdoTest; 
                            User ID=admin; Password=admin; Trust Server Certificate = True;";


#region Database Connection with try finally
//sqlConnection = new(connectionString);

//string insertQuery = @"INSERT INTO Authors(Id, FirstName, LastName)
//                        VALUES(1, 'Joseph', 'Albahari')";

////SqlCommand command = new SqlCommand(insertQuery, sqlConnection);

//SqlCommand command = new();
//command.Connection = sqlConnection;
//command.CommandText = insertQuery;

//try
//{
//    sqlConnection.Open();
//    command.ExecuteNonQuery();
//}
//finally
//{
//    if (sqlConnection != null) sqlConnection.Close();
//}
#endregion

#region Database Connection with using
//SqlCommand command = new();
//using (sqlConnection = new(connectionString))
//{
//    sqlConnection.Open();
//    string FirstName = Console.ReadLine()!;
//    string LastName = Console.ReadLine()!;

//    string insertQuery = @$"INSERT INTO Authors(Id, FirstName, LastName)
//                            VALUES(3, '{FirstName}', '{LastName}')";
//    command.Connection = sqlConnection;
//    command.CommandText = insertQuery;
//    command.ExecuteNonQuery();
//}
#endregion
