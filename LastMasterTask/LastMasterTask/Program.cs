// See https://aka.ms/new-console-template for more information

/*
 * This Method calculate the 7er row.
 * It goes max to 7*20
 */

class MainClass {
    public static void Main(string[] args) {
        for (int i = 1; i <= 20; i++) {
            Console.WriteLine($"7 * {i} = {7 * i}");
        }
    }
}