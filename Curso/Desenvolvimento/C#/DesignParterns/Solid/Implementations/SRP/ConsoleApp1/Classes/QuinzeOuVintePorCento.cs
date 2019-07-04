using SPR.Interfaces;

namespace SPR.Classes
{
    public class QuinzeOuVintePorCento : ICalculoSalario
    {
        public decimal CalculoLiquido(Funcionario funcionario)
        {
            decimal salario = 0;
            if (funcionario.Salario > 2000)
                salario = funcionario.Salario * 0.85m;

            if (funcionario.Salario > 3000)
                salario = funcionario.Salario * 0.75m;

            return salario;
        }
    }
}
