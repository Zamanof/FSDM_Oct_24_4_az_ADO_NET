using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json");

var config = builder.Build();
string connectionString = config.GetConnectionString("MyJsonCS")!;

#region SQL Injection
//string id = Console.ReadLine()!;

//using (SqlConnection conn = new(connectionString))
//{
//    conn.Open();
//    SqlCommand cmd = new(@$"SELECT * FROM Authors WHERE Id={id}", conn);

//    SqlDataReader reader = cmd.ExecuteReader();

//    do
//    {
//        while (reader.Read())
//        {
//            for (int i = 0; i < reader.FieldCount; i++)
//            {
//                Console.Write($"{reader[i]}     \t\t");
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine("\t\t");

//    } while (reader.NextResult());
//}
#endregion

#region parametrized query
string id = Console.ReadLine()!;
string firstName = Console.ReadLine()!;



using (SqlConnection conn = new(connectionString))
{
    conn.Open();
    //SqlParameter parameter = new();
    //parameter.ParameterName = "@id";
    //parameter.SqlDbType = System.Data.SqlDbType.Int;
    //parameter.Value = id;
    SqlCommand cmd = new(@$"SELECT * FROM Authors WHERE Id > @id 
                            AND FirstName NOT LIKE @firstName", conn);
    //cmd.Parameters.Add(parameter);
    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
    cmd.Parameters.Add("@firstName", System.Data.SqlDbType.NVarChar).Value = firstName;
    SqlDataReader reader = cmd.ExecuteReader();

    do
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]}     \t\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\t\t");

    } while (reader.NextResult());
}
#endregion
