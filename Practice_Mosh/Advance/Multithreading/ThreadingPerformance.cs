using Practice_Mosh.Intermediate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Mosh.Advance.Multithreading
{
    internal class ThreadingPerformance
    {
        public static void Method1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Method 1 finished");
        }
        public static void Method2()
        {
            Thread.Sleep(2500);
            Console.WriteLine("Method 2 finished");
        }
        public static void Main(string[] args)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            Method1();
            Method2();
            sw.Stop();
            Console.WriteLine("Single threaded: " + sw.ElapsedMilliseconds);
            
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);

            sw.Restart();
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            sw.Stop();
            Console.WriteLine("Multi-threaded: " + sw.ElapsedMilliseconds);
        }
    }
}
