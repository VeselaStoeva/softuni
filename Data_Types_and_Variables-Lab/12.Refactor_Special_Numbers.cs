using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int newSum = 0;
            bool value = false;
            bool value2 = true;
            for (int i = 1; i <= n; i++)
            {
                newSum = i;
                while (i > 0)
                {
                    total +=i % 10;
                    i /= 10;
                }
                if (total == 5 || total == 7 || total == 11)
                {
                    Console.WriteLine("{0} -> {1}", newSum,value2 );
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", newSum,value );
                }

                total = 0;
                i = newSum;
            }

        }
    }
}