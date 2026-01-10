namespace PassGen;

using Microsoft.Data.Sqlite;

public class UseDatabase {
    public static bool writeDataInDatabase(String User, String Password, String Description) {
        try {
            using var connection = new SqliteConnection("Data Source=SavedPasswords.db");
            connection.Open();
            
            var cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO Passwords (User, Password, Description) VALUES ($user, $password, $description)";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("$user", User);
            cmd.Parameters.AddWithValue("$password", Password);
            cmd.Parameters.AddWithValue("$description", Description);
            cmd.ExecuteNonQuery();

            return true;
        } catch (Exception e) {
            return false;
        }
    }

    public static void readDataInDatabase() {
        try {
            using var connection = new SqliteConnection("Data Source=SavedPasswords.db");
            connection.Open();

            var cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Passwords";
            using var reader = cmd.ExecuteReader();

            Console.WriteLine("\x1b[1mAll saved Passwords in the database:\x1b[0m");
            while (reader.Read()) {
                Console.WriteLine(
                    $"ID: {reader["Id"]}, Username: {reader["User"]}, Password: {reader["Password"]}, Description: {reader["Description"]}"
                );
            }
        } catch (Exception e) {
            Console.WriteLine("Something went wrong with reading the database. Has the database any data?");
        }
    }

    public static int deleteDataInDatabase(long id) {
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
        } catch (Exception e) {
            Console.WriteLine($"Something went wrong with deleting something database.");
            return -1;
        }
    }
}