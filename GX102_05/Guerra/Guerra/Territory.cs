using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerra
{
    class Territory
    {
        private readonly int[] territory;
        public int Division { get; private set; }

        public Territory (int[] territoryNumbers)
        {
            this.territory = new int[territoryNumbers.Length];

            this.territory = territoryNumbers;

            // Assign the division
            this.Division = FindDivision(this.territory);
        }

        // Finds the division in the territory
        int FindDivision(int[] territory)
        {
            for (int i = 0; i < territory.Length - 1; i++)
            {
                if (VectorSum(territory, 0, i + 1) == VectorSum(territory, i + 1, territory.Length))
                    return i + 1;
            }

            return 0;
        }

        // Returns the sum of a vector that stars at "start" and ends at "end"
        int VectorSum(int[] vector, int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
                sum += vector[i];

            return sum;
        }
    }
}
