// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(string[] args) {
        AgeCheckAndSayingHello();
    }

    private static String getName() {
        Console.WriteLine("Gib deinen Namen ein:");
        return Console.ReadLine();
    }

    private static int getAge() {
        Console.WriteLine("Gib dein Alter ein:");
        return Convert.ToInt32(Console.ReadLine());
    }

    private static void AgeCheckAndSayingHello() {

        String name =getName();
        int age = getAge();
        
        if (age >= 18) {
            Console.WriteLine("Hallo " + name + ", du bist volljährig.");
        } else {
            Console.WriteLine("Hallo " + name + ", du bist noch nicht volljährig.");
        }
    }
}