using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_Magico
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum, size, i, j;
            int[,] magicSquare;

            MagicSquare amIPerf;

            string line;
            string[] lineNumbers;

            size = Int32.Parse(Console.ReadLine());

            // Allocates the necessary memory
            lineNumbers = new string[size];
            magicSquare = new int[size, size];

            // Reads input
            for (i = 0; i < size; i++)
            {
                line = Console.ReadLine();
                lineNumbers = line.Split(' ');

                for (j = 0; j < size; j++)
                    magicSquare[i, j] = Int32.Parse(lineNumbers[j]);
            }

            // Creates the square instance
            amIPerf = new MagicSquare(magicSquare, size);

            // If the square is magic, returns the sum - else, returns -1
            sum = amIPerf.IsMagic();

            Console.WriteLine(sum);

            // Exit
            Console.ReadKey();
        }
    }
}
