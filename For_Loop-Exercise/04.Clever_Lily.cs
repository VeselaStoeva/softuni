using System;
namespace task46
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double pricePeralna=double.Parse(Console.ReadLine());
            int priceIgra=int.Parse(Console.ReadLine());
            int brojIgra = 0;
            int brojMoney = 0;
            double sum = 0;
            double p = 0;
            for (int i = 1; i <= n; i++)
            {

                if (i % 2==1)
                {
                    brojIgra++;
                }
                if (i % 2==0)
                {
                    brojMoney++;
                    sum = brojMoney * 10;
                    p += sum;


                }
            }
            double price1 = (double)brojIgra * (double)priceIgra;
            double price = (double)brojMoney * 1;
            double total=(price1 +p) - price;
            if (total>pricePeralna)
            {
                double ostavt = total - pricePeralna;
                Console.WriteLine($"Yes! {ostavt:f2}");
            }
            else
            {
                double nyvni = pricePeralna - total;
                Console.WriteLine($"No! {nyvni:f2}");
            }
        }
    }
}