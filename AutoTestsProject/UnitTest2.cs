using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutoTestsProject
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void NUnitSampleTest1()
        {
            Assert.Pass("This is sample nunit test");
        }
    }
}
