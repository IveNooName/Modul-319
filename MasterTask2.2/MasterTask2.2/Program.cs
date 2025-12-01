// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

class main {
    static void Main(string[] args) {
        
        Console.Write("Input Preis: ");
        String inputPrice = Console.ReadLine();

        double inputTax = 8.1; //Input without % (8.1% -> 8.1)

        double decimalTax = inputTax / 100;
        
        if (double.TryParse(inputPrice, out double price)) {
            double result = price + (price * decimalTax);

            Console.WriteLine($"Der Preis beträgt inklusive den 8.1% Mehrwertsteuer: {result:F2}");
        }
        else {
            Console.Error.WriteLine("\nUngültige Eingabe.");
        }
        
    }
}