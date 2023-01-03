using System;
namespace task26
{
    class Program
    {
        static void Main()
        {
            double recordSecond=double.Parse(Console.ReadLine());
            double rastoqnieMetri=double.Parse(Console.ReadLine());
            double timeSecond=double.Parse(Console.ReadLine());
            double vremeVsecond = rastoqnieMetri * timeSecond;
            double sto = rastoqnieMetri / 15;
            double dobavqne = sto * 12.5;
            double totalTime = vremeVsecond + dobavqne;
            if (totalTime<recordSecond)
            { 

                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
               
            }
            else if (totalTime>recordSecond)
            {
                double nedostignati = totalTime - recordSecond;
                Console.WriteLine($"No, he failed! He was {nedostignati:f2} seconds slower.");
            }
           
        }
    }
}
