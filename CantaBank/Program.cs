using CantaBank.Funcionarios;
using static CantaBank.GerenciadorBonificacao;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();  

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";
           

            carlos.AumentarSalario();
            Console.WriteLine("Novo Salário " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
           

            Console.WriteLine(roberta.CPF);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário " + roberta.Salario);

            Console.WriteLine("Bonificação Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação Diretor: " + robertaTeste.GetBonificacao());


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());


            Console.WriteLine("Totalde Bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine(); 
        }
    }
}