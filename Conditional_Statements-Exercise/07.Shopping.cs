using System;
namespace task27
{
    class Program
    {
        static void Main()
        {
            double moneyNaPetyr=double.Parse(Console.ReadLine());
            int videokarti=int.Parse(Console.ReadLine());
            int procesori=int.Parse(Console.ReadLine());
            int ramPamet=int.Parse(Console.ReadLine());
            int priceVideo = 250;
            double symvideokarti= videokarti * priceVideo;
            double priceProcesori = 0.35 * symvideokarti;
            double symProcesori = procesori * priceProcesori;
            double priceRamPamet = 0.1 * symvideokarti;
            double symRamPamet = ramPamet * priceRamPamet;
            double totalSym=symvideokarti+symProcesori+symRamPamet;
            double namalenie = totalSym * 0.15;
            if (videokarti>procesori)
            {
                totalSym -= namalenie;
                
            }
            if (moneyNaPetyr>totalSym)
            {
                double ostavat = moneyNaPetyr - totalSym;
                Console.WriteLine($"You have {ostavat:f2} leva left!");
            }
            else if (moneyNaPetyr<totalSym)
            {
               
                double nuvni = totalSym - moneyNaPetyr;
                Console.WriteLine($"Not enough money! You need {nuvni:f2} leva more!");
            }
          


        }
    }
}





