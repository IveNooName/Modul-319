// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

class main {
    public static void Main(string[] args) {
        Console.Write("Bitte Schulnote eingeben (Deutsches Notensystem): ");
        String inputGrade = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);

        if (int.TryParse(inputGrade, out int grade)) {
            switch (grade) {
                case 1:
                    Console.WriteLine("Sehr gut");
                    break;
                case 2:
                    Console.WriteLine("Gut");
                    break;
                case 3:
                    Console.WriteLine("Befriedigend");
                    break;
                case 4:
                    Console.WriteLine("Ausreichend");
                    break;
                case 5:
                    Console.WriteLine("Mangelhaft");
                    break;
                case 6:
                    Console.WriteLine("Ungenügend");
                    break;
                
                default:
                    Console.WriteLine("Ungültige Note!");
                    break;
            }
        } else {
            Console.WriteLine("Das ist keine Zahl!");
        }
    }
}