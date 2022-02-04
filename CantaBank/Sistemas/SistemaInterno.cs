using CantaBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantaBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Funcionario funcionario, string senha)
        {
            bool usuarioAutenticado = funcionarioAutenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else 
            { 
                Console.WriteLine("Senha incorreta!"); 
                return false;
            }
        }
    }
}
