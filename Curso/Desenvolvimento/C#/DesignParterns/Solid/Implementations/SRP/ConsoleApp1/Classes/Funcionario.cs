using System;
using System.Collections.Generic;
using System.Text;

namespace SPR.Classes
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public Cargo Cargo { get; set; }

        public decimal Salario { get; set; }

        public Funcionario(Cargo cargo)
        {
            Cargo = cargo;
        }

        public decimal CalculaSalario()
        {
            return this.Cargo.CalculoSalario.CalculoLiquido(this);
        }
    }
}
