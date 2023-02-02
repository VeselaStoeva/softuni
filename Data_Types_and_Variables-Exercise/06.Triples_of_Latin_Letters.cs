using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
            for (int i = 97; i <n+97 ; i++)
            {
                for (int j =97; j <n+97; j++)
                {
                    for (int k = 97; k <n+97 ; k++)
                    {
                      

                        Console.WriteLine($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)}");
                    }
                }
            }

        }
    }
}