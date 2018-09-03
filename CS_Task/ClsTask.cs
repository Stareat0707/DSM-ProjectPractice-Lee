using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CS_Task
{
    class ClsTask
    {
        public ClsTask()
        {
            Console.WriteLine("Running methods asynchronously on multiple threads.");
            var timer = Stopwatch.StartNew();
            Task taskA = new Task(Procedural.MethodA);
            taskA.Start();

            Task taskB = Task.Factory.StartNew(Procedural.MethodB);

            Task taskC = Task.Run(new Action(Procedural.MethodC));

            Console.WriteLine(timer.ElapsedMilliseconds.ToString("#,#ms elapsed"));
        }
    }
}
