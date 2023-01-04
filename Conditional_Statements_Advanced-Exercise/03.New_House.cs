using System;
namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int bydget = int.Parse(Console.ReadLine());
            double totalSym = 0;
            if (typeFlowers == "Roses")
            {
                totalSym = number * 5;
                if (number > 80)
                {
                    totalSym *= 0.9;

                }
            }
            else if (typeFlowers == "Dahlias")
            {
                totalSym = number * 3.80;
                if (number >90)
                {
                    totalSym *= 0.85;
                }
            }
            else if (typeFlowers == "Tulips")
            {
                totalSym = number * 2.80;
                if (number > 80)
                {
                    totalSym *= 0.85;
                }
            }
            else if (typeFlowers == "Narcissus")
            {
                totalSym = number * 3;
                if (number <120)
                {
                    totalSym = totalSym * 1.15;
                }
            }
            else if (typeFlowers == "Gladiolus")
            {
                totalSym = number * 2.50;
                if (number < 80)
                {
                    totalSym = totalSym * 1.2;
                }
            }
            if (bydget > totalSym)
            {
                double ostavat = bydget - totalSym;
                Console.WriteLine($"Hey, you have a great garden with {number} {typeFlowers} and {ostavat:f2} leva left.");
            }
            else if (bydget < totalSym)
            {
                double nyvni = totalSym - bydget;
                Console.WriteLine($"Not enough money, you need {nyvni:f2} leva more.");
            }
        }
    }
}