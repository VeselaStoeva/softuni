using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <=n ; i++)
            {
                int sumDigit = 0;
                int digits = i;
                while (digits>0)
                {
                    sumDigit += digits % 10;
                    digits /= 10;
                }
                if (sumDigit==5 || sumDigit==7|| sumDigit==11)
                {
                   Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}