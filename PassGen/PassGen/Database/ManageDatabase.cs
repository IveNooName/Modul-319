namespace PassGen;

using Microsoft.Data.Sqlite;

public class CreateDatabase {
    public static int createDatabase() {
        
        try {
            using var connection = new SqliteConnection("Data Source=SavedPasswords.db");
            connection.Open();

            //Creates the Database
            var cmd = connection.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Passwords (" +
                              "Id INTEGER PRIMARY KEY, " +
                              "Description TEXT, " +
                              "User TEXT, " +
                              "Password TEXT" +
                              ")";
            cmd.ExecuteNonQuery();
            
            return 1;
            
        } catch (Exception e) {
            return -1;
        }

    }
}

