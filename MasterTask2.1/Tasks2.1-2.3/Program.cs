// See https://aka.ms/new-console-template for more information

class main {
    static void Main(string[] args) {
        
        Console.Write("Wie heisst du? ");
        String name = Console.ReadLine();
        
        Console.Write("In welchem Jahr bist du geboren? ");
        String birthYearInput = Console.ReadLine();
        
        if (int.TryParse(birthYearInput, out int birthYear)) {
            int result = DateTime.Now.Year - birthYear;

            Console.WriteLine("Hallo {0}, du bist ca. {1} Jahre alt.", name, result);
        }
        else {
            Console.Error.WriteLine("\nUngültige Eingabe.");
        }
        
    }
}