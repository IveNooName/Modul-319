namespace PasswordProject;

public class APIsForDatabase {
    
    public static void safePassword(String password) {
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
            bool repeatContexMenu = true;

            do {
                Console.Write("Would you like to like to enter a username and description? (y/n): ");
                char selection = Console.ReadKey().KeyChar;
                Console.WriteLine(); //Layout
                
                switch (selection) {
                    case 'y':
                        repeatContexMenu = false;
                        String userName;
                        String description;
                        bool safeStatus;

                        Console.WriteLine(); //Layout
                        
                        do {
                            Console.Write("Enter username: ");
                            userName = Console.ReadLine();
                        } while (userName == "");

                        do {
                            Console.Write("Enter description: ");
                            description = Console.ReadLine();
                        } while (description == "");

                        
                        safeStatus = UseDatabase.writeDataInDatabase(userName, password, description);
                        if (safeStatus) {
                            Console.WriteLine("Password was successfully saved");
                        } else {
                            Console.WriteLine("A serious error occurred. Please try restart the application.");
                        }

                        
                        Console.WriteLine(); //Layout
                        break;

                    case 'n':
                        repeatContexMenu = false;
                        safeStatus = UseDatabase.writeDataInDatabase("Not Provided", password, "Not Provided");

                        Console.WriteLine(); //Layout
                        
                        if (safeStatus) {
                            Console.WriteLine("Password was successfully saved");
                        } else {
                            Console.WriteLine("A serious error occurred. Please try restart the application.");
                        }

                        Console.WriteLine(); //Layout
                        break;
                }
            } while (repeatContexMenu);
        }
    }

    public static void readPassword() {

        char selection;

        do {
            Console.Write(
                "Are you sure you want to show your passwords? Everybody around you can see all passwords! (y/n): "
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
       
    }
}