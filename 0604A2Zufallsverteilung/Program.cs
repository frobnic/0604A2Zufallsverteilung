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
            int cnt = 5000;
            int[] zuf = new int[cnt];
            int[] anz = new int[10];
            int m = 0,j;
            Random zufall = new Random();

            for (int i = 0; i < cnt; i++)
            {
                zuf[i] = zufall.Next(0, 10);
                anz[zuf[i]]++;
                m = Math.Max(m, anz[zuf[i]]);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Häufigkeit von {0} ist {1,3} ", i, anz[i]);
                for (j = 0; j < (60 / (float)m * (float)(anz[i])); j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
