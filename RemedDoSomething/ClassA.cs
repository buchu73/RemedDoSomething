using System;

namespace RemedDoSomething
{
    public class ClassA
    {
        private IClassB _classB;

        public ClassA()
        {
            _classB = new ClassB();
        }

        public ClassA(IClassB fake)
        {
            _classB = fake;
        }

        public string DoSomethingA()
        {
            return _classB.DoSomethingB();
        }
    }
}