// See https://aka.ms/new-console-template for more information

class main {
    public static void Main(String[] args) {
        Console.WriteLine("Wie alt bist du? ");
        String inputAge = Console.ReadLine();

        if (int.TryParse(inputAge, out int age)) {
            if (age >= 18) {
                Console.WriteLine("Du bist volljährig.");
            } else {
                Console.WriteLine("Du bist noch nicht volljährig.");
            }
        } else {
            Console.WriteLine("Ungültige Eingabe!");
        }
    }
}