using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0604A2Zufallsverteilung
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zuf = new int[5000];
            int[] anz = new int[10];
            Random zufall = new Random();

            for (int i = 0; i < 5000; i++)
            {
                zuf[i] = zufall.Next(0, 10);
                anz[zuf[i]]++;
            }

            for (int i = 0; i < 10; i++)
                Console.WriteLine("Häufigkeit von {0} ist {1,3}", i, anz[i]);

            Console.WriteLine();
        }
    }
}
