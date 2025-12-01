// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(string[] args) {
        calculateSurface();
    }

    public static double getLength() {
        Console.WriteLine("Gib die Länge des Rechtecks ein:");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static double getWidth() {
        Console.WriteLine("Gib die Breite des Rechtecks ein:");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static void calculateSurface() {
        double lenght = getLength();
        double width = getWidth();

        Console.WriteLine("Fläche: " + lenght * width);
        Console.WriteLine("Umfang: " + 2 * (width + lenght));
    }
}