using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double total = Math.Ceiling((double)n /(double) p);
            Console.WriteLine(total);
           
            

        }
    }
}