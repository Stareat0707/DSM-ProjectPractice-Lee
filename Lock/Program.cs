using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ClsShareResource
{
    class Program
    {
        public static Random r = new Random();

        public static string Message = "";

        private static Object conch = new Object();

        static void Main(string[] args)
        {
            Stopwatch timer = Stopwatch.StartNew();
            List<Task> tasks = new List<Task>();

            tasks.Add(Task.Run(() => { MethodA(); }));
            tasks.Add(Task.Run(() => { MethodB(); }));

            Task.WaitAll(tasks.ToArray());
            WriteLine(timer.ElapsedMilliseconds);
            WriteLine(Message);
        }

        static void MethodA()
        {
            bool boolLock = false;
            try
            {
                Monitor.TryEnter(conch, TimeSpan.FromSeconds(15), ref boolLock);

                if (boolLock)
                {
                    for (int i = 0; i < 50; ++i)
                    {
                        Thread.Sleep(r.Next(2000));
                        Message += "A";
                        Write(".");
                    }
                }
                else
                {
                    WriteLine("Method A 대기중");
                }
            }
            finally
            {
                if (boolLock)
                    Monitor.Exit(conch);
            }
        }

        static void MethodB()
        {
            bool boolLock = false;
            try
            {
                Monitor.TryEnter(conch, TimeSpan.FromSeconds(15), ref boolLock);

                if (boolLock)
                {
                    for (int i = 0; i < 50; ++i)
                    {
                        Thread.Sleep(r.Next(2000));
                        Message += "B";
                        Write("_");
                    }
                }
                else
                {
                    WriteLine("Method B 대기중");
                }
            }
            finally
            {
                if (boolLock)
                    Monitor.Exit(conch);
            }
        }
    }
}