// See https://aka.ms/new-console-template for more information

public class MainClass {
    public static void Main() {
        double[] noten = { 3.5, 4.2, 5.25, 4.6, 5.8, 3.9 };

        Console.WriteLine($"{noten.Average():F2}");
    }
}