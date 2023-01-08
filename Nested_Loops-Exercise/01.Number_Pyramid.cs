using System;
namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curent = 1;
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (curent>n)
                    {
                        return;
                    }
                    Console.Write(curent + " ");
                    curent++;
                }
                Console.WriteLine();
            }
        }
        
    }
}