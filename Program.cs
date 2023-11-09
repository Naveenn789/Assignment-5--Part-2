using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingbasicsPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First ten natural numbers");
            for (int i = 0; i < 11; i++) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Even number");
            int x = 0;
            while (x<=20)
            {
                if (x%2 == 0)
                {
                    Console.WriteLine(x);
                    
                }
                x++;
            }
            Console.WriteLine("Odd numbers");
            Console.WriteLine("-----------------------");
            int z = 0;
            do
            {
                if (z % 2 != 0)
                {
                    Console.WriteLine(z);
                }
                z++;
            } while (z <= 20);
            Console.ReadKey();

        }
    }
}
