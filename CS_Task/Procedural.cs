using System;
using System.Diagnostics;
using System.Threading;

namespace CS_Task
{
    class Procedural
    {
        public Procedural()
        {
            Console.WriteLine("Running methods synchronously on one thread");
            Stopwatch stopwatch = Stopwatch.StartNew();
            MethodA();
            MethodB();
            MethodC();
            Console.WriteLine(stopwatch.ElapsedMilliseconds.ToString("#,#ms elapsed"));
        }

        public static void MethodA()
        {
            Console.WriteLine("MethodA 시작...");
            Thread.Sleep(3000);
            Console.WriteLine("MethodA 종료...");
        }

        public static void MethodB()
        {
            Console.WriteLine("MethodB 시작...");
            Thread.Sleep(2000);
            Console.WriteLine("MethodB 종료...");
        }

        public static void MethodC()
        {
            Console.WriteLine("MethodC 시작...");
            Thread.Sleep(1000);
            Console.WriteLine("MethodC 종료...");
        }
    }
}
