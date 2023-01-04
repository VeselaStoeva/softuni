using System;
namespace task41
{
    class Program
    {
        static void Main()
        {
            int dni=int.Parse(Console.ReadLine());
            int day = dni - 1;
            string type=Console.ReadLine();
            string grade=Console.ReadLine();
            double priceType = 0;
            double price = 0;
            if (day<10)
            {
                if (type =="room for one person")
                {
                    priceType = 18;
                    price = priceType * day;
                }
                else if (type=="apartment")
                {
                    priceType = 25;
                    double total = priceType * day;
                    price = total * 0.7;
                }
                else if (type=="president apartment")
                {
                    priceType = 35;
                    double total= priceType * day;
                    price = total * 0.9;
                }
            }
            else if (day>=10 && day<15)
            {
                if (type == "room for one person")
                {
                    priceType = 18;
                    price = priceType * day;
                }
                else if (type == "apartment")
                {
                    priceType = 25;
                    double total = priceType * day;
                    price = total * 0.65;
                }
                else if (type == "president apartment")
                {
                    priceType = 35;
                    double total = priceType * day;
                    price = total * 0.85;
                }
            }
            else if (day>=15)
            {
                if (type == "room for one person")
                {
                    priceType = 18;
                    price = priceType * day;
                }
                else if (type == "apartment")
                {
                    priceType = 25;
                    double total = priceType * day;
                    price = total * 0.5;
                }
                else if (type == "president apartment")
                {
                    priceType = 35;
                    double total = priceType * day;
                    price = total * 0.8;
                }
            }
            if (grade =="positive")
            {
                price *= 1.25;
            }
            else if (grade=="negative")
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:f2}"); 

        }

    }
}
