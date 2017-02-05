using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Synchronization
{
    class Program
    {
        const int MAX = int.MaxValue;
        static long _count = 0;

        static void Main(string[] args)
        {
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < MAX; i++)
                {
                    _count++;
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
                _count--;
            }
        }
    }
}
