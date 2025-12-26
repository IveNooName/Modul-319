// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using PasswordProject;

public class Program {
    public static void Main(string[] args) {
        // printHeader();

        printLoadingAnimation();
        Console.WriteLine();
        Console.WriteLine();
        
        Console.Write("Länge: ");

        if (int.TryParse(Console.ReadLine(), out int length) && length >= 0) {
            char[][] matrix = Letters.LettersForPassword(); //Location, where the chars are safed for the generation

            char[] generatedLetters = new char[length];

            for (int i = 0; i < length; i++) {
                int randomRow = new Random().Next(0, 4);
                int randomChiffre = new Random().Next(0, matrix[randomRow].Length);
                generatedLetters[i] = matrix[randomRow][randomChiffre];
            }

            String password = new String(generatedLetters);


            Console.WriteLine("__ __ __ __ __ __ __ __ __");
            Console.WriteLine("Your password with the length of " + length + " is: ");
            Console.WriteLine("\u001B[32m" + password + "\u001B[0m");
            
        } else {
            Loggify.error("Invalid input");
        }
    }

    public static void printHeader() {
        Console.WriteLine("""

                            ██████╗  █████╗ ███████╗███████╗ ██████╗ ███████╗███╗   ██╗
                            ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝ ██╔════╝████╗  ██║
                            ██████╔╝███████║███████╗███████╗██║  ███╗█████╗  ██╔██╗ ██║
                            ██╔═══╝ ██╔══██║╚════██║╚════██║██║   ██║██╔══╝  ██║╚██╗██║
                            ██║     ██║  ██║███████║███████║╚██████╔╝███████╗██║ ╚████║
                            ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝
                            
                          """);
    }

    public static void printLoadingAnimation() {
        int x = 2;

        Console.CursorVisible = false;
        char[] loadingChars = { '⠇', '⠏', '⠋', '⠙', '⠹', '⠸', '⠼', '⠴', '⠦', '⠧', '⠇' };
        int i = 0;
        
        while (true) {
            Thread.Sleep(100);
            Console.Write("\r" + loadingChars[i]); // prints the chatacters over and over again
            x++;
            i++;
            if (i >= loadingChars.Length) {
                i = 0;
            }
        }
        Console.Write("\r" + " "); //Cleanup loading animation
        Console.CursorVisible = true;
    }
}