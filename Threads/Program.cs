using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        public static void ThreadMethod()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(ThreadMethod);
            Thread t = new Thread(ts);
            t.Start();
            for (int i = 0; i < 400; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
            }
            t.Join();
            Console.ReadKey();
        }
    }
}
