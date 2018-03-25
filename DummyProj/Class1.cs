using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyProj
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void UnitTest()
        {
            Assert.That(1, Is.EqualTo(2));
        }
    }
}
