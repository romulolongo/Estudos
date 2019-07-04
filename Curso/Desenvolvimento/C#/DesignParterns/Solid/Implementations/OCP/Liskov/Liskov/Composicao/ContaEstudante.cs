using System;

namespace Liskov.Composicao
{
    public class ContaEstudante : ContaComun
    {
        public  ManipuladorDeSaldo manipula { get; set; }

        public ContaEstudante()
        {
            manipula = new ManipuladorDeSaldo();

        }
    }
}
