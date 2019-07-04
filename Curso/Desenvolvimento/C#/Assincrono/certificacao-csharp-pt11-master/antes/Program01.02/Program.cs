using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Program01._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //MUITAS TAREFAS EM PARALELO, COM PARÂMETRO
            //=========================================
            //Tarefa 1: processar 100 itens em série
            //Tarefa 2: processar 100 itens em paralelo - percorrendo uma faixa
            //Tarefa 3: processar 100 itens em paralelo - percorrendo uma coleção

            Stopwatch time = new Stopwatch();

            time.Start();
            Console.WriteLine("Tarefa 1: processar 100 itens em série");

            for (int i = 0; i < 100; i++)
            {
                Processar(i);
            }
            time.Stop();
            Console.WriteLine("time decorrido {0} segundos", time.ElapsedMilliseconds / 1000);

            Console.ReadLine();
            Console.WriteLine();


            time.Reset();
            time.Restart();
            Console.WriteLine("Tarefa 2: processar 100 itens em paralelo - percorrendo uma faixa");

            Parallel.For(0, 100, (i) => Processar(i));

            time.Stop();

            Console.WriteLine("time decorrido {0} segundos", time.ElapsedMilliseconds / 1000);

            Console.WriteLine();
            Console.ReadLine();


            Console.WriteLine("Tarefa 3: processar 100 itens em paralelo - percorrendo uma coleção");

            var itens = Enumerable.Range(0, 100);

            Parallel.ForEach(itens, (item) => Processar(item));

            Parallel.For(0, 100, (i) => Processar(i));
            Console.WriteLine();
            Console.ReadLine();
            time.Stop();

            Console.WriteLine("time decorrido {0} segundos", time.ElapsedMilliseconds / 1000);


            Console.WriteLine("Término do processamento. Tecle [ENTER] para terminar.");
            Console.ReadLine();
        }

        static void Processar(object item)
        {
            Console.WriteLine("Começando a trabalhar com: " + item);
            Thread.Sleep(100);
            Console.WriteLine("Terminando a trabalhar com: " + item);
        }
    }
}
