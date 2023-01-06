using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int minNumber = int.MaxValue;
            while (true)
            {
                string text = Console.ReadLine();
                if (text=="Stop")
                {
                    break;
                }
                int number=int.Parse(text);
                if (number<minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }

    }
}

