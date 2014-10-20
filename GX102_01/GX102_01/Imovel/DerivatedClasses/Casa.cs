using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_01
{
    class Casa : Imovel
    {
        // Constructor
        public Casa (int numPortas) 
        {
            // Esse int i recebe as propriedades de scope da função?
            int i;

            for (i = 0; i < numPortas; i++)
                porta.Add(new Porta ());
        }

        public override int quantasPortasEstaoAbertas() {
            int quant = 0;

            foreach (Porta portaIndiv in this.porta)
                if (portaIndiv.estaAberta ())
                    quant++;

            return quant;
        }
    }
}
