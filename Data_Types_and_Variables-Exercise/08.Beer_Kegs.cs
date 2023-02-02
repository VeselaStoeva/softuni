using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
            double maxValue = 0;
            string maxName = "";
            for (int i = 0; i < n; i++)
            {
                double total = 0; 
                string name = Console.ReadLine();
                double radios= double.Parse(Console.ReadLine());    
                double heihght= double.Parse(Console.ReadLine());
                total = Math.PI * Math.Pow(radios, 2) * heihght;
                if (maxValue<total)
                {
                    maxValue = total;
                    maxName = name;
                }

            }
            Console.WriteLine(maxName);
        }
    }
}