using System;
namespace task33
{
    class Program
    {
        static void Main()
        {
            string town=Console.ReadLine();
             double obem=double.Parse(Console.ReadLine());
            double rezult = 0;
            if (town =="Sofia" && obem >= 0 && obem <= 500)
            {
                rezult = obem * 0.5;
                Console.WriteLine($"{rezult:f2}");

            }
            else if (town == "Sofia" && obem > 500 && obem <= 1000)
            {

                rezult = obem * 0.7;
                Console.WriteLine($"{rezult:f2}");
            }
            else if (town == "Sofia" && obem > 1000 && obem <= 10000)
            {
                rezult = obem * 0.8;
                Console.WriteLine($"{rezult:f2}");

            }
            else if (town == "Sofia" && obem > 10000)
            {
                rezult = obem * 0.12;
                Console.WriteLine($"{rezult:f2}");

            }
           
            if (town == "Varna" && obem >= 0 && obem <= 500)
            {
                rezult = obem * 0.045;
                Console.WriteLine($"{rezult:f2}");

            }
            else if (town == "Varna" && obem > 500 && obem <= 1000)
            {
                rezult = obem * 0.075;
                Console.WriteLine($"{rezult:f2}");
            }
            else if (town == "Varna" && obem > 1000 && obem <= 10000)
            {
                rezult = obem * 0.1;
                Console.WriteLine($"{rezult:f2}");
            }
            else if (town == "Varna" && obem > 10000)
            {
                rezult = obem * 0.13;
                Console.WriteLine($"{rezult:f2}");
            }
            if (town == "Plovdiv" && obem >= 0 && obem <= 500)
            {
                rezult = obem * 0.055;
                Console.WriteLine($"{rezult:f2}");

            }
            else if (town == "Plovdiv" && obem > 500 && obem <= 1000)
            {
                rezult = obem * 0.8;
                Console.WriteLine($"{rezult:f2}");
            }
            else if (town == "Plovdiv" && obem > 1000 && obem <= 10000)
            {
                rezult = obem * 0.12;
                Console.WriteLine($"{rezult:f2}");
            }
            else if (town == "Plovdiv" && obem > 10000)
            {
                rezult = obem * 0.145;
                Console.WriteLine($"{rezult:f2}");
            }
            




        }
    }
}
