using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] territoryNumbers;
            Territory territory;

            size = Int32.Parse(Console.ReadLine());

            // Allocates the necessary memory
            territoryNumbers = new int[size];

            // Reads input - is there a way to retry after a catch without dirty solutions?
            try
            {
                territoryNumbers = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("That wasn't a very nice input...");

                // Exit
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            // Creathes the object - that was the cleanest way I found
            territory = new Territory(territoryNumbers);

            Console.WriteLine(territory.Division);

            // Exit
            Console.ReadKey();
        }

        // Why all the methods have to be static in the procedural way?
    }
}
