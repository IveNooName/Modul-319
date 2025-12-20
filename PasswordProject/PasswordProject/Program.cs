// See https://aka.ms/new-console-template for more information

using PasswordProject;

public class Program {
    public static void Main(string[] args) {
        // printHeader();

        Console.WriteLine("Länge: ");
        int length = int.Parse(Console.ReadLine());

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
}