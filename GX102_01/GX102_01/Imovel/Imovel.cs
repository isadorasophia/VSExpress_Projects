using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_01
{
    abstract class Imovel
    {
        // Melhor maneira de organizar imovel em relação as pastas?
        // Funcionalidade, visual, depende do que você quer... namespace is good! ex: using GX102_01.Imovel
        public List<Porta> porta = new List<Porta>();

        protected string cor;

        public string Cor
        {
            get { return cor; }
        }

        public int totalDePortas()
        {
            return this.porta.Count;
        }

        public void pinta(String s)
        {
            this.cor = s;
        }

        public abstract int quantasPortasEstaoAbertas();
    }
}
