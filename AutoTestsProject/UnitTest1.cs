using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoTestsProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("Oops, something failed :(");
        }
    }
}
