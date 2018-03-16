using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPractise
{
    public class A
    {
        public int a;
    }

    public class B
    {
        public int b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestShalloandDeepCopy();        

            Console.ReadLine();
        }

        public  static void TestShalloandDeepCopy()
        {
            A _a = new A();

            _a.a = 10;

            A _aa = new A();

            _aa = _a; //shallow copy
            _aa.a = _a.a; // deep copy

            Console.WriteLine("Value of a in _a \t" + _a.a);
            Console.WriteLine("Value of a in _aa \t" + _aa.a);

            _a.a = 20;

            Console.WriteLine("Value of a in _a \t" + _a.a);
            Console.WriteLine("Value of a in _aa \t" + _aa.a);
        }
    }
}
