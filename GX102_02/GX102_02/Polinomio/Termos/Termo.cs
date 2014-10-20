using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_02
{
    class Termo
    {
        int a, x;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value;}
        }

        // Constructor
        public Termo (int ai, int xi)
        {
            this.A = ai;
            this.X = xi;
        }

        public void insere (Termo p)
        {
            this.A = p.A;
            this.X = p.X;
        }

        public double calcula (double parametro)
        {
            return this.A * Math.Pow(parametro, this.X);
        }
    }
}
