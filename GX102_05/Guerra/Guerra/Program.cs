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
            int size, division;
            int[] territory;

            size = Int32.Parse(Console.ReadLine());

            // Allocates the necessary memory
            territory = new int[size];

            // Reads input - is there a way to retry after a catch without dirty solutions?
            try
            {
                territory = Console.ReadLine().Split(' ').Select(s => Int32.Parse(s)).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("That wasn't a very nice input...");

                // Exit
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            division = FindDivision(territory);

            if (division != 0)
                Console.WriteLine(division);

            // Exit
            Console.ReadKey();
        }

        // Why all the methods have to be static?
        static int FindDivision (int[] territory)
        {
            for (int i = 0; i < territory.Length - 1; i++)
            {
                if (VectorSum(territory, 0, i + 1) == VectorSum(territory, i + 1, territory.Length))
                    return i + 1;
            }

            return 0;
        }

        static int VectorSum (int[] vector, int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
                sum += vector[i];

            return sum;
        }
    }
}
