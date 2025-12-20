// See https://aka.ms/new-console-template for more information

public class Program {
    static void Main(string[] args) {
        for (int i = 10; i > 0; i--) {
            if (i % 2 == 0) {
                Console.WriteLine(i);
            } else {
                Console.WriteLine(-i);
            }
        }
    }
}