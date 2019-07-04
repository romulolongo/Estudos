using SPR.Interfaces;

namespace SPR.Classes
{
    public class DezOuVintePorCento : ICalculoSalario
    {
        public decimal CalculoLiquido(Funcionario funcionario)
        {
            decimal salario = 0;
            if (funcionario.Salario <= 2000)
                salario = funcionario.Salario * 0.90m;

            if (funcionario.Salario > 3000)
                salario = funcionario.Salario * 0.80m;

            return salario;
        }
    }
}
