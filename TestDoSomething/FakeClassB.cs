using RemedDoSomething;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDoSomething
{
    internal class FakeClassB : IClassB
    {
        public string DoSomethingB()
        {
            return "Something from FakeClassB";
        }
    }
}
