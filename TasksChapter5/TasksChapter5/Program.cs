// See https://aka.ms/new-console-template for more information

class  Program
{
    static void Main(string[] args) {
        sayHello();
        divideByTwo(67);
    }

    private static void sayHello() {
        Console.WriteLine("Hallo und willkommen!");
    }

    private static double divideByTwo(double input) {
        return input / 2;
    }
}