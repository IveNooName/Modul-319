namespace PasswordProject;

public class Loggify {
    public static void warn(String msg) {
        Console.WriteLine("\u001B[33m[WARN]: " + msg + "\u001B[0m");
    }

    public static void error(String msg) {
        Console.WriteLine("\u001B[31m[ERROR]: " + msg + "\u001B[0m");
    }

    public static void info(String msg) {
        Console.WriteLine("\u001B[34m[INFO]: " + msg + "\u001B[0m");
    }

    public static void success(String msg) {
        Console.WriteLine("\u001B[32m[SUCCESS]: " + msg + "\u001B[0m");
    }
}