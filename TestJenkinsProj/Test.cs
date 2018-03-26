using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJenkinsProj
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestAdd()
        {
            Assert.That(Math.Add(1, 2), Is.EqualTo(3));
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
