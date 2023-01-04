using System;
namespace task37
{
    class Program
    {
        static void Main()
        {
            double bydget=double.Parse(Console.ReadLine());
            string sezoni=Console.ReadLine();
            string destination = "";
            string typeholiday = "";
            double sum = 0;
            if (bydget<=100)
            {
                destination = "Bulgaria";
                if (sezoni=="summer")
                {
                    typeholiday = "Camp";
                    double sym= bydget * 0.7;
                    sum = bydget - sym;



                }
                else if (sezoni=="winter")
                {
                    typeholiday = "Hotel";
                   double sim= bydget * 0.3;
                    sum= bydget - sim;
                }

            }
            else if (bydget<=1000)
            {
                destination = "Balkans";
                if (sezoni == "summer")
                {
                    typeholiday = "Camp";
                   double sym= bydget * 0.6;
                    sum=bydget - sym;

                }
                else if (sezoni == "winter")
                {
                    typeholiday = "Hotel";
                    double sim = bydget * 0.2;
                    sum = bydget - sim;

                }
            }
            else if (bydget>1000)
            {
                destination = "Europe";
                typeholiday = "Hotel";
              double  sym = bydget * 0.1;
                sum= bydget - sym;

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeholiday} - {sum:f2}");
        }

    }
}