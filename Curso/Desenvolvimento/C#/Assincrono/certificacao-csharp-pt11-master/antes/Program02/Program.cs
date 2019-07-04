using System;
using System.Threading;

namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Thread Principal";
            ExibirThread(Thread.CurrentThread);
            //1. Task X Thread
            Thread thread1 = new Thread(Executar);
            thread1.Name = "Task X Thread";

            thread1.Start();

            thread1.Join();
            //2. Thread com expressão lambda

            Thread thread2 = new Thread(() => Executar());
            thread2.Name = "Thread com expressão lambda";

            thread2.Start();
            //3. Passando parâmetro para thread
            thread2.Join();

            ParameterizedThreadStart ps = new ParameterizedThreadStart((p) => ExecutarParams(p));

            Thread thread3 = new Thread(ps);
            thread3.Name = "Passando parâmetro para thread";

            thread3.Start(123);
            thread3.Join();

            //4. Interrompendo um relógio

            var relogioFuncionando = true;

            Thread thread4 = new Thread(() =>
            {
                ExibirThread(Thread.CurrentThread);
                while (relogioFuncionando)
                {
                    Console.WriteLine("tic");
                    Thread.Sleep(1000);
                    Console.WriteLine("Tac");
                    Thread.Sleep(1000);
                }
            });
            thread4.Name = "Interrompendo um relógio";

            thread4.Start();
            Console.WriteLine("tecle algo para interromper");
            Console.ReadKey();
            relogioFuncionando = false;

            thread3.Join();


            //5. Sincronizando uma thread

            //6. Dados da Thread: Nome, cultura, prioridade, contexto, background, pool

            //7. Usando Thread Pool

            for (int i = 0; i < 50; i++)
            {
                //emfileiramento
                var estadoItem = i;
                ThreadPool.QueueUserWorkItem((estado) 
                    => ExecutarParams(estadoItem));
            }
        }

        static void Executar()
        {
            ExibirThread(Thread.CurrentThread);

            Console.WriteLine("Iniciando thread");
            Thread.Sleep(1000);
            Console.WriteLine("Finalizando Thread");
        }

        static void ExecutarParams(object param)
        {
            ExibirThread(Thread.CurrentThread);

            Console.WriteLine("Iniciando thread: {0}", param);
            Thread.Sleep(1000);
            Console.WriteLine("Finalizando Thread: {0}", param);
        }

        static void ExibirThread(Thread t)
        {
            Console.WriteLine();
            Console.WriteLine("Nome: {0}", t.Name);
            Console.WriteLine("Cultura: {0}", t.CurrentCulture);
            Console.WriteLine("Prioridade: {0}", t.Priority);
            Console.WriteLine("Contexto: {0}", t.ExecutionContext);
            Console.WriteLine("Está me background?: {0}", t.IsBackground);
            Console.WriteLine("Está no pool de threads?: {0}", t.IsThreadPoolThread);
            Console.WriteLine();
        }
    }
}
