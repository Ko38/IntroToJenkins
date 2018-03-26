using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNunit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
