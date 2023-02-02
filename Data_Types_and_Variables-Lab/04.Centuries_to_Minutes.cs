using System;
using System.Numerics;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          int years = n * 100;
            long days = (long)Math.Truncate(years * 365.2422);
            long hours = days * 24;
         BigInteger minutes= hours * 60;
            Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}