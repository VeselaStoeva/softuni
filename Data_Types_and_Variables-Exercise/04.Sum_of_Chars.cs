using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <=n; i++)
            {

                char simvol = char.Parse(Console.ReadLine());
                total += (int)simvol;
            }
            Console.WriteLine($"The sum equals: {total}");
            

        }
    }
}