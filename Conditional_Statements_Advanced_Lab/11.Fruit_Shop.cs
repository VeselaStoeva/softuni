using System;
namespace task32
{
   

    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            double rezult = 0;
            if (product == "banana")
            {
                 
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    rezult = number * 2.50;
                    Console.WriteLine($"{rezult:f2}");

                }
            }
            else if (product == "apple")
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                     rezult = number * 1.20;
                    Console.WriteLine($"{rezult:f2}");
                }
                else if(day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 1.25;
                    Console.WriteLine($"{rezult:f2}");

                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (product == "orange")
            {
                
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    rezult = number * 0.85;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "graipfruit")
            {
               
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    rezult = number * 1.45;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "kiwi")
            {
                
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    rezult = number * 2.70;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "pineapple")
            {
                
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    rezult = number * 5.50;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "grapes")
            {
               
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                {
                    rezult = number * 3.85;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            if (product == "banana")
            {
                
                if (day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 2.70;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "apple")
            {
                
                if (day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 1.25;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "orange")
            {
                 
                if (day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 0.90;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "grapefruit")
            {
                
                if (day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 1.60;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "kiwi")
            {
                 
                if (day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 3.00;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "pineapple")
            {
                
                if (day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 5.60;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else if (product == "grapes")
            {
                
                if (day == "Saturday" || day == "Sunday")
                {
                    rezult = number * 4.20;
                    Console.WriteLine($"{rezult:f2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}