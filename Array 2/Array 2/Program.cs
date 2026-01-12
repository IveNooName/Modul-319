// See https://aka.ms/new-console-template for more information

public class MainClass {
    public static void Main(string[] args) {
        int[] numberArray = { 7, 11, 6, 55, 98, 45, 16, 96, 46 };
        int evenNumbers = 0;
        
        for(int i = 0; i < numberArray.Length; i++) {
            if (numberArray[i] % 2 == 0) {
                evenNumbers++;
            }
        }
    }
}