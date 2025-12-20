namespace PasswordProject;

public class Letters {
    public static char[][] LettersForPassword() {
        char[][] matrix = new char[4][];
        matrix[0] = new char[] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
        matrix[1] = new char[] {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        matrix[2] = new char[]  {
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
        };
        matrix[3] = new char[]  {
            '!', '"', '#', '$', '%', '^', '&', '*', '+', 
            ',', '-', '.', '/', ':', ';', '?', '@', '[', 
            ']', '^', '_', '`', '{', '|', '}', '~'
        };
        return matrix;
    }
}