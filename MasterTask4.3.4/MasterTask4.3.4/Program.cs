// See https://aka.ms/new-console-template for more information

class MainClass {
    public static void Main(string[] args) {

        String password = "HowToDeleteSystem32";
        
        Console.Write("Bitte gib das Passwort ein: ");
        String inputPassword = Console.ReadLine();
        Console.WriteLine(Environment.NewLine);

        while (!password.Equals(inputPassword)) {
            Console.WriteLine("Falsches Passwort. Versuche es erneut.");
            Console.Write("Bitte gib das Passwort ein: ");
            inputPassword = Console.ReadLine();
        }

        Console.WriteLine("Zugriff erlaubt!");
    }
}