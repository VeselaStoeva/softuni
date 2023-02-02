using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n= int.Parse(Console.ReadLine());
            int maxValue = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 1; i <=n ; i++)
            {
                int total = 0;
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime= int.Parse(Console.ReadLine());    
                int snowballQuality= int.Parse(Console.ReadLine());
                total = (snowballSnow / snowballTime) ^ snowballQuality;
                if (maxValue<total)
                {
                    maxValue= total;
                    sum1 = snowballSnow;
                    sum2= snowballTime;
                    sum3 = snowballQuality;




                }
            }
            Console.WriteLine($"{sum1} : {sum2} = {maxValue} ({sum3})");

            




        }
    }
}