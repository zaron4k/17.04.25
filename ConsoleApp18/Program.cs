using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"Вызов метода, возвращающий число Pi: {myClass.MyGetPi()}");
            Console.WriteLine($"Вызов метода, возращающий число типа int: {myClass.MyGetInt()}");
            Console.WriteLine($"Вызов метода, возвращающий x в квадрате: {myClass.MySquare(3)}");
            Console.WriteLine($"Вызов метода, возвращающий корень квадратный из x: {myClass.MySqrt(6.25)}");
            Console.Read();
        }
    }
}
