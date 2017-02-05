using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Lock
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
                    lock (_obj)
                    {
                        _count++;
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
                lock (_obj)
                { 
                    _count--;
                }
            }
        }
    }
}
