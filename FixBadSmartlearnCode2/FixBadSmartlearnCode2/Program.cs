// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(string[] args) {
        printGradePointAverage();
    }

    private static double getFirstGrade() {
        Console.WriteLine("Gib die erste Note ein:");
        return Convert.ToDouble(Console.ReadLine());
    }

    private static double getSecondGrade() {
        Console.WriteLine("Gib die zweite Note ein:");
        return Convert.ToDouble(Console.ReadLine());
    }

    private static double getThirdGrade() {
        Console.WriteLine("Gib die dritte Note ein:");
        return Convert.ToDouble(Console.ReadLine());
    }

    private static double calculateGradePointAverage() {
        double firstGrade = getFirstGrade();
        double secondGrade = getSecondGrade();
        double thirdGrade = getThirdGrade();

        return (firstGrade + secondGrade + thirdGrade) / 3;
    }

    private static void printGradePointAverage() {
        Console.WriteLine("Dein Notendurchschnitt ist: " + calculateGradePointAverage());
    }
}