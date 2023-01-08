using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            string book=Console.ReadLine();
            int broj = 0;
            while (true)
            {
                string name=Console.ReadLine();
             
                if (name=="No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {broj} books.");
                    break;
                }
                if (name==book)
                {
                    Console.WriteLine($"You checked {broj} books and found it.");
                    break;
                }
                broj++;

            }
        }
    }
}
