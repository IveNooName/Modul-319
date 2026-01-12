using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=SafedPasswords.db");
connection.Open();

// 1. Tabelle erstellen
var cmd = connection.CreateCommand();
// KORREKTUR: Komma hinzugefügt vor "Passwort"
cmd.CommandText = "CREATE TABLE IF NOT EXISTS Passwords (" +
                  "Id INTEGER PRIMARY KEY, " +
                  "Description TEXT, " +
                  "User TEXT, " +     
                  "Password TEXT" +
                  ")";
cmd.ExecuteNonQuery();

// 2. Daten einfügen
// KORREKTUR: SQL angepasst, damit alle Spalten und Parameter übereinstimmen
cmd.CommandText = "INSERT INTO Passwords (User, Password, Description) VALUES ($user, $password, $description)";

cmd.Parameters.Clear();
// Die Namen hier ($benutzer) müssen exakt mit dem SQL oben übereinstimmen
cmd.Parameters.AddWithValue("$user", "Max Mustermann");
cmd.Parameters.AddWithValue("$password", "12345");
cmd.Parameters.AddWithValue("$description", "eine tolle beschreibung");
cmd.ExecuteNonQuery();

Console.WriteLine("Daten eingefügt.");

// 3. Daten lesen
cmd.CommandText = "SELECT * FROM Passwords";
using var reader = cmd.ExecuteReader();

while (reader.Read())
{
    // KORREKTUR: Zugriff auf "Benutzer" statt "Name" (Spalte "Name" gab es nie)
    Console.WriteLine($"ID: {reader["Id"]}, Benutzer: {reader["User"]}, Password: {reader["Password"]}, Description: {reader["Description"]}");
}


// --- Schritt 4: Eine Zeile löschen ---

var deleteCmd = connection.CreateCommand();
// SQL: Lösche aus Tabelle 'Benutzer', WO die Id gleich meinem Parameter ist
deleteCmd.CommandText = "DELETE FROM Passwords WHERE Id = $id";

// Hier setzen wir die ID, die gelöscht werden soll (z.B. die 1)
deleteCmd.Parameters.AddWithValue("$id", 1);

// ExecuteNonQuery gibt zurück, wie viele Zeilen betroffen waren (int)
int anzahlGeloescht = deleteCmd.ExecuteNonQuery();

if (anzahlGeloescht > 0)
{
    Console.WriteLine("Erfolg: Der Benutzer wurde gelöscht.");
}
else
{
    Console.WriteLine("Info: Es wurde nichts gelöscht (ID existierte wohl nicht).");
}