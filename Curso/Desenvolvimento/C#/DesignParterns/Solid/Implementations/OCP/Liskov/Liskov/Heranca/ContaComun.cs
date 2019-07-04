using System;

namespace Liskov.Heranca
{
    public class ContaComun
    {
        public decimal Saldo { get; protected set; }

        public ContaComun()
        {

        }

        public virtual void PreCondicoesDeposito(decimal valor)
        {
            if (valor <= 100)
                Saldo += valor;
            else
                throw new Exception("SALDO NÃO PODE SER MAIOR QUE 100 REAIS");
        }

        public virtual decimal PosCondicoesDeposito(decimal valor)
        {
            Saldo += valor;

            if (Saldo > 100)
                throw new Exception("SALDO NÃO PODE SER MAIOR QUE 100 REAIS");

            return Saldo;
        }
    }
}
