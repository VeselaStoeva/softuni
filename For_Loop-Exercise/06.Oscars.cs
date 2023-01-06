using System;
namespace fdgh2
{
    class Program
    {
        static void Main()
        {
            string name=Console.ReadLine();
            double pointsAkademi=double.Parse(Console.ReadLine());
            int brojOcenqvaci=int.Parse(Console.ReadLine());
            double total = pointsAkademi;
            bool sum=false;
            for (int i = 1; i < brojOcenqvaci; i++)
            {
                string naemeOcenqvaci = Console.ReadLine();
                double pointsOcenqvaci=double.Parse(Console.ReadLine());
                double points = (double)naemeOcenqvaci.Length * pointsOcenqvaci / 2;
                total += points;

                if (total>1250.5)
                {
                    sum=true;
                    break;
                }
            }
            if (sum)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {total:f1}!");
            }
            else
            {
                double nyvni = 1250.5 - total;
                Console.WriteLine($"Sorry, {name} you need {nyvni:f1} more!");
            }

        }
    }
}