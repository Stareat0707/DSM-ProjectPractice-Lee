using System;
using System.Threading;

namespace CS_Task
{
    class ClsThread
    {
        public ClsThread()
        {
            Console.WriteLine("Running methods synchronously on one thread.");

            Thread thread = new Thread(DoSomethingNoPrint);
            thread.Start();
            DoReadLine();
            DoTerminate();
            thread.Abort();
        }

        public static void DoSomethingNoPrint()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(i + " ");
                Thread.Sleep(300);
            }
        }

        void DoReadLine()
        {
            do
            {
                Console.WriteLine("프로그램을 끝내려면 \"No\"를 입력하시오. ==>>");
            } while (Console.ReadLine() != "No");

            Console.WriteLine("End of DoReadLine()");
        }

        void DoTerminate()
        {
            Console.WriteLine("Press Enger to continue ...");
            Console.ReadLine();
        }
    }
}
