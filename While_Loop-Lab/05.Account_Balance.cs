using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            double balance = 0;
            while (true)
            {
                string text = Console.ReadLine();
                if (text== "NoMoreMoney")
                {
                    break;
                }
                double number=double.Parse(text);
                if (number<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += number;
                Console.WriteLine($"Increase: {number:f2}");


            }
            Console.WriteLine($"Total: {balance:f2}");
          
        }

    }
}

