using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int maxNumber = int.MinValue;
            while (true)
            {
                string text = Console.ReadLine();
                if (text=="Stop")
                {
                    break;
                }
                int number=int.Parse(text);
                if (number>maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }

    }
}

