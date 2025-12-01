// See https://aka.ms/new-console-template for more information

class  Program
{
    static void Main(string[] args) {
        sayHello();
        divideByTwo(67);
        addTwoDigitsTogether(66, 1);
    }

    private static void sayHello() {
        Console.WriteLine("Hallo und willkommen!");
    }

    private static double divideByTwo(double input) {
        return input / 2;
    }
    
    private static int addTwoDigitsTogether(int digit1, int digit2) {
        return digit1 + digit2; 
    }
}