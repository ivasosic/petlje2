using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja_petlje_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start: Console.Write("Unesite neki pozitivan broj: ");
                int br1 = Convert.ToInt32(Console.ReadLine());
                if (br1 <= 0)
                {
                    Console.WriteLine("Unesite drugi broj.");
                    goto start;
                }
                string str = "";
                for (int i = 1; i <= br1 - 1; i++)
                {
                    str = str + i;
                    Console.WriteLine(str);
                }
            Console.ReadKey();
        }
    }
}