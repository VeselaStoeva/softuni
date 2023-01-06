using System;
namespace task45
{
    class Program
    {
        static void Main()
        {
           int n =int.Parse(Console.ReadLine());
            int between199 = 0;
            int between200And399 = 0;
            int between400And599 = 0;
            int between600And799 = 0;
            int between800 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num>=1 && num<=199)
                {
                    between199++;
                }
                else if (num>=200 && num<=399)
                {
                    between200And399++;
                }
                else if (num>=400 && num<=599)
                {
                   
                    between400And599++;
                }
                else if (num>=600 && num<=799)
                {
                    between600And799++;
                }
                else if (num>=800)
                {
                    between800++;
                }

            }
            double percentBetween199 =between199 / (double)n * 100;
            double percentBetween399 = between200And399 / (double)n * 100;
            double percentBetween599 = between400And599 / (double)n * 100;
            double percentBetween799 = between600And799 / (double)n * 100;
            double percentBetween800 = between800 / (double)n * 100;
            Console.WriteLine($"{percentBetween199:f2}%") ;
            Console.WriteLine($"{percentBetween399:f2}%");
            Console.WriteLine($"{percentBetween599:f2}%");
            Console.WriteLine($"{percentBetween799:f2}%");
            Console.WriteLine($"{percentBetween800:f2}%");
        }
    }
}