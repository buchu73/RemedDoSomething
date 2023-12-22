using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemedDoSomething
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA classA = new ClassA();
            string result = classA.DoSomethingA();
            Console.WriteLine(result);
        }
    }
}
