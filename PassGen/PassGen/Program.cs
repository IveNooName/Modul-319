// See https://aka.ms/new-console-template for more information

namespace PassGen;

public static class Program {
    public static void Main() {
        PrintHeader();
        
        bool isActive = true;
        string password = "";
        
        do {
            int selection = ContextMenu();
            Console.WriteLine(selection + "\n"); //override user-input for preventing sus layout
            
            if (selection == 1) {
                password = PasswordGenerator();
            } else if (selection == 2) {
                ApisForDatabase.SavePassword(password);
            } else if (selection == 3) {
                ApisForDatabase.ReadPassword();
            } else if (selection == 4) {
                ApisForDatabase.DeletePassword();
            } else {
                isActive = false;
            }

        } while (isActive);



    }

    private static string PasswordGenerator() {
        //User-input for the length
        Console.Write("Lenght: ");

        if (int.TryParse(Console.ReadLine(), out int length) && length > 0 && length <= 1000) {
            
            string password = Generator(length);
            
            Console.WriteLine("\n=======================================");
            
            Console.WriteLine("Your password with the length of " + length + " is: ");
            PrintLoadingAnimation(3);
            Console.WriteLine("\u001B[32m" + password + "\u001B[0m");
            
            Console.WriteLine("=======================================");
            Console.WriteLine(); //Layout
            
            return password;
        } else {
            Console.WriteLine("\u001B[31m" + "Sorry, that's not a number, that can generate the password! Please enter a natural number that is between one and one thousand." + "\u001B[0m");
            Console.WriteLine(); //Layout
            return "";
        }
    }


    private static string Generator(int length) {
        char[][] matrix = LetterStorage.LettersForPassword(); //Location, where the chars are saved for the generation

        char[] generatedLetters = new char[length];

        for (int i = 0; i < length; i++) {
            int randomRow = Random.Shared.Next(0, 4);
            int randomChiffre = Random.Shared.Next(0, matrix[randomRow].Length);
            generatedLetters[i] = matrix[randomRow][randomChiffre];
        }

        string password = new string(generatedLetters);
        return password;
    }

    
    
    
    private static void PrintHeader() {
        Console.WriteLine("""

                            ██████╗  █████╗ ███████╗███████╗ ██████╗ ███████╗███╗   ██╗
                            ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝ ██╔════╝████╗  ██║
                            ██████╔╝███████║███████╗███████╗██║  ███╗█████╗  ██╔██╗ ██║
                            ██╔═══╝ ██╔══██║╚════██║╚════██║██║   ██║██╔══╝  ██║╚██╗██║
                            ██║     ██║  ██║███████║███████║╚██████╔╝███████╗██║ ╚████║
                            ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝
                            
                          """);
    }

    
    public static void PrintLoadingAnimation(int times) {
        int x = 0;

        Console.CursorVisible = false;
        char[] loadingChars = ['⠇', '⠏', '⠋', '⠙', '⠹', '⠸', '⠼', '⠴', '⠦', '⠧'];
        int i = 0;
        while (x < times) {
            Thread.Sleep(90);
            Console.Write("\r" + loadingChars[i]); // prints the characters over and over again
            i++;
            if (i >= loadingChars.Length) {
                i = 0;
                x++;
            }
        }

        Console.Write("\r" + ""); //Cleanup loading animation
        Console.CursorVisible = true;
    }

    private static int ContextMenu() {
        
        Console.WriteLine("1) Generate a password");
        Console.WriteLine("2) Save Password");
        Console.WriteLine("3) Look at the saved Passwords");
        Console.WriteLine("4) Delete Password");
        Console.WriteLine("5) Exit");

        int startLeft = Console.CursorLeft;
        int startTop  = Console.CursorTop;
        bool overrideChar = true;

        while (true) {
            var keyInfo = Console.ReadKey(intercept: overrideChar);
            char selection = keyInfo.KeyChar;

            switch (selection) {
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
            }

            // Colorize the Wrong user-input
            Console.SetCursorPosition(startLeft, startTop);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(selection);
            Console.ResetColor();

            Thread.Sleep(500);

            // Override false input
            Console.SetCursorPosition(startLeft, startTop);
            Console.Write(' ');                 
            Console.SetCursorPosition(startLeft, startTop); // reset cursor
        }
    }
}