using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Result
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() =>
            {
                Task.Delay(5000).Wait();
                return new Random().Next();
            });
        
            Console.WriteLine($"{task.Result}");
        }
    }
}
