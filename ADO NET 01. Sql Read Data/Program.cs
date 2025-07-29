using Microsoft.Data.SqlClient;

string connectionString = @"Server=(localdb)\MSSQLLocalDB;
                            Database=AdoTest;
                            Integrated Security=SSPI;
                            Trust Server Certificate=True";

SqlDataReader reader = null!;
SqlCommand command = null!;

#region Read Data
//using SqlConnection connection = new SqlConnection(connectionString);
//command = new SqlCommand(@"SELECT * FROM Authors", connection);

//connection.Open();

//reader = command.ExecuteReader();

//while (reader.Read())
//{
//    Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//}
#endregion

#region Read Data indexer
//using SqlConnection connection = new SqlConnection(connectionString);
//command = new SqlCommand(@"SELECT * FROM Authors", connection);

//connection.Open();

//reader = command.ExecuteReader();

//while (reader.Read())
//{
//    Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//}
#endregion

using SqlConnection connection = new SqlConnection(connectionString);
command = new SqlCommand(@"SELECT * FROM Authors", connection);

connection.Open();

reader = command.ExecuteReader();

bool line = true;

//Console.WriteLine(reader.FieldCount);

while (reader.Read())
{
    if (line)
    {
        for (int i = 0; i < reader.FieldCount; i++)
        {
            Console.Write($"{reader.GetName(i)}\t      ");
        }
        line = false;
    }
    Console.WriteLine();
    for (int i = 0; i < reader.FieldCount; i++)
    {
        Console.Write($"{reader[i]}\t       ");
    }    
}
