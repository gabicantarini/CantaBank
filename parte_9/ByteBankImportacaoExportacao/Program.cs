﻿using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output

namespace ByteBankImportacaoExportacao
{
    partial class Program  //partial q dizer que temos uma classe com métodos separados em vários arquivos
    {
        static void Main(string[] args)
        {
            UsarStreamDeEntrada();
            Console.WriteLine("Aplicação finalizada...");
            

            Console.ReadLine();
        }
               


    }
}
