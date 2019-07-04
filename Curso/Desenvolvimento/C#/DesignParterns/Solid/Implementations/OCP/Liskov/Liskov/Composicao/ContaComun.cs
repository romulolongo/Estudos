using System;

namespace Liskov.Composicao
{
    public class ContaComun
    {
        public ManipuladorDeSaldo manipulador;

        public ContaComun()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }
    }
}
