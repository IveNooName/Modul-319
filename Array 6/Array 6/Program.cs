// See https://aka.ms/new-console-template for more information

public class MainClass {
    public static void Main() {
        int max = 30;
        bool[] prim = new bool[max + 1];


        for (int i = 2; i < max; i++) {
            prim[i] = true;
        }

        for (int i = 2; i < max; i++) {
            if (prim[i]) {
                for (int j = i; j < max; j++) {
                    if (j == i) {
                        continue;
                    }

                    if (j % i == 0) {
                        prim[j] = false;
                    }
                }
            }
        }

        //PRINT
        for (int b = 0; b <= max; b++) {
            Console.Write(b + ": " + (prim[b] ? "PRIM" : "—") + "\n");
        }
    }
}