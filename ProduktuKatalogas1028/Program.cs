using System;

class Produktas
{
    public string Pavadinimas { get; set; }
    public decimal Kaina { get; set; }
    public int Kiekis { get; set; }

    public Produktas(string pavadinimas, decimal kaina, int kiekis)
    {
        Pavadinimas = pavadinimas;
        Kaina = kaina;
        Kiekis = kiekis;
    }

    public bool YraSandelyje()
    {
        return Kiekis > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Sukuriame produktu masyva
        Produktas[] produktai = new Produktas[]
        {
            new Produktas("Pienas", 1.20m, 10),
            new Produktas("Duona", 0.80m, 0),
            new Produktas("Sūris", 2.50m, 5),
            new Produktas("Kava", 9.99m, 3),
            new Produktas("Saldainiai", 5.00m, 20)
        };

        Console.WriteLine("Produktai, kurie yra sandelyje ir kainuoja maziau nei 10 EUR:");
        foreach (var produktas in produktai)
        {
            if (produktas.YraSandelyje() && produktas.Kaina < 10)
            {
                Console.WriteLine($"{produktas.Pavadinimas} - Kaina: {produktas.Kaina} EUR, Kiekis: {produktas.Kiekis}");
            }
        }
    }
}