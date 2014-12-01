using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times.Time
{
    public class Player
    {
        public string Name { get; private set; }
        public int Hability { get; private set; }

        public Player (string nameInput, int habilityInput)
        {
            this.Name = nameInput;
            this.Hability = habilityInput;
        }
    }
}
