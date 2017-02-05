using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000000;
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < max; i++)
                {
                    Console.Write($"1");
                }
            });
        }
    }
}
