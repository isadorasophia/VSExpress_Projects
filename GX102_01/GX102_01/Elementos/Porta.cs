using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_01
{
    class Porta
    {
        public int dimensaoX, dimensaoY, dimensaoZ;

        bool aberta;
        string cor;

        public string Cor
        {
            get { return cor; }
        }

        public void abre() {
            this.aberta = true;
        }

        public void fecha() {
            this.aberta = false;
        }

        public void Pinta(String s) {
            this.cor = s;
        }

        public bool estaAberta() {
            return aberta;
        }
    }
}
