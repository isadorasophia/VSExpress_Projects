using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_01
{
    class Edificio : Imovel
    {
        int totalDeAndares = 0;

        public int TotalDeAndares
        {
            get { return totalDeAndares; }
        }

        public void AdicionaAndar()
        {
            this.totalDeAndares++;
        }

        public override int quantasPortasEstaoAbertas()
        {
            int quant = 0;

            foreach (Porta portaIndiv in this.porta)
                if (portaIndiv.estaAberta())
                    quant++;

            return quant;
        }

        public void AdicionaPorta (Porta p)
        {
            this.porta.Add(p);
        }
    }
}
