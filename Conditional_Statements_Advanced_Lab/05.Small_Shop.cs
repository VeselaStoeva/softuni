using System;
namespace task29
{
    class Program
    {
        static void Main()
        {


            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());
            if (city == "Sofia" && product == "coffee")
            {
                double rezult = kolichestvo * 0.50;
                Console.WriteLine(rezult);
            }
            else if (city=="Sofia" && product=="water")
            {
                double rezult = kolichestvo * 0.80;
                Console.WriteLine(rezult);
            }
            else if (city == "Sofia" && product == "beer")
            {
                double rezult = kolichestvo * 1.20;
                Console.WriteLine(rezult);
            }
            else if (city == "Sofia" && product == "sweets")
            {
                double rezult = kolichestvo * 1.45;
                Console.WriteLine(rezult);
            }
            else if (city == "Sofia" && product == "peanuts")
            {
                double rezult = kolichestvo * 1.60;
                Console.WriteLine(rezult);
            }
            if (city=="Plovdiv" && product=="coffee")
            {
                double rezult = kolichestvo * 0.40;
                Console.WriteLine(rezult);

            }
            else if (city == "Plovdiv" && product == "water")
            {
                double rezult = kolichestvo * 0.70;
                Console.WriteLine(rezult);
            }
            else if (city == "Plovdiv" && product == "beer")
            {
                double rezult = kolichestvo * 1.15;
                Console.WriteLine(rezult);
            }
            else if (city == "Plovdiv" && product == "sweets")
            {
                double rezult = kolichestvo *1.30 ;
                Console.WriteLine(rezult);
            }
            else if (city == "Plovdiv" && product == "peanuts")
            {
                double rezult = kolichestvo * 1.50;
                Console.WriteLine(rezult);
            }
            if (city=="Varna" && product=="coffee")
            {
                double rezult = kolichestvo * 0.45;
                Console.WriteLine(rezult);
            }
            else if (city == "Varna" && product == "water")
            {
                double rezult = kolichestvo * 0.70;
                Console.WriteLine(rezult);
            }
            else if (city == "Varna" && product == "beer")
            {
                double rezult = kolichestvo * 1.10;
                Console.WriteLine(rezult);
            }
            else if (city == "Varna" && product == "sweets")
            {
                double rezult = kolichestvo * 1.35;
                Console.WriteLine(rezult);
            }
            else if (city == "Varna" && product == "peanuts")
            {
                double rezult = kolichestvo * 1.55;
                Console.WriteLine(rezult);
            }

        }
    }
}