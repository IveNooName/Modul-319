// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;

Console.WriteLine("Bitte gib einen Text ein:");
String input = Console.ReadLine();
int vocalCounter = 0;

input = input.ToLower();

foreach (char c in input) {
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
        vocalCounter++;
    }
}

Console.WriteLine("Anzahl Vokale: " + vocalCounter);