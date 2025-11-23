// See https://aka.ms/new-console-template for more information

class MainClass {
    public static void Main(string[] args) {
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;
        
        for (int i = 1; i <= 100; i++) {
            sum1 += i;
        }

        for (int i = 2; i <= 100; i += 2) {
            sum2 += i;
        }
        
        for (int i = 1; i <= 99; i += 2) {
            sum3 += i;
        }
        
        for (int i = 1; i <= 100; i++) {
            sum4 += i * i;
        }

        Console.WriteLine(sum4);
    }
}