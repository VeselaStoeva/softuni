using System;
namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total =0 ;

            for (int i = 1; i <=n; i++)
            {
                decimal num= decimal.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine($"{total}");
        }
    }
}