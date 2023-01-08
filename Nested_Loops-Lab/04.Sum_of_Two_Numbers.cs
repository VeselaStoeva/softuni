using System;
namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber=int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <=secondNumber; j++)
                {
                    total++;
                    if (i+j==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{total} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{total} combinations - neither equals {magicNumber}");
        }
    }
}