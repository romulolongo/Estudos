using SPR.Interfaces;

namespace SPR.Classes
{
    public class Programador : Cargo
    {
        public Programador(ICalculoSalario calculo)
            :base(calculo)
        {
        }
    }
}
