// See https://aka.ms/new-console-template for more informationusing System;

class ConsoleApp {
    static void Main(string[] args) {
        task2_4_2_c();
    }

    public static void task1() {
        Console.WriteLine("Modul 319 - Applikationen entwerfen und implementieren.");
        Console.WriteLine("Ich lerne die Programmiersprache C#.");
    }

    public static void task2_1_2_e() {
        String fruit = "Apfel";
        int value = 1000555;
        bool isValid = true;
        char letter = 'Z';
    }

    public static void task2_1_2_f() {
        long x = 2147483648;
        float pi = 3.14f;
        decimal preis = 9.99m;
        bool aktiv = true;
    }

    public static void task2_1_2_g() {
        int number;
        number = 7;
        int result = number * 3;
    }

    public static void task2_2_a() {
        Console.Write("Wie heisst du? ");
        String name = Console.ReadLine();
        Console.WriteLine("\nHallo {0}, willkommen zum C#-Grundkurs!", name);
    }

    public static void task2_2_b() {
        Console.Write("Wie alt bist du? ");

        try {
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDu bist {0} Monate alt.", age * 12);
        }
        catch (Exception) {
            Console.WriteLine("\nERROR");
        }
    }

    public static void task2_2_d() {
        string name = "Max";
        int age = 20;

        Console.WriteLine($"Name: {name}, Alter: {age}");
    }
    
    public static void task2_2_e() {
        Console.Write("Bitte gib eine Ganzzahl ein: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result)) {
            Console.WriteLine("\nDu hast {0} eingegeben.", result);
        }
        else {
            Console.Error.WriteLine("\nUngültige Eingabe.");
        }
    }
    
    public static void task2_2_f() {
        Console.Write("Gib den Radius in cm ein: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double UserNumber)) {

            double result = Math.Pow(UserNumber, 2) * Math.PI;
            
            Console.WriteLine("\nDie Fläche des Kreises beträgt: {0:F2} cm²", result);
        }
        else {
            Console.Error.WriteLine("\nUngültige Eingabe! Bitte gib eine gültige Kommazahl ein.");
        }
    }

    public static void task2_3_a() {
        
        /*
         * The user inputs a value for the radius of the circle and
         * this Skript will calculate the 2D surface from the circle.
         */
        
        
        Console.Write("Gib den Radius in cm ein: ");
        String input = Console.ReadLine();

        if (double.TryParse(input, out double radius)) { //Tries to convert the String in a double
            Console.WriteLine($"Kreisradius: {radius} cm");
            double surface = Math.PI * radius * radius;

            Console.WriteLine($"Die Fläche des Kreises beträgt: {surface} cm²");
            Console.WriteLine($"                      gerundet: {surface:F2} cm²");
        }
        else {
            Console.WriteLine("Ungültige Eingabe.");
        }
    }
    
    public static void task2_4_2_b() {
        
        Console.Write("Was ist deine Lieblingsfarbe? ");
        String inputColor = Console.ReadLine().ToLower();

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
    
    public static void task2_4_2_c() {
        int number = 2;
        if (number % 2 == 0) {
            Console.WriteLine("Die Zahl ist gerade.");
        }
        else {
            Console.WriteLine("Die Zahl ist ungerade.");
        }
    }
}

