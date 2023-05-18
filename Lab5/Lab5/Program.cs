/*
 
Lab-5:

1. Add System.Data.Sqlclient from tools -> nuget package
2. View -> Sql server object explorer
Create database called myTest
Create table Users(id, usename, password, email, role, status)

*/

using System;
using System.Data.SqlClient;


namespace DatabaseConnection
{
    internal class InsertData
    {
        public static void Main(string[] args)
        {
            var conn = "Data Source=(localdb)\\ProjectModels;Initial Catalog=myTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection db = new SqlConnection(conn);
            var query = "Insert into dbo.Users values ('admin', 'admin', 'admin@admin.com', 'admin', 1)";
            SqlCommand cmd = new SqlCommand(query, db);
            db.Open();
            cmd.ExecuteNonQuery();
            db.Close();

        }
    }
}
