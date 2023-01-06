using System;
namespace task45
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            int newSum = sum - max;
            var finalRezult = max == newSum ? $"Yes \n Sum = {max}" : $"No \n Diff = {Math.Abs(max - newSum)}";
            Console.WriteLine(finalRezult);
        }
    }
}