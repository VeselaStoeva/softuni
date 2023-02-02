using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           int x=int.Parse(Console.ReadLine());
            int y=int.Parse(Console.ReadLine());    
            int k=int.Parse(Console.ReadLine());
            int total1 =Math.Abs( n + x);
            int sum =Math.Abs (total1 / y); 
            int sum2=Math.Abs (sum * k);
            Console.WriteLine($"{sum2}");

        }
    }
}