using System;

class Program
{
    static void Main(string[] args)
    {
        // Savaites dienu pavadinimai
        string[] savaitesDienos = { "Pirmadienis", "Antradienis", "Treciadienis", "Ketvirtadienis", "Penktadienis", "Sestadienis", "Sekmadienis" };

        // Sukuriame masyva temperaturoms
        double[] temperaturuMasyvas = new double[7];

        // Vartotojo ivestis
        Console.WriteLine("Iveskite temperaturas 7 dienoms (Celsijaus laipsniais):");
        for (int i = 0; i < savaitesDienos.Length; i++)
        {
            Console.Write($"{savaitesDienos[i]}: ");
            temperaturuMasyvas[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Rasti auksciausia temperatura
        double auksciausiaTemperatura = temperaturuMasyvas[0];
        for (int i = 1; i < temperaturuMasyvas.Length; i++)
        {
            if (temperaturuMasyvas[i] > auksciausiaTemperatura)
            {
                auksciausiaTemperatura = temperaturuMasyvas[i];
            }
        }

        // Apskaiciuoti temperaturu vidurki
        double suma = 0;
        for (int i = 0; i < temperaturuMasyvas.Length; i++)
        {
            suma += temperaturuMasyvas[i];
        }
        double vidurkis = suma / temperaturuMasyvas.Length;

        // Isvedame rezultatus
        Console.WriteLine($"\nAuksciausia savaites temperatura: {auksciausiaTemperatura}°C");

        if (vidurkis < 10)
        {
            Console.WriteLine("Savaites temperaturos vidurkis yra mazesnis nei 10.");
        }
    }
}