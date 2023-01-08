using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int dailySteps = 10000;
            int totalSteps = 0;
           
            while (totalSteps<dailySteps)
            {
                string  word =Console.ReadLine();
                if (word=="Going home")
                {
                    int number=int.Parse(Console.ReadLine());
                    totalSteps += number;

                    break;
                }
                int steps=int.Parse(word);
                totalSteps+=steps;
            }
            if (totalSteps>=dailySteps)
            {
                int ostavat = totalSteps - dailySteps;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{ostavat} steps over the goal!");
            }
            else
            {
                int need = dailySteps - totalSteps;
                Console.WriteLine($"{need} more steps to reach goal.");
            }
        }
    }
}