﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Program01
{
    //Task Parallel com Parallel.For / PLINQ / Tasks
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA 1: Cozinhar e refogar EM SÉRIE
            //TAREFA 2: Cozinhar e refogar EM PARALELO
            //TAREFA 3: Medir o tempo dos 2 procedimentos
            Stopwatch time = new Stopwatch();

            time.Start();
            CozinharMacarrao();
            RefogarMolho();

            time.Stop();

            Console.WriteLine(
                "Retire do fogo e ponha o molho sobre o macarrão. " +
                "Bom apetite! " +
                "Tecle [ENTER] para terminar.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("tempo demorado: " + (time.ElapsedMilliseconds / 1000.0));

            Console.ReadLine();

            time.Reset();
            time.Restart();
            Parallel.Invoke(() => CozinharMacarrao(), () => RefogarMolho());

            time.Stop();

            Console.WriteLine(
                "Retire do fogo e ponha o molho sobre o macarrão. " +
                "Bom apetite! " +
                "Tecle [ENTER] para terminar.");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("tempo demorado: " + (time.ElapsedMilliseconds / 1000.0));

            Console.ReadLine();

        }

        static void CozinharMacarrao()
        {
            Console.WriteLine("Cozinhando macarrão...");

            Thread.Sleep(1000);

            Console.WriteLine("Macarrão já está cozido!");
            Console.WriteLine();
        }

        static void RefogarMolho()
        {
            Console.WriteLine("Refogando molho...");
            Thread.Sleep(2000);

            Console.WriteLine("Molho já está refogado!");
            Console.WriteLine();
        }
    }
}
