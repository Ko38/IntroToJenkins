using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestJenkins
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.Add(1, 2), 4);
        }
    }

    public class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
