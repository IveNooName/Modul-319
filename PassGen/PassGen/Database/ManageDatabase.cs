namespace PassGen.Database;

using Microsoft.Data.Sqlite;

public static class CreateDatabase {
    public static int CreateDatabaseFile() {
        
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
            
        } catch (Exception) {
            return -1;
        }

    }
}

