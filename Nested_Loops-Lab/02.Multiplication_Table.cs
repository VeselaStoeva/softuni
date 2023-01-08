using System;
namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <=10; i++)
            {
                for (int a =1 ; a <=10; a++)
                {
                   int  number = i * a;
                    Console.WriteLine($"{i} * {a} = {number}");
                }
            }
        }
    }
}