using System;

class Studentas
{
    public string Vardas { get; set; }
    public int[] Pazymiai { get; set; }

    public Studentas(string vardas, int[] pazymiai)
    {
        Vardas = vardas;
        Pazymiai = pazymiai;
    }

    public double Vidurkis()
    {
        if (Pazymiai.Length == 0)
        {
            return 0; // Jei nera pazymiu, graziname 0
        }

        int suma = 0;
        foreach (var pazymys in Pazymiai)
        {
            suma += pazymys;
        }
        return (double)suma / Pazymiai.Length;
    }

    public bool Islaike()
    {
        return Vidurkis() >= 5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Sukuriame studentu masyva
        Studentas[] studentai = new Studentas[]
        {
            new Studentas("Jonas", new int[] { 6, 7, 8 }),
            new Studentas("Ona", new int[] { 4, 5, 5 }),
            new Studentas("Petras", new int[] { 5, 5, 5 }),
            new Studentas("Agnė", new int[] { 8, 9, 10 }),
            new Studentas("Rimas", new int[] { 3, 4, 2 })
        };

        Console.WriteLine("Studentai, kurie islaike:");
        foreach (var studentas in studentai)
        {
            if (studentas.Islaike())
            {
                Console.WriteLine($"{studentas.Vardas} - Vidurkis: {studentas.Vidurkis():0.00}");
            }
        }
    }
}