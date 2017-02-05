using System;
using System.Threading;
using System.Threading.Tasks;

namespace _22.Monitor
{
    class Program
    {
        const int MAX = int.MaxValue;
        static long _count = 0;
        static readonly object _obj = new object();

        static void Main(string[] args)
        {
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < MAX; i++)
                {
                    System.Threading.Monitor.Enter(_obj);
                    try
                    {
                        _count++;
                    }
                    finally
                    {
                        System.Threading.Monitor.Exit(_obj);
                    }
                }
            });
            Decrement();
            task.Wait();
            Console.WriteLine(_count);
        }

        static void Decrement()
        {
            for (int i = 0; i < MAX; i++)
            {
                System.Threading.Monitor.Enter(_obj);
                try
                {
                    _count--;
                }
                finally
                {
                    System.Threading.Monitor.Exit(_obj);
                }
            }
        }
    }
}
