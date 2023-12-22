using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemedDoSomething;
using System;

namespace TestDoSomething
{
    [TestClass]
    public class TestClassA
    {
        [TestMethod]
        public void TestDoSomethingA()
        {
            FakeClassB fake = new FakeClassB();
            ClassA target = new ClassA(fake);
            string result = target.DoSomethingA();
            Assert.AreEqual("Something from FakeClassB", result);
        }
    }
}
