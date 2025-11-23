// See https://aka.ms/new-console-template for more information
// 90% of the code comes from "daeswf/08_methods/src/main/java/ch/itninja/labs/basicexercises/NumberHelper.java" 

class main {
    static void Main(string[] args) {
        int firstNumber = 5;
        int secondNumber = 9;
        int thirdNumber = 3;

        int result1 = 0;
        int result2 = 0;

        if (firstNumber < secondNumber) {
            result1 = firstNumber;
        } else if (firstNumber > secondNumber) {
            result1 = secondNumber;
        }
        
        if (firstNumber < thirdNumber) {
            result2 = firstNumber;
        } else if (firstNumber > thirdNumber) {
            result2 = thirdNumber;
        }

        
        if (result1 < result2) {
            // return result2;
            
        } else if (result1 > result2) {
            // return result2;
        }
    }
}