using System;
using System.Threading.Tasks;

namespace CS_Task
{
    class ClsUsingTask
    {
        public ClsUsingTask()
        {
            Task.Run(() => ClsThread.DoSomethingNoPrint());
            Console.WriteLine("NoWait(): End of Do SomethingNoPrint()");

            Task.Run(() => SumPartical(3, 300)).ContinueWith(task => { Sum(task.Result); });
        }

        public ClsUsingTask(bool Wait)
        {
            Task.Run(() => ClsThread.DoSomethingNoPrint()).Wait();
            Console.WriteLine("Wait(): End of Do SomethingNoPrint()");

            Task.Run(() => SumPartical(3, 300)).ContinueWith(task => { Sum(task.Result); }).Wait();
        }

        decimal SumPartical(decimal a, decimal b)
        {
            decimal result = 0;
            for (decimal d = a; d < b; d += 0.1M)
                result += d;

            return result;
        }

        void Sum(decimal result1)
        {
            decimal result2 = SumPartical(300, 1000);
            Console.WriteLine($"{result1:#,#.#} + {result2:#,#.#} = {result1 + result2:#,#.#}");
        }
    }
}
