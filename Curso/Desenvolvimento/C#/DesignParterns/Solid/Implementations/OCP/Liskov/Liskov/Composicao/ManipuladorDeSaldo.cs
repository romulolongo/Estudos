using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov.Composicao
{
    public class ManipuladorDeSaldo
    {
        public decimal Saldo { get; set; }

        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
    }
}
