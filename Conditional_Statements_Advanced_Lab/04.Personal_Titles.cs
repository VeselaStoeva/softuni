using System;
namespace task29
{
    class Program
    {
        static void Main()
        {

            
            double age=double.Parse(Console.ReadLine());
            string pol=Console.ReadLine();
            if (pol=="m" && age>=16)
            {
                Console.WriteLine("Mr.");
            }
            else if (pol=="m" && age<16)
            {
                Console.WriteLine("Master");
            }
            if (pol=="f" && age>=16)
            {
                Console.WriteLine("Ms.");
            }
            else if (pol=="f" && age<16)
            {
                Console.WriteLine("Miss");
            }
            
        }
    }
}
