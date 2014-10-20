using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_02
{
    // Programa computa valores de polinomios
    class Program
    {
        static void Main(string[] args)
        {
            // Testa a funcionalidade das classes:
            Polinomio pol1 = new Polinomio(new Termo (2, 1));

            pol1.insere(new Termo(4, 3));

            Console.WriteLine(pol1.calcula(4));

            // Para finalizar a aplicação
            Console.ReadKey();
        }
    }
}
