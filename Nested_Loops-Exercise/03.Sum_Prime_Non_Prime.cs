using System;
namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int sumProsti = 0;
            int sumNeprosti = 0;
            while ((word = Console.ReadLine()) != "stop")
            {
                int numbers = int.Parse(word);

                if (numbers < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool prosto = true;
                for (int i = 2; i < numbers; i++)
                {
                    int reminder = numbers % i;
                    if (reminder==0)
                    {
                        prosto=false;
                        break;
                    }
                }
                if (prosto)
                {
                    sumProsti += numbers;
                }
                else
                {
                    sumNeprosti += numbers;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumProsti}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNeprosti}");
        }
    }
}