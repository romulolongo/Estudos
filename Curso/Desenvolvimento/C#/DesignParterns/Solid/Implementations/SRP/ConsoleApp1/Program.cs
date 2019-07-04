using SPR.Classes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario(new Programador(new DezOuVintePorCento())) {
                Salario = 2000
            };

            Console.WriteLine("O salário de um funcionário que ganha 2 mil é" + funcionario.CalculaSalario());
            Console.ReadKey();
        }
    }
}
