// See https://aka.ms/new-console-template for more information

class main {
    static void Main(string[] args) {
        Console.Write("Was ist deine Lieblingsfarbe? ");
        String inputColor = Console.ReadLine();

        Console.WriteLine();

        switch (inputColor) {
            case "rot":
                Console.WriteLine("Rot ist eine sehr kräftige Farbe!");
                break;
            case "blau":
                Console.WriteLine("Blau wirkt beruhigend.");
                break;
            case "grün":
                Console.WriteLine("Grün erinnert an die Natur.");
                break;
            default:
                Console.WriteLine("Diese Farbe kenne ich nicht.");
                break;
        }
    }
}