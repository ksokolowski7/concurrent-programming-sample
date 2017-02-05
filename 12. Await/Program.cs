using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Await
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTask = MyTask();
            Console.WriteLine("Działamy dalej");
            myTask.Wait();
        }

        static async Task MyTask()
        {
            await Task.Delay(2000);
            Console.WriteLine("Pracujemy");
        }
    }
}
