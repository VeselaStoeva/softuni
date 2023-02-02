using System;
namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometrs = meters *1.31M;
            Console.WriteLine($"{kilometrs:f3}");
        }
    }
}