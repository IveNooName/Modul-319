// See https://aka.ms/new-console-template for more information

using PasswordProject;

public class Program {
    public static void Main(string[] args) {
        // printHeader();

        Console.WriteLine("Länge: ");
        int length = int.Parse(Console.ReadLine());

        if (!isIntValid(length)) {
            char[][] matrix = Letters.LettersForPassword(); //Location, where the chars are safed for the generation
        
            char[] generatedLetters = new char[length];
        
            for (int i = 0; i < length; i++) {
            
                int randomRow = new Random().Next(0, 4);
                int randomChiffre = new Random().Next(0, matrix[randomRow].Length);
                Loggify.success("Output: " + matrix[randomRow][randomChiffre]);
            
                generatedLetters[i] = matrix[randomRow][randomChiffre];
            
            }

            String password = new String(generatedLetters);
        
            Console.WriteLine(password);
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

    public static bool isIntValid(int input) {
        if (input == 0) {
            return true;
        }
        return false; 
    }

    public static bool isStringValid(String input) {
        // Fehler korrigiert: '==' statt '='
        return input == null || input == "";
    }

}