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
            int i = 1; int suma=0;
            AfisareSuma1N(i, numar,suma);
        }
        static int AfisareSuma1N(int i, int numar, int suma)
        {
            while (i>numar)
            {
                Console.WriteLine("Suma numereleor de la 1 la " + numar + " este " + suma);
                return suma;
            }
            suma += i;
            AfisareSuma1N(i + 1, numar, suma);
            return suma;
        }
    }
}
