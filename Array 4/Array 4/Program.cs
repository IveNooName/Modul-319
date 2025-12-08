// See https://aka.ms/new-console-template for more information

public class Array_4 {
    public static void Main() {

        Console.Write("Eingabe: ");
        String word = Console.ReadLine();
        char[] chars = word.ToCharArray();
        char[] changedOrder = new char[chars.Length];

        for (int i = 0; i < chars.Length; i++) {
            changedOrder[changedOrder.Length - 1 - i] = chars[i];
        }

        foreach (char item in changedOrder) {
            Console.Write(item);
        }
    }
}