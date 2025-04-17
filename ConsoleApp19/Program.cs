using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dClass = new DerivedClass();
            dClass.Method1();
            Console.Write("");
            dClass.Method2();
            Console.Write("");
            dClass.Method3();
            Console.Read();
        }
    }
}
