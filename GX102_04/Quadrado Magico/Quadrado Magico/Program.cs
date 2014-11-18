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
            int size, i, j, sum;
            int[,] magicSquare;

            bool isMagic = true;

            string line;
            string[] lineNumbers;

            size = Int32.Parse(Console.ReadLine());

            lineNumbers = new string[size];
            magicSquare = new int[size, size];

            for (i = 0; i < size; i++)
            {
                line = Console.ReadLine();
                lineNumbers = line.Split(' ');

                for (j = 0; j < size; j++)
                    magicSquare[i, j] = Int32.Parse(lineNumbers[j]);
            }

            sum = SumDiagonals(magicSquare, size);

            if (sum <= 0) 
                isMagic = false;

            for (i = 0; i < size; i++)
                if (sum != SumColumn(magicSquare, i, size))
                    isMagic = false;

            for (j = 0; j < size && isMagic; j++)
                if (sum != SumLine(magicSquare, size, j))
                    isMagic = false;

            if (isMagic)
                Console.WriteLine(sum);
            else
                Console.WriteLine("-1");

            // Exit
            Console.ReadKey();
        }

        // Since it keeps asking for an object reference, the method is static...
        static int SumColumn(int[,] magicSquare, int column, int size)
        {
            int sum = 0, i;

            for (i = 0; i < size; i++)
                sum += magicSquare[i, column];

            return sum;
        }

        static int SumLine(int[,] magicSquare, int size, int line)
        {
            int sum = 0, j;

            for (j = 0; j < size; j++)
                sum += magicSquare[line, j];

            return sum;
        }

        static int SumDiagonals(int[,] magicSquare, int size)
        {
            int i, leftDiagonal = 0, rightDiagonal = 0;

            for (i = 0; i < size; i++)
                leftDiagonal += magicSquare[i, i];

            for (i = size - 1; i >= 0; i--)
                rightDiagonal += magicSquare[i, i];

            if (leftDiagonal == rightDiagonal)
                return leftDiagonal;
            else
                return -1;
        }
    }
}
