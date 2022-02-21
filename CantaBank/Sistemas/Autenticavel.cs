using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantaBank.Sistemas
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        bool Autenticavel(string senha);
            
        
    }
}
