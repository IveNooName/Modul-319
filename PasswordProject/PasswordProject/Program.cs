// See https://aka.ms/new-console-template for more information

using PasswordProject;

public class Program {
    public static void Main(string[] args) {
        printHeader();

        bool isActive = true;
        do {
            
            if (contextMenu() == 1) {
                passwordGenerator();
            } else {
                isActive = false;
            }

        } while (isActive);



    }

    private static void passwordGenerator() {
        //User-input for the length
        Console.Write("Lenght: ");

        if (int.TryParse(Console.ReadLine(), out int length) && length >= 0) {
            String password = generator(length);
            
            Console.WriteLine("\n=======================================");
            
            Console.WriteLine("Your password with the length of " + length + " is: ");
            printLoadingAnimation(3);
            Console.WriteLine("\u001B[32m" + password + "\u001B[0m");
            
            Console.WriteLine("=======================================");
            Console.WriteLine();
        } else {
            Console.WriteLine("\u001B[31m" + "Sorry, that's not a number, that can generate the password! Please enter a number that is one or bigger." + "\u001B[0m");
        }
    }


    private static string generator(int length) {
        char[][] matrix = Letters.LettersForPassword(); //Location, where the chars are safed for the generation

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

    
    private static void printLoadingAnimation(int times) {
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
        Console.WriteLine("2) Exit");
        
        char selection = Console.ReadKey().KeyChar;
        Console.WriteLine(); //Layout
        
        if (selection == '1') {
            return 1;
        }
        if (selection == '2') {
            return 2;
        } else {
            return contextMenu();
        }
    }
}