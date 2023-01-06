using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string username=Console.ReadLine();
            string password=Console.ReadLine(); 
            while (true)
            {
                string word=Console.ReadLine();
                if (word==password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
            }
        }
    }
}

