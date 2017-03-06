using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Haha

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
