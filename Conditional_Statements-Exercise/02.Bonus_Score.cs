using System;
namespace task21
{
    class Program
    {
        static void Main()
        {
            int num=int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num<=100)
            {
                bonus = 5;
            }
            else if (num>100 && num<=1000)
            {

                bonus = num*0.2;
            }
            else if (num>1000)
            {

                bonus = num*0.1;
            }
            bool numIsEven = num % 2 == 0;
            int ostatuk = num % 10;
            bool numEndFive = ostatuk == 5;
            if (numIsEven)
            {
                bonus++;
            }
            else if (numEndFive)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num+bonus);
            

            
        }
    }
}
