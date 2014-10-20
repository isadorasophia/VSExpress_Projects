﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GX102_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Edificio edificio = new Edificio();

            edificio.pinta("amarelo");

            Console.WriteLine("A cor do edificio é " + edificio.Cor + ".\n");

            for (int i = 0; i < 6; i++)
            {
                edificio.AdicionaPorta(new Porta());
            }

            edificio.porta[1].abre();
            edificio.porta[3].abre();
            edificio.porta[5].abre();

            Console.WriteLine(edificio.quantasPortasEstaoAbertas());

            edificio.porta[1].fecha();

            Console.WriteLine(edificio.quantasPortasEstaoAbertas());

            Console.WriteLine(edificio.totalDePortas ());

            edificio.AdicionaAndar();

            Console.WriteLine("A casa tem " + edificio.TotalDeAndares + " andar(es).\n");

            // Para finalizar a aplicação
            Console.ReadKey();
        }
    }
}