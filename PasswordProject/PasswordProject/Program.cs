// See https://aka.ms/new-console-template for more information

using PasswordProject;

public class Program {
    public static void Main() {
        printHeader();

        bool isActive = true;
        String password = "";
        
        do {
            int selection = contextMenu();
            
            if (selection == 1) {
                password = passwordGenerator();
            } else if (selection == 2) {
                APIsForDatabase.safePassword(password);
            } else if (selection == 3) {
                APIsForDatabase.readPassword();
            } else if (selection == 4) {
                
            } else {
                isActive = false;
            }

        } while (isActive);



    }

    private static String passwordGenerator() {
        //User-input for the length
        Console.Write("Lenght: ");

        if (int.TryParse(Console.ReadLine(), out int length) && length > 0) {
            
            String password = generator(length);
            
            Console.WriteLine("\n=======================================");
            
            Console.WriteLine("Your password with the length of " + length + " is: ");
            printLoadingAnimation(3);
            Console.WriteLine("\u001B[32m" + password + "\u001B[0m");
            
            Console.WriteLine("=======================================");
            Console.WriteLine(); //Layout
            
            return password;
        } else {
            Console.WriteLine("\u001B[31m" + "Sorry, that's not a number, that can generate the password! Please enter a number that is between one and two billion." + "\u001B[0m");
            Console.WriteLine(); //Layout
            return null;
        }
    }


    private static string generator(int length) {
        char[][] matrix = LetterStorage.LettersForPassword(); //Location, where the chars are safed for the generation

        char[] generatedLetters = new char[length];

        for (int i = 0; i < length; i++) {
            int randomRow = new Random().Next(0, 4);
            int randomChiffre = new Random().Next(0, matrix[randomRow].Length);
            generatedLetters[i] = matrix[randomRow][randomChiffre];
        }

        String password = new String(generatedLetters);
        return password;
    }

    
    
    
    private static void printHeader() {
        Console.WriteLine("""

                            ██████╗  █████╗ ███████╗███████╗ ██████╗ ███████╗███╗   ██╗
                            ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝ ██╔════╝████╗  ██║
                            ██████╔╝███████║███████╗███████╗██║  ███╗█████╗  ██╔██╗ ██║
                            ██╔═══╝ ██╔══██║╚════██║╚════██║██║   ██║██╔══╝  ██║╚██╗██║
                            ██║     ██║  ██║███████║███████║╚██████╔╝███████╗██║ ╚████║
                            ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝
                            
                          """);
    }

    
    public static void printLoadingAnimation(int times) {
        int x = 0;

        Console.CursorVisible = false;
        char[] loadingChars = { '⠇', '⠏', '⠋', '⠙', '⠹', '⠸', '⠼', '⠴', '⠦', '⠧' };
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

    private static int contextMenu() {
        
        Console.WriteLine("1) Generate a password");
        Console.WriteLine("2) Safe Password");
        Console.WriteLine("3) Look at the safed Passwords");
        Console.WriteLine("4) Delete Password");
        Console.WriteLine("5) Exit");
        
        char selection = Console.ReadLine()[0];
        Console.WriteLine(); //Layout
         
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
            default:
                return contextMenu();
        }
    }
}