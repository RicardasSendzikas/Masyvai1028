using System;

class Program
{
    static void Main()
    {
        // Vartotojo uzklausa ivesti skaiciu masyva
        Console.WriteLine("Iveskite skaiciu, atskirtu tarpais, pvz.: 1 2 3 -4 0:");
        string input = Console.ReadLine();

        // Suskaidome ivesti i string masyva
        string[] inputArray = input.Split(' ');
        int[] masyvas = new int[inputArray.Length];

        // Konvertuojame string masyva i int
        for (int i = 0; i < inputArray.Length; i++)
        {
            masyvas[i] = int.Parse(inputArray[i]);
        }

        // Inicijuojame kintamuosius
        int maxNumber = masyvas[0];
        int minNumber = masyvas[0];
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;
        bool hasEvenNumber = false;

        // Analizuojame masyva
        for (int i = 0; i < masyvas.Length; i++)
        {
            // Rasti didziausia skaiciu
            if (masyvas[i] > maxNumber)
            {
                maxNumber = masyvas[i];
            }
            // Rasti maziausia skaiciu
            if (masyvas[i] < minNumber)
            {
                minNumber = masyvas[i];
            }

            // Suskaiciuojame teigiamus, neigiamus ir nulius
            if (masyvas[i] > 0)
            {
                positiveCount++;
            }
            else if (masyvas[i] < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }

            // Patikriname, ar skaicius lyginis
            if (masyvas[i] % 2 == 0)
            {
                hasEvenNumber = true;
            }
        }

        // Išvedame rezultatus
        Console.WriteLine($"Didziausias skaicius: {maxNumber}");
        Console.WriteLine($"Maziausias skaicius: {minNumber}");
        Console.WriteLine($"Teigiamu skaiciu skaicius: {positiveCount}");
        Console.WriteLine($"Neigiamu skaiciu skaicius: {negativeCount}");
        Console.WriteLine($"Nuliu skaicius: {zeroCount}");

        // Pranesame apie lyginiu skaiciu buvima
        if (hasEvenNumber)
        {
            Console.WriteLine("Masyve yra lyginiu skaiciu.");
        }
        else
        {
            Console.WriteLine("Masyve nera lyginiu skaiciu.");
        }
    }
}