using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            double input=double.Parse(Console.ReadLine())*100;
            int resto =(int) input;
            int broy = 0;
            while (resto>0.00)
            {
                if (resto>=200)
                {
                    resto -= 200;
                }
                else if (resto>=100)
                {
                    resto -= 100;
                }
                else if (resto>=50)
                {
                    resto -= 50;
                }
                else if (resto>=20)
                {
                    resto -= 20;
                }
                else if (resto>=10)
                {
                    resto -= 10;
                }
                else if (resto>=5)
                {
                    resto -= 5;
                }
                else if (resto>=2)
                {
                    resto -= 2;
                }
                else if (resto>=1)
                {
                    resto -= 1;
                }
                broy++; 
            }
            Console.WriteLine(broy);

        }
    }
}

