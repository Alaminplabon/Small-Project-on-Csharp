using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj= new Class1(10,"plabon");
            Console.WriteLine(obj.colour);
            obj.p(5, 5);
            Console.WriteLine(obj.age+" "+obj.name);
            Class2 myObj = new Class2();
            myObj.Name =  " Liam ";
            Console.WriteLine(myObj.Name);
            Console.ReadLine();
        }
    }
}
