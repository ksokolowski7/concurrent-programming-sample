using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AggregateException
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() => { throw new InvalidOperationException("fatal error"); });

            try
            {
                task.Wait();
            }
            catch (System.AggregateException e)
            {
                e.Handle(x =>
                {
                    Console.WriteLine(x.Message);
                    return true;
                });
            }
        }
    }
}
