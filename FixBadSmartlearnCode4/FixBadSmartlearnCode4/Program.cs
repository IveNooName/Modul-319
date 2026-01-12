// See https://aka.ms/new-console-template for more information
 
 class Program {
     static void Main(string[] args) {
         AlterAnzeigen();
     }
 
     static String getName() {
         string name = "Ruby";
         Console.WriteLine("Hallo, " + name + "!");
         return name;
     }
 
     static void AlterAnzeigen() {
         Console.WriteLine(getName() + " ist 20 Jahre alt.");
     }
 }