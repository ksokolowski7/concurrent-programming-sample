using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ContinueWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine("Zrobiłem zadanie numer 1");
            });
            var task2 = task.ContinueWith(antecedent =>
            {
                Console.WriteLine("Zrobiłem zadanie numer 2");
            });
            var task3 = task.ContinueWith(antecedent =>
            {
                Console.WriteLine("Zrobiłem zadanie numer 3");
            });
            Task.WaitAll(task2, task3);
        }
    }
}
