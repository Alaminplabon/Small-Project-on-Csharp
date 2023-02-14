using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumber = new List<int> { 1, 1 };
            while(fibonacciNumber.Count < 20)
            {
                var previous = fibonacciNumber[fibonacciNumber.Count - 1];
                var previous1 = fibonacciNumber[fibonacciNumber.Count - 2];
                fibonacciNumber.Add(previous + previous1);
            }
            
            foreach (var item in fibonacciNumber)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
