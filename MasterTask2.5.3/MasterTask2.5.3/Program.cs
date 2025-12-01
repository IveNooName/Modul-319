// See https://aka.ms/new-console-template for more information

Console.WriteLine("GIb eine Zeichenfolge ein: ");
String input = Console.ReadLine();

Console.WriteLine("Zeichen und ihre Hexadezimalwerte: ");
foreach (char c in input) {
    Console.WriteLine("{0} -> 0x{1:X4}", c, (int)c);
}