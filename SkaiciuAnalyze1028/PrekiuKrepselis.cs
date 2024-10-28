using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class Preke
{
    public string Pavadinimas { get; set; }
    public decimal Kaina { get; set; }

    public Preke(string pavadinimas, decimal kaina)
    {
        Pavadinimas = pavadinimas;
        Kaina = kaina;
    }
}

class PrekiuKrepselis
{
    private List<(Preke Preke, int Kiekis)> prekiuSarasas = new List<(Preke, int)>();

    public void PridetiPreke(Preke preke, int kiekis)
    {
        prekiuSarasas.Add((preke, kiekis));
    }

    public decimal BendraKaina()
    {
        decimal bendraKaina = 0;
        foreach (var (preke, kiekis) in prekiuSarasas)
        {
            bendraKaina += preke.Kaina * kiekis;
        }
        return bendraKaina;
    }

    public void PatikrintiKaina()
    {
        decimal bendraKaina = BendraKaina();
        if (bendraKaina > 50)
        {
            Console.WriteLine("Krepselio suma virsija 50");
        }
        else
        {
            Console.WriteLine("Krepselio suma yra 50 arba maziau");
        }
    }

    public void RodytiPrekes()
    {
        Console.WriteLine("Pasirinktos prekes:");
        foreach (var (preke, kiekis) in prekiuSarasas)
        {
            Console.WriteLine($"{preke.Pavadinimas}: {kiekis} vnt. po {preke.Kaina} EUR");
        }
    }
}
