using System;
namespace Task78
{
    class Program
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            
            int hora = 0;
            int hori = 0;
            int hona = 0;
            int honda = 0;
            int hinda = 0;
            for (int i = 1; i <= n; i++)
            {
                int number=int.Parse((Console.ReadLine()));
                

                if (number<=5)
                {
                    hora += number;

                }
                else if (number>=6 && number<=12)
                {
                    hori += number;
                }
                else if (number>=13 && number<=25)
                {
                    hona += number;
                }
                else if (number>=26 && number<=40)
                {
                    honda += number;
                }
                else if (number>=41)
                {
                    hinda += number;
                }
            }
            double total = hora + hori + hona + honda + hinda;
            double musala = hora / total * 100;
            double monndblan = hori/ total * 100;
            double kilimandvaro = hona/ total * 100;
            double k2 = honda / total * 100;
            double everest = hinda /total * 100;
            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monndblan:f2}%");
            Console.WriteLine($"{kilimandvaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");
        }
    }
}
    