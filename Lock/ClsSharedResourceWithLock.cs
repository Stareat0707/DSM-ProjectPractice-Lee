using System;
using System.Threading;

namespace Lock
{
    class ClsSharedResourceWithLock
    {
        static Random r = new Random();
        static string message;
        static object conch = new object();

        public static void MethodA()
        {
            var boolLock = false;

            try
            {
                Monitor.TryEnter(conch, TimeSpan.FromSeconds(15), ref boolLock);
                Console.Write($"|{boolLock}|");

                for (int i = 0; i < 50; ++i)
                {
                    Thread.Sleep(r.Next(2000));
                    message += 'A';
                    Console.WriteLine(", ");
                }
            }
            finally
            {
                Console.WriteLine("|:|");
                Monitor.Exit(conch);
            }
        }
    }
}
