using System;
namespace task34
{
    class Program
    {
        static void Main()
        {
            double degrees=double.Parse(Console.ReadLine());
            string whether=Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (degrees>=10 && degrees<=18)
            {
            if (whether == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (whether == "Afternoon" || whether == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }

            }
            else if (degrees>18 && degrees<=24)
            {
                if (whether == "Morning" || whether == "Evening")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (whether == "Afternoon")
                {
                    outfit ="T-Shirt";
                    shoes = "Sandals";
                }
               
            }
            else if (degrees>=25)
            {
                if (whether == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (whether == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (whether == "Evening")
                {

                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {(double)degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}


