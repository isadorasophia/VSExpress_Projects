using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_02
{
    class Polinomio
    {
        List<Termo> polinomioX = new List<Termo>();
        public List<Termo> PolinomioX
        {
            get { return polinomioX;  }
            set { polinomioX = value; }
        }

        public Polinomio (Termo p)
        {
            this.PolinomioX.Add(p);
        }

        public void insere (Termo p)
        {
            // Verifica se ja existe
            for (int i = 0; i < PolinomioX.Count; i++)
                if (PolinomioX[i].X == p.X)
                {
                    PolinomioX[i].insere(p);
                    return;
                }

            // Não existe, adiciona a lista
            this.PolinomioX.Add(p);
        }

        public double calcula (double parametro)
        {
            double soma = 0;

            foreach (Termo i in this.PolinomioX)
                soma += i.calcula(parametro);

            return soma;
        }
    }
}
