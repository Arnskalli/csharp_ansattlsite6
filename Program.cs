void skrivUtAnsatt(List<string> navn){
    Console.Write("Fornavn: ");
    Console.WriteLine(navn[0]);
    Console.Write("Etternavn: ");
    Console.WriteLine(navn[1]);
}

void main() {
    // Definere en liste med liste over ansatte
    List<List<string>> ansattliste = new List<List<string>>();
    // Definerer variabel for menyvalg
    Int16 valg = 1;
    // Så lenge valg ikke er 0
    while (valg != 0){
        // Leser inn data fra bruker
        Console.Write("Fornavn: ");
        string fornavn = Console.ReadLine();
        Console.Write("Etternavn: ");
        string etternavn = Console.ReadLine();
        // Definerer liste for en ansatt
        List<string> ansatt = new List<string>();
        ansatt.Add(fornavn);
        ansatt.Add(etternavn);
        // Legger inn ansatt inn i listen ansattliste
        ansattliste.Add(ansatt);
        Console.Write("Trykk 1 for å legge inn flere, 0 for å avslutte: ");
        string valgTekst = Console.ReadLine();
        // Konverterer fra tekst til tall
        valg = Convert.ToInt16(valgTekst);
    }
    foreach(List<string> navn in ansattliste)
    {
        skrivUtAnsatt(navn);
    }
}

main();

