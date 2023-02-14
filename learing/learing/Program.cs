using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Antor", "Shoron" };
            names.Add("pl");
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }
        }
    }
    }
    
}
