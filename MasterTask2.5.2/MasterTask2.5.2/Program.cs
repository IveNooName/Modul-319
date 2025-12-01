// See https://aka.ms/new-console-template for more information

Console.WriteLine("{0,5} | {1,8} | {2,10}", "Zahl", "Quadrat", "Wurzel");
Console.WriteLine(new string('-', 30));

for (int i = 0; i <= 100; i++) {
    Console.WriteLine("{0,5} | {1,8} | {2,10}", i, i * i, Math.Round(Math.Sqrt(i), 8));
    Console.WriteLine(new string('-', 30));
}