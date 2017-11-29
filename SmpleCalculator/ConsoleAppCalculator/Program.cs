using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva broja: ");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Odaberite matematičku operaciju: ");
            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Množenje");
            Console.WriteLine("3. Oduzimanje");
            Console.WriteLine("4. Dijeljenje");
            float rezultat;
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    rezultat = a + b;
                    Console.WriteLine(a + "+" + b + "=" + rezultat);
                    break;
                case 2:
                    rezultat = a * b;
                    Console.WriteLine(a + "*" + b + "=" + rezultat);
                    break;
                case 3:
                    rezultat = a - b;
                    Console.WriteLine(a + "-" + b + "=" + rezultat);
                    break;
                case 4:
                    rezultat = a / b;
                    Console.WriteLine(a + "/" + b + "=" + rezultat);
                    break;
                default:                    
                    Console.WriteLine("Odabrali ste opciju koja ne postoji.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
