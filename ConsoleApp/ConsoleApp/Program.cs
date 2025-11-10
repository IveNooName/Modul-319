// See https://aka.ms/new-console-template for more informationusing System;

using System.Runtime.InteropServices;
using System.Security.AccessControl;

class ConsoleApp {
    static void Main(string[] args) {
        task2_2e();
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

    public static void task2_2a() {
        Console.Write("Wie heisst du? ");
        String name = Console.ReadLine();
        Console.WriteLine("\nHallo {0}, willkommen zum C#-Grundkurs!", name);
    }

    public static void task2_2b() {
        Console.Write("Wie alt bist du? ");

        try {
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDu bist {0} Monate alt.", age * 12);
        }
        catch (Exception) {
            Console.WriteLine("\nERROR");
        }
    }

    public static void task2_2d() {
        string name = "Max";
        int age = 20;

        Console.WriteLine($"Name: {name}, Alter: {age}");
    }
    
    public static void task2_2e() {
        Console.Write("Bitte gib eine Ganzzahl ein: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int result)) {
            Console.WriteLine("\nDu hast {0} eingegeben.", result);
        }
        else {
            Console.Error.WriteLine("\nUngültige Eingabe.");
        }
    }
}