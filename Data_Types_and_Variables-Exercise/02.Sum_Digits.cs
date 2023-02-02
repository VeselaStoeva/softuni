using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int total = 0;
           
            while (num > 0)
            {
                int digit=num% 10;
                total += digit;
             num /= 10;
            }
            Console.WriteLine(total);
            

        }
    }
}