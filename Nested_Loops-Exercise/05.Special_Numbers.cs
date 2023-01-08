using System;
namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                int copyI = i;
                bool iSpecial = true;
                for (int j = 1; j <= 4; j++)
                {
                    int currentDigit = copyI % 10;
                    if (num % currentDigit != 0 || currentDigit==0)
                    {
                        iSpecial = false;
                        break;
                    }
                    copyI /= 10;
                }
                if (iSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}