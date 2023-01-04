using System;
namespace task44
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0; 

            for (int i = 0; i < n; i++)
            {
                int number=int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += number;

                }
                if (i % 2 == 1)
                {
                    sumOdd += number;
                }
                
            }
            
            
            if (sumEven==sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No \n Diff = {Math.Abs(sumEven - sumOdd)}");
                //Console.WriteLine("No");
                //Console.WriteLine($"Diff = {Math.Abs(sumEven-sumOdd)}");
            }
        }
    }
}