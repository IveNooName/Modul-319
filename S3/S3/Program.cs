// See https://aka.ms/new-console-template for more information

/*
 * Changed general Structure
 * Changed var names to english
 * removed unnecessary comments
 * Added checker for numbers
 * Added an Error-Notification, when it's not a number
 * Changed PI Variable, because it didn't worked
 */

class MainClass {
    static void Main() {
        Console.Write("Bitte gib den Radius des Kreises ein: ");
        String inputRadius = Console.ReadLine();

        if (double.TryParse(inputRadius, out double r)) {

            double pi = Math.PI;
            
            double scope = 2 * pi * r;
            double area = pi * (r * r);
            
            Console.WriteLine();
            Console.WriteLine("Kreisberechnung:");
            Console.WriteLine("Radius: " + r);
            Console.WriteLine("Umfang: " + scope);
            Console.WriteLine("Fläche: " + area);
        } else  {
            Console.WriteLine("This is not a Digit.");
        }
    }
}