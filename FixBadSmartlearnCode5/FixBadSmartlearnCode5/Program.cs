// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(string[] args) {
        int personCounter = 3;
        double pricePerTicket = 11.50;

        calculateTotalPrice(personCounter, pricePerTicket);
    }


    static void calculateTotalPrice(int personCounter,  double pricePerTicket) {
        double totalPrice = personCounter * pricePerTicket;
        Console.WriteLine("Gesamtpreis: " + totalPrice + " CHF");
    }
}