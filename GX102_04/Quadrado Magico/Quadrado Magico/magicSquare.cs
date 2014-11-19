using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_Magico
{
    class MagicSquare
    {
        private readonly int[,] square;
        private readonly int size;

        // Constructor
        public MagicSquare (int[,] numbersInput, int size)
        {
            int i, j;
            this.square = new int[size, size];

            for (i = 0; i < size; i++)
                for (j = 0; j < size; j++)
                    this.square[i, j] = numbersInput[i, j];

            this.size = size;
        }

        // Returns the sum of the current column
        public int SumColumn(int column)
        {
            int sum = 0, i;

            for (i = 0; i < this.size; i++)
                sum += this.square[i, column];

            return sum;
        }

        // Returns the sum of the current line
        public int SumLine(int line)
        {
            int sum = 0, j;

            for (j = 0; j < this.size; j++)
                sum += this.square[line, j];

            return sum;
        }

        // Returns the sum of both diagonals, -1 if they are not the same
        public int SumDiagonals()
        {
            int i, leftDiagonal = 0, rightDiagonal = 0;

            for (i = 0; i < this.size; i++)
                leftDiagonal += this.square[i, i];

            for (i = this.size - 1; i >= 0; i--)
                rightDiagonal += this.square[i, i];

            if (leftDiagonal == rightDiagonal)
                return leftDiagonal;
            else
                return -1;
        }

        // If the square is magic, returns the sum - else, returns -1
        public int IsMagic()
        {
            int sum = 0, i;

            // Takes the value of the sum of both diagonals, -1 if they are not the same
            sum = this.SumDiagonals();

            // If they weren't the same
            if (sum == -1)
                return -1;

            // Checks if the sum of the columns diverge
            for (i = 0; i < size; i++)
                if (sum != this.SumColumn(i))
                    return -1;

            // Same for the lines
            for (i = 0; i < size; i++)
                if (sum != this.SumLine(i))
                    return -1;

            return sum;
        }
    }
}
