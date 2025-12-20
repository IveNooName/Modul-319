// See https://aka.ms/new-console-template for more information

class Program {
    // static void Main() {
    //     
    //     List<string> MostLovedSeriesAndFilms = new List<string>();
    //     
    //     MostLovedSeriesAndFilms.Add("Foundation");
    //     MostLovedSeriesAndFilms.Add("The Imitation Game");
    //     MostLovedSeriesAndFilms.Add("Wednesday");
    //
    //     Console.WriteLine("My Most Loved Film is: " + MostLovedSeriesAndFilms[1]);
    //     
    //     MostLovedSeriesAndFilms.Remove("Wednesday");
    //
    //     MostLovedSeriesAndFilms.Add("Crash Landing on You");
    //
    //     foreach (string film in MostLovedSeriesAndFilms) {
    //         Console.WriteLine(film);
    //     }
    // }

    // static void Main(string[] args) {
    //     
    //     Dictionary<int, string> user = new Dictionary<int, string>();
    //     
    //     user.Add(1, "Ruby");
    //     user.Add(2, "Bob");
    //     
    //     string name = user[1]; // Gibt "Ruby" zurück
    //
    //     //Safe usage
    //     if (user.ContainsKey(102)) {
    //         Console.WriteLine("Benutzer 102 ist: " + user[102]);
    //     }
    //     
    //     foreach (KeyValuePair<int, string> eintrag in user) {
    //         Console.WriteLine($"ID: {eintrag.Key}, Name: {eintrag.Value}");
    //     }
    // }

    static void Main(string[] args) {
        HashSet<int> zahlen = new HashSet<int>();

        zahlen.Add(1);
        zahlen.Add(2);
        zahlen.Add(3);

        // Versuch, ein Duplikat hinzuzufügen (wird ignoriert, wirft keinen Fehler)
        bool wurdeHinzugefuegt = zahlen.Add(2); // Gibt 'false' zurück

        // Schnelles Prüfen
        if (zahlen.Contains(1)) {
            Console.WriteLine("Die 1 ist im Set enthalten.");
        }

        // Mengenoperationen (z.B. Schnittmenge)
        HashSet<int> andereZahlen = new HashSet<int> { 3, 4, 5 };
        zahlen.IntersectWith(andereZahlen); // 'zahlen' enthält jetzt nur noch { 3 }
    }
    
}