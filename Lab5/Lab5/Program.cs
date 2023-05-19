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
            var conn = "Data Source=(localdb)\\ProjectModels;Initial Catalog=myTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var db = new SqlConnection(conn);
            db.Open();
            var query = "Insert INTO dbo.Users(username, password, email, role, status) VALUES ('admin', 'admin', 'admin@gmail.com', 'admin', 1)";
            SqlCommand cmd = new SqlCommand(query, db);
            cmd.ExecuteNonQuery();
            db.Close();

            // ---------- Version:-2 ----------
            // var conn = "Data Source=(localdb)\\ProjectModels;Initial Catalog=myTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // SqlConnection db = new SqlConnection(conn);
            // var query = "Insert into dbo.Users values('because', 'i', 'like@to.com', 'like', 2)";
            // SqlCommand cmd = new SqlCommand(query, db);
            // db.Open();
            // cmd.ExecuteNonQuery();
            // db.Close();
        }
    }
}
