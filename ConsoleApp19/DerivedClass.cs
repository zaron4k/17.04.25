using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class DerivedClass:IInterface3
    {
        public void Method1()
        {
            Console.WriteLine("Метод 1, реализованный в классе DerivedClass");
        }
        public void Method2()
        {
            Console.WriteLine("Метод 2, реализованный в классе DerivedClass");
        }
        public void Method3()
        {
            Console.WriteLine("Метод 3, реализованный в классе DerivedClass");
        }
    }
}
