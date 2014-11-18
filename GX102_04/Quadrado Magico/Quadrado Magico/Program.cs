using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_Magico
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, size, i, j;
            int[,] magicSquare;

            MagicSquare amIPerf;

            bool isMagic = true;

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

            // Takes the value of the sum of both diagonals, -1 if they are not the same
            sum = amIPerf.SumDiagonals();

            // If they weren't the same
            if (sum <= 0) 
                isMagic = false;

            // Checks if the sum of the columns diverge
            for (i = 0; i < size && isMagic; i++)
                if (sum != amIPerf.SumColumn(i))
                    isMagic = false;

            // Same for the lines
            for (j = 0; j < size && isMagic; j++)
                if (sum != amIPerf.SumLine(j))
                    isMagic = false;

            // Yay! Success!
            if (isMagic)
                Console.WriteLine(sum);
            // Nope
            else
                Console.WriteLine("-1");

            // Exit
            Console.ReadKey();
        }
    }
}
