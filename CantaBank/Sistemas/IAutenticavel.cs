using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantaBank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticavel(string senha);
        bool Autenticar(string senha);
    }
}
