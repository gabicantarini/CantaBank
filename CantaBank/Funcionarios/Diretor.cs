﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantaBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public string Senha { get; set; }
        public Diretor(string cpf) : base(5000, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            if(this.Senha == senha)
            {
                return true;
            }
        }

        public override void AumentarSalario()
        {
      
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
