﻿using CantaBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CantaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Carlos = new Funcionario();

            Carlos.Nome = "Carlos";
            Carlos.CPF = "546.879.157-20";
            Carlos.Salario = 2000;

            Diretor Roberta = new Diretor();
            Roberta.Nome = "Roberta";
            Roberta.CPF = "454.658.148-3";
            Roberta.Salario = 5000;


            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());

            Console.WriteLine(Roberta.Nome);
            Console.WriteLine(Roberta.GetBonificacao());

            Console.ReadLine(); 
        }
    }
}