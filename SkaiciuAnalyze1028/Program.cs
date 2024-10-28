
class Program
{
    static void Main(string[] args)
    {
        // Sukuriame prekiu sarasa
        List<Preke> prekiuZinynas = new List<Preke>
        {
            new Preke("Knyga", 15.00m),
            new Preke("Puodelis", 10.00m),
            new Preke("Pusryčių dribsniai", 5.00m),
            new Preke("Organizeris", 20.00m),
            new Preke("Rankinė", 30.00m)
        };

        PrekiuKrepselis krepselis = new PrekiuKrepselis();

        while (true)
        {
            Console.WriteLine("Pasirinkite preke (1-5) arba 0, kad baigti:");
            for (int i = 0; i < prekiuZinynas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {prekiuZinynas[i].Pavadinimas} - {prekiuZinynas[i].Kaina} EUR");
            }

            Console.Write("Pasirinkite prekes numeri: ");
            string pasirinkimas = Console.ReadLine();

            if (pasirinkimas == "0")
            {
                break; // Iseiti is ciklo, jei pasirinkta 0
            }

            if (int.TryParse(pasirinkimas, out int prekesNumeris) && prekesNumeris > 0 && prekesNumeris <= prekiuZinynas.Count)
            {
                Console.Write("Iveskite kieki: ");
                if (int.TryParse(Console.ReadLine(), out int kiekis) && kiekis > 0)
                {
                    krepselis.PridetiPreke(prekiuZinynas[prekesNumeris - 1], kiekis);
                }
                else
                {
                    Console.WriteLine("Neteisingas kiekis. Prasome ivesti teigiama skaiciu.");
                }
            }
            else
            {
                Console.WriteLine("Neteisingas pasirinkimas.");
            }
        }

        // Rodyti pasirinktu prekiu informacija
        krepselis.RodytiPrekes();

        // Patikriname bendra kaina
        decimal bendraKaina = krepselis.BendraKaina();
        Console.WriteLine($"Bendra kaina: {bendraKaina} EUR");
        krepselis.PatikrintiKaina();
    }
}