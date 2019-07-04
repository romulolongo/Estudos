using System;
using System.Collections.Generic;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {

            //problema de liskov

            var contas = new List<ContaComun>() {
                new ContaComun
                {

                },
                new ContaEstudante
                {
                }
            };

            // Classes filhas nunca podem afrouxar as pré condições

            //contas.ForEach(conta =>
            //{
            //    conta.PreCondicoesDeposito(150);
            //});


            // Classes filhas nunca podem apertar as pós condições

            contas.ForEach(conta =>
            {
                conta.PosCondicoesDeposito(90);
            });


            Console.WriteLine("Hello World!");
        }
    }
}
