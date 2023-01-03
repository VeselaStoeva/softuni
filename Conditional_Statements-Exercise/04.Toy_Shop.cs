using System;
namespace task23
{      
    class Program
    {
        static void Main()
        {
           double moneyHolidays=double.Parse(Console.ReadLine());
            int brojPuzzle=int.Parse(Console.ReadLine());
            int brojCucla=int.Parse(Console.ReadLine());
            int brojBear=int.Parse(Console.ReadLine());
            int brojMinyon=int.Parse(Console.ReadLine());
            int brojKamionche=int.Parse(Console.ReadLine());
            double puzzle = 2.60;
            int cucla = 3;
            double bear = 4.10;
            double minyon = 8.20;
            int kamionche = 2;
            double sym =(double) brojPuzzle * puzzle + (double)brojCucla *(double) cucla +(double) brojMinyon * minyon + (double) brojKamionche * (double)kamionche + (double)brojBear*bear;
            double naem = sym * 0.1;
            double newSym = sym - naem;

            int poruchaniIgrachki = brojPuzzle + brojCucla + brojMinyon + brojKamionche;

            if (poruchaniIgrachki>=50)
            {
                newSym *= 0.25;
                
            }
            if (moneyHolidays<newSym)
            {
                    double ostavat = newSym - moneyHolidays;
                Console.WriteLine($"Yes! {ostavat:f2} lv left.");

            }
            else if (moneyHolidays>newSym)
            {
                    double nyvni = moneyHolidays - newSym;
                Console.WriteLine($"Not enough money! {nyvni:f2} lv needed.");
            }
        }

    }
}


           

