using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.brand);
            car.honk();
            Console.WriteLine(car.name);
            Console.ReadLine();
        }
    }
}
