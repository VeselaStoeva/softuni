using System;
namespace task42
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currence = 0;

            for(int i=0; i<name.Length; i++)
            {
                if (name[i]=='a')
                {
                    currence += 1;
                }
                else if (name[i]=='e')
                {
                    currence += 2;
                }
                else if (name[i]=='i')
                {
                    currence += 3;
                }
                else if (name[i]=='o')
                {
                    currence += 4;
                }
                else if (name[i]=='u')
                {
                    currence += 5;
                }
                
            }
            Console.WriteLine(currence);
        }
       
        
    }
}