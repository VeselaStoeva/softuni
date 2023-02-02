using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
           int x= int.Parse(Console.ReadLine());
            for (int i = n; i <=x; i++)
            {
                char a = (char)i;
                Console.Write($"{a} ");
            }

        }
    }
}