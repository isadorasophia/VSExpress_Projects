using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_02
{
    class Termo
    {
        int a, i;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int I
        {
            get { return i; }
            set { i = value;}
        }

        // Constructor
        public Termo (int ai, int ii)
        {
            this.A = ai;
            this.I = ii;
        }

        public void insere (Termo p)
        {
            this.A = p.A;
            this.I = p.I;
        }

        public double calcula (double parametro)
        {
            return this.A * Math.Pow(parametro, this.I);
        }
    }
}
