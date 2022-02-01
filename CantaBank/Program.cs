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
            CalcularBonificacao();
            Console.ReadLine(); 
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("111.222.333-24");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("555.222.333-24");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("777.222.333-24");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("666.222.333-24");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações do Mês: " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}