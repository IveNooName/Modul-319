// See https://aka.ms/new-console-template for more information

class main {
    static void Main(string[] args) {
        
        Console.Write("Gib den Radius des Kreises in cm ein: ");
        String intputRadius = Console.ReadLine();
        
        if (Double.TryParse(intputRadius, out Double radius)) {
            double resultScope = 2 * radius * Math.PI;
            double resultArea = (radius * radius) * Math.PI;

            Console.WriteLine($"Kreisradius: {radius} cm \nUmfang: {resultScope:F2} cm \nFläche: {resultArea:F2} cm²");
        }
        else {
            Console.Error.WriteLine("\nUngültige Eingabe.");
        }
        
    }
}