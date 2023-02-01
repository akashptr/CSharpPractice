using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Advance.Asynchronous
{
    internal class AsyncDemo
    {
        public async static void Delay()
        {
            Task task = new Task(() => { Thread.Sleep(1000); });
            Console.WriteLine("Starting Delay");
            task.Start();
            await task;
            Console.WriteLine("Stopped delay");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            Delay();
            Console.WriteLine("Main ends");
        }

    }
}
