using SPR.Interfaces;

namespace SPR.Classes
{
    public abstract class Cargo
    {
        public ICalculoSalario CalculoSalario { get; private set; }

        public Cargo(ICalculoSalario calculoSalario)
        {
            CalculoSalario = calculoSalario;
        }
    }
}
