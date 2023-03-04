using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long illikBudce = 20000000000;
            long mudafieNazirliyi = illikBudce * 20 / 100;
            long yuksekTexNazirliyi = illikBudce * 10 / 100;
            long yerdeQalanBudce = illikBudce - (mudafieNazirliyi + yuksekTexNazirliyi);

            Console.WriteLine("Budce: ");
            Console.WriteLine(illikBudce);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Mudafie Nazirliyine: ");
            Console.WriteLine(mudafieNazirliyi);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Yuksek Texnologiyalar Nazirliyine: ");
            Console.WriteLine(yuksekTexNazirliyi);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Yerde qalan budce: ");
            Console.WriteLine(yerdeQalanBudce);

            Console.ReadLine();
        }
    }
}