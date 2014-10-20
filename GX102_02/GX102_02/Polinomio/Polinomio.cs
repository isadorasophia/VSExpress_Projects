using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_02
{
    class Polinomio
    {
        List<Termo> polinomioI = new List<Termo>();
        public List<Termo> PolinomioI
        {
            get { return polinomioI;  }
            set { polinomioI = value; }
        }

        public Polinomio (Termo p)
        {
            this.PolinomioI.Add(p);
        }

        public void insere (Termo p)
        {
            // Verifica se ja existe
            for (int i = 0; i < PolinomioI.Count; i++)
                if (PolinomioI[i].I == p.I)
                {
                    PolinomioI[i].insere(p);
                    return;
                }

            // Não existe, adiciona a lista
            this.PolinomioI.Add(p);
        }

        public double calcula (double parametro)
        {
            double soma = 0;

            foreach (Termo i in this.PolinomioI)
                soma += i.calcula(parametro);

            return soma;
        }
    }
}
