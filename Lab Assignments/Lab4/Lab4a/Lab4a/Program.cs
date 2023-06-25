/*
    Write a C# program to perform console CRUD operation.
*/

using System.Data.SqlClient;

namespace CRUD
{
    public class Database
    {
        public SqlConnection db;

        public Database(string conn)
        {
            db = new SqlConnection(conn);
        }

        public void Create(int id, string username, string password, string email, string role, int status)
        {
            db.Open();
            SqlCommand sqlCommand = new SqlCommand($"INSERT INTO dbo.Users(id, Username, Password, Email, Role, Status) VALUES ({id}, '{username}', '{password}', '{email}', '{role}', {status})", db);
            sqlCommand.ExecuteNonQuery();
            db.Close();
        }
        public void Read()
        {
            db.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.Users", db);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Console.Write("Id\t\tUsername\tPassword\tEmail\t\t\tRole\t\tStatus\n");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetValue(i) + "\t\t");
                    }
                    Console.Write("\n");
                }
            }
            db.Close();
        }
        public void Update(int id, string username, string password, string email, string role, int status)
        {
            db.Open();
            SqlCommand sqlCommand = new SqlCommand($"UPDATE dbo.Users SET id={id}, Username='{username}', Password='{password}', Email='{email}', Role='{role}', Status={status} WHERE id = {id}", db);
            sqlCommand.ExecuteNonQuery();
            db.Close();
        }
        public void Delete(int id)
        {
            db.Open();
            SqlCommand sqlCommand = new SqlCommand($"DELETE FROM dbo.Users WHERE id={id}", db);
            sqlCommand.ExecuteNonQuery();
            Console.Write($"Id {id} record deleted.\n");
            db.Close();
        }
    }
    class Program
    {
        public static int id, status;
        public static string? username, password, email, role;
        static void InputHelper()
        {
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Role: ");
            role = Console.ReadLine();
            Console.Write("Status: ");
            status = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Database database = new Database("Data Source=(localdb)\\ProjectModels;Initial Catalog=Norden;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            char continueChoice;
            Console.Write("Select task to perform\n");
            Console.Write("1. Create\n2. Read\n3. Update\n4. Delete\n5. Exit\n");
            do
            {
                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        InputHelper();
                        database.Create(id, username, password, email, role, status);
                        break;
                    case 2:
                        database.Read();
                        break;
                    case 3:
                        Console.Write("Enter update Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new data:\n");
                        InputHelper();
                        database.Update(id, username, password, email, role, status);
                        break;
                    case 4:
                        Console.Write("Enter Id to delete data: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        database.Delete(id);
                        break;
                    case 5:
                        Console.Write("Program exited.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Invalid Choice. Try again !");
                        break;
                }
                Console.Write("Enter Y to continue: ");
                continueChoice = Convert.ToChar(Console.ReadLine());
            } while (continueChoice == 'y' || continueChoice == 'Y');
        }
    }
}