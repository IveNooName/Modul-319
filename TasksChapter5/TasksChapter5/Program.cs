// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(string[] args) {
        sayHello();
        divideByTwo(134);
        addTwoDigitsTogether(66, 1);
        isOfLegalAge(67);
        sayHelloWithName("Ruby");
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

    private static bool isOfLegalAge(int age) {
        return age >= 18;
    }

    private static void sayHelloWithName(String name) {
        Console.WriteLine("Hello " + name + "!");
    }
}