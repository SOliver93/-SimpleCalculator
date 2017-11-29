using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace TestCalculationLib
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator Kalkulator = new Calculator();
            Console.WriteLine("Unesite dva broja: ");
            float fPrviBroj = Convert.ToSingle(Console.ReadLine());
            float fDrugiBroj = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Odaberite jednu od ponuđenih operacija: ");
            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Množenje");
            Console.WriteLine("3. Oduzimanje");
            Console.WriteLine("4. Dijeljenje");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (a)
            {
                case 1:
                    Console.WriteLine(fPrviBroj + "+" + fDrugiBroj + "="+ Kalkulator.Add(fPrviBroj, fDrugiBroj));
                    break;
                case 2:
                    Console.WriteLine(fPrviBroj + "*" + fDrugiBroj + "=" + Kalkulator.Multiply(fPrviBroj, fDrugiBroj));
                    break;
                case 3:
                    Console.WriteLine(fPrviBroj + "-" + fDrugiBroj + "=" + Kalkulator.Substract(fPrviBroj, fDrugiBroj));
                    break;
                case 4:
                    Console.WriteLine(fPrviBroj + "/" + fDrugiBroj + "=" + Kalkulator.Divide(fPrviBroj, fDrugiBroj));
                    break;
                default:
                    Console.WriteLine("Odabrali ste opciju koja ne postoji.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
