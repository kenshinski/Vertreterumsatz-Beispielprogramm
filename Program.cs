using System;

namespace Vertreterumsatz
{
    class Program
    {
        static void Main(string[] args)
        {
            double umsatz, summe = 0, gesamtSumme = 0;
            int vertreter;
            bool fortsetzen = true;
            double[] vertreterArray = new double[5];
            bool fortsetzenAussen = true;

            while (fortsetzenAussen)
            {
                Console.WriteLine("\nBitte Vertreter-Nr. eingeben (Ende = 0): ");
                vertreter = int.Parse(Console.ReadLine());

                fortsetzen = true;

                if (vertreter == 0)
                {
                    fortsetzenAussen = false;
                    fortsetzen = false;
                }

                summe = 0;

                while (fortsetzen)
                {
                    Console.WriteLine($"Bitte Umsatz für Vertreter {vertreter} eingeben (Ende = 0): ");
                    umsatz = double.Parse(Console.ReadLine());

                    summe += umsatz;

                    if (umsatz == 0)
                    {
                        fortsetzen = false;
                    }
                }
                Console.WriteLine($"\nSumme für Vertreter {vertreter}: {summe} Euro");
                
                gesamtSumme += summe;
            }

            Console.WriteLine($"\nGesamtumsatzsumme: {gesamtSumme}");

        }
    }
}