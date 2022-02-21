using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantaBank.Sistemas
{
    public interface Autenticavel
    {
        public string Senha { get; set; }

        public bool Autenticavel(string senha)
            
        {
            return Senha == senha;
        }

    }
}
