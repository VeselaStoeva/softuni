using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            
           int num=int.Parse(Console.ReadLine());
            int k = 1;
            while (k <= num)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }

    }
}

