using System;
namespace task25
{
    class Program
    {
        static void Main()
        {
            double bydvet=double.Parse(Console.ReadLine());
            double statisti=double.Parse(Console.ReadLine());
            double priceObleclo=double.Parse(Console.ReadLine());
            double symDecor = 0.1 * bydvet;
            double symObleclo = statisti * priceObleclo;
            double totalSym = symDecor + symObleclo;
            if (statisti>150)
            {
               symObleclo *= 0.1;
            }
            if (symDecor>bydvet && symObleclo>bydvet)
            {
                double nuvni =totalSym-bydvet;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard need {nuvni} leva more.");
            }
            else if (symDecor<bydvet && symObleclo<bydvet)
            {
                double ostavat = bydvet - totalSym;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard start filming with {ostavat} leva left.");
            }

          
           
               
            

        }
    }
}