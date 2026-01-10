namespace PassGen;

public class APIsForDatabase {
    
    public static void savePassword(String password) {
        int resultDatabaseCreation = CreateDatabase.crateDatabase();

        if (resultDatabaseCreation == -1) {
            Console.WriteLine("A serious error occurred. Please restart the application. \n" +
                              "If the Error is still there, delete the entire database and try again.");
        }
        
        if (password == "") {
            Console.WriteLine("Empty password. \n" +
                              "Did you generate a password?");
            Console.WriteLine(""); //Layout
        } else {
            bool repeatContextMenu = true;

            do {
                Console.Write("Would you like to like to enter a username and description? (y/n): ");
                char selection = Console.ReadKey().KeyChar;
                Console.WriteLine(); //Layout
                
                switch (selection) {
                    case 'y':
                        repeatContextMenu = false;
                        String userName;
                        String description;
                        bool saveStatus;

                        Console.WriteLine(); //Layout
                        
                        do {
                            Console.Write("Enter username: ");
                            userName = Console.ReadLine();
                        } while (userName == "");

                        do {
                            Console.Write("Enter description: ");
                            description = Console.ReadLine();
                        } while (description == "");

                        
                        saveStatus = UseDatabase.writeDataInDatabase(userName, password, description);
                        Console.WriteLine(saveStatus
                            ? "Password was successfully saved"
                            : "A serious error occurred. Please try restart the application and try again.");


                        Console.WriteLine(); //Layout
                        break;

                    case 'n':
                        repeatContextMenu = false;
                        saveStatus = UseDatabase.writeDataInDatabase("Not Provided", password, "Not Provided");

                        Console.WriteLine(); //Layout

                        Console.WriteLine(saveStatus
                            ? "Password was successfully saved"
                            : "A serious error occurred. Please try restart the application and try again.");

                        Console.WriteLine(); //Layout
                        break;
                }
            } while (repeatContextMenu);
        }
    }

    public static void readPassword() {

        char selection;

        do {
            Console.Write(
                "Are you sure you want to show your passwords? Everyone around you can see all passwords! (y/n): "
            );
            selection = Console.ReadKey().KeyChar;

            Console.WriteLine(""); //Layout

            if (selection == 'y') {
                Console.WriteLine(); //Layout

                Program.printLoadingAnimation(3);
                
                UseDatabase.readDataInDatabase();
            }
        } while (!(selection == 'y' || selection == 'n'));

        Console.WriteLine(); //Layout
    }
    
    public static void deletePassword() {
        Console.Write("Which Password would you like to delete? Enter the ID of the Password: ");

        if (long.TryParse(Console.ReadLine(), out long passwordID)) {
            int deleteStatus = UseDatabase.deleteDataInDatabase(passwordID);

            switch (deleteStatus) {
                case 1:
                    Console.WriteLine($"The password was successfully deleted");
                    break;
                case 2:
                    Console.WriteLine($"The ID {passwordID} was not found in the database");
                    break;
                case -1:
                    Console.WriteLine("A serious error occurred. Please restart the application and try again.");
                    break;
            }

            Console.WriteLine(); //Layout
        }
    }
}