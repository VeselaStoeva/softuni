using System;
namespace task39
{
    class Program
    {
        static void Main()
        {
            string months=Console.ReadLine();
            double broj=double.Parse(Console.ReadLine());
            double studio = 0;
            double apartament = 0;
            double priceStudio = 0;
            double priceApartament = 0;
            if (months == "May" || months == "October")
            {

                if (broj>0 && broj<14)
                {
                    apartament = 65;
                    priceApartament = broj * apartament;
                }
                else if (broj>=14)
                {
                    apartament = 65;
                    double total = apartament * 0.9;
                    priceApartament = total * broj;
                }
                

            }
            else if (months=="June" || months=="September")
            {
                if (broj > 0 && broj < 14)
                {
                    apartament = 68.70;
                    priceApartament = broj * apartament;
                }
                else if (broj >= 14)
                {
                    apartament = 68.70;
                    double total = apartament * 0.9;
                    priceApartament = total *(double) broj;
                }
            }
            else if (months=="July" || months=="August")
            {
                if (broj > 0 && broj < 14)
                {
                    apartament = 77;
                    priceApartament = broj * apartament;
                }
                else if (broj >= 14)
                {
                    apartament = 77;
                    double total = apartament * 0.9;
                    priceApartament = total * broj;
                }
            }
            if (months == "May" || months == "October")
            {
                if (broj>=7 && broj<14)
                {
                    studio = 50;
                    double total = studio * 0.95;
                    priceStudio=total * broj;
                }
                else if (broj>=14)
                {
                    studio = 50;
                    double total = studio * 0.7;
                    priceStudio = total * broj;
                }
            }
            else if (months == "June" || months == "September")
            {
                if (broj >= 7 && broj<14)
                {
                    studio = 75.20;
                    priceStudio = studio * broj;
                }
                else if (broj >= 14)
                {
                    studio = 75.20;
                    double total = studio * 0.8;
                    priceStudio = total * (double)broj;
                }
            }
            else if (months == "July" || months == "August")
            {
                if (broj >= 0 && broj < 14)
                {
                    studio = 76;
                   priceStudio = broj * studio;
                }
                else if (broj >= 14)
                {
                    studio = 76;
                    priceStudio = broj * studio;
                }
            }
            Console.WriteLine($"Apartment: {priceApartament:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }

       
    }
    
}