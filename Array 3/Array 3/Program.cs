// See https://aka.ms/new-console-template for more information

public class MainClass {
    public static void Main(string[] args) {
        string[] animals = { "Luchs", "Wolf", "Maus", "Fuchs", "Eichhörnchen", "Waldkauz", "Eule", "Reh", "Wildsau" };

        foreach (var t in animals) {
            if (t.Length > 4) {
                Console.Write(t + " ");
            }
        }
    }
}