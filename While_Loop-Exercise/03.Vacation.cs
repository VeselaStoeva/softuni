using System;
namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            double neededMoney=double.Parse(Console.ReadLine());    
            double ownedMoney=double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;
            while (true)
            {
                string words = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (words=="spend")
                {
                    money-= ownedMoney;
                    spendingCounter++;
                    if (spendingCounter==5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{spendingCounter}");
                        break;
                    }
                }
                else if (words=="save")
                {
                    ownedMoney += money;
                    if (ownedMoney>=neededMoney)
                    {
                        Console.WriteLine($"You saved the money for {daysCounter} days.");
                        break;
                    }
                }        
               
            }
            //if (spendingCounter==5)
            //{
               
            //}
            //if (ownedMoney>=neededMoney)
            //{
             

        }
    }
}