namespace PassGen.Database;

using Microsoft.Data.Sqlite;

public static class UseDatabase {
    public static bool WriteDataInDatabase(string user, string password, string description) {
        try {
            using var connection = new SqliteConnection("Data Source=SavedPasswords.db");
            connection.Open();
            
            var cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Passwords (User, Password, Description) VALUES ($user, $password, $description)";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("$user", user);
            cmd.Parameters.AddWithValue("$password", password);
            cmd.Parameters.AddWithValue("$description", description);
            cmd.ExecuteNonQuery();

            return true;
        } catch (Exception) {
            return false;
        }
    }

    public static void ReadDataInDatabase() {
        try {
            using var connection = new SqliteConnection("Data Source=SavedPasswords.db");
            connection.Open();

            var cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Passwords";
            using var reader = cmd.ExecuteReader();

            Console.WriteLine("\e[1mAll saved Passwords in the database:\e[0m");
            while (reader.Read()) {
                Console.WriteLine(
                    $"ID: {reader["Id"]}, Username: {reader["User"]}, Password: {reader["Password"]}, Description: {reader["Description"]}"
                );
            }
        } catch (Exception) {
            Console.WriteLine("Something went wrong with reading the database. Has the database any data?");
        }
    }

    public static int DeleteDataInDatabase(long id) {
        try {
            using var connection = new SqliteConnection("Data Source=SavedPasswords.db");
            connection.Open();

            var deleteCmd = connection.CreateCommand();
            deleteCmd.CommandText = "DELETE FROM Passwords WHERE Id = $id";
        
            deleteCmd.Parameters.AddWithValue("$id", id); //The ID, that should be deleted
        
            int numberOfDeletions = deleteCmd.ExecuteNonQuery();
            if (numberOfDeletions > 0) {
                return 1;
            }
            return 2;
        } catch (Exception) {
            Console.WriteLine($"Something went wrong with deleting something database.");
            return -1;
        }
    }
}