using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu
{
    internal class Class1
    {
        public string colour = "red";
        public string name;
        public int age;
        public Class1(int a,string b) 
        {
             age=a;
            name = b;
        
        }
        public void p(int a,int b)
        {
            if(a== b)
            {
                Console.WriteLine(colour);
            }
            else
            {
                Console.WriteLine("flase");
            }
        }
    }
}
