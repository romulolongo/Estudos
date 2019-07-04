using System;

namespace Liskov.Heranca
{
    public class ContaEstudante : ContaComun
    {
        public ContaEstudante()
        {

        }


        public override void PreCondicoesDeposito(decimal valor)
        {
            if (Saldo <= 200)
                Saldo += valor;
            else
                throw new Exception("DEPOSITO NÃO PODE SER MAIOR QUE 200 REAIS");
        }


        public override decimal PosCondicoesDeposito(decimal valor)
        {
            Saldo += valor;

            if (Saldo > 50)
                throw new Exception("SALDO NÃO PODE SER MAIOR QUE 100 REAIS");

            return Saldo;
        }
    }
}
