using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numar = random.Next(0, 101);
            Console.Write("Introduceti un numar intre 0 si 100, inclusiv. Daca ghiciti aveti sansa sa castigati premiul cel mare.\n");
            string str = Console.ReadLine();
            int ghicire = int.Parse(str);
            int limitaSup = 100;
            int limitaInf = 0;
            while (ghicire != numar)
            {
                if ((ghicire < limitaInf) || (ghicire > limitaSup))
                {
                    Console.WriteLine("Numar in afara ariei de ghicire. Introduceti un numar intre " + limitaInf + " si " + limitaSup + ", inclusiv.");
                    str = Console.ReadLine();
                    ghicire = int.Parse(str);
                }
                if (ghicire < numar)
                {
                    limitaInf = ghicire;
                    Console.WriteLine("Numarul cautat este mai mare. Introduceti un numar intre " + limitaInf + " si " + limitaSup);
                    str = Console.ReadLine();
                    ghicire = int.Parse(str);
                }
                else
                {
                    limitaSup = ghicire;
                    Console.WriteLine("Numarul cautat este mai mic. Introduceti un numar intre " + limitaInf + " si " + limitaSup);
                    str = Console.ReadLine();
                    ghicire = int.Parse(str);
                }
            }
            Console.WriteLine("Felicitari! Ati ghicit corect. Numarul era " + numar + ". Tocmai ati intrat in cursa pentru o Toyota Avensis 2019.");
            Console.ReadKey();
        }
    }
}
