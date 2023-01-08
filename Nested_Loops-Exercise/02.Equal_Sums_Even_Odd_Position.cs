using System;
namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <=secondNumber; i++)
            {
                string curentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < curentNumber.Length; j++)
                {
                    int curentDigit = int.Parse(curentNumber[j].ToString());
                    if (j%2==0)
                    {
                        evenSum += curentDigit;
                    }
                    else
                    {
                        oddSum += curentDigit;

                    }
                }
                if (evenSum==oddSum)
                {
                    Console.Write(i + " " );
                }
            }
        }
        
    }
}