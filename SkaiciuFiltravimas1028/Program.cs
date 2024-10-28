using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Sukuriame masyva 10 skaiciu
        int[] skaiciai = new int[10];

        // Vartotojo ivestis
        Console.WriteLine("Iveskite 10 skaiciu:");
        for (int i = 0; i < skaiciai.Length; i++)
        {
            Console.Write($"Skaicius {i + 1}: ");
            skaiciai[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Filtruojame skaicius, kurie yra didesni už 20
        List<int> didesniUz20 = new List<int>();
        int neigiamuKiekis = 0;

        foreach (var skaicius in skaiciai)
        {
            if (skaicius > 20)
            {
                didesniUz20.Add(skaicius);
            }

            if (skaicius < 0)
            {
                neigiamuKiekis++;
            }
        }

        // Isvedame rezultatus
        Console.WriteLine("\nSkaiciai, didesni už 20:");
        if (didesniUz20.Count > 0)
        {
            foreach (var skaicius in didesniUz20)
            {
                Console.WriteLine(skaicius);
            }
        }
        else
        {
            Console.WriteLine("Nera skaiciu, didesniu už 20.");
        }

        Console.WriteLine($"\nNeigiamu skaičiu kiekis: {neigiamuKiekis}");
    }
}