using System;

namespace Ex5_Laborator4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 5
            //Scrieti o functie recursiva care va afisa suma numerelor de la 1 pana la n,
            //apelati - o si afisati-i rezultatul.

            Console.WriteLine("Introduceti un numar:");
            int numar = int.Parse(Console.ReadLine());

            int rezultat = AfisareSuma1N(numar);
            Console.WriteLine("Suma numereleor de la 1 la " + numar + " este " + rezultat);
        }
        static int AfisareSuma1N( int numar)
        {
            if (numar== 1)
            {
                return numar;
            }
            return numar + AfisareSuma1N(numar - 1);
        }
    }
}
