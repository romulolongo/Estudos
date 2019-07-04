using SPR.Interfaces;

namespace SPR.Classes
{
    public class Tester : Cargo
    {
        public Tester(ICalculoSalario calculo)
            : base(calculo)
        {

        }
    }
}
