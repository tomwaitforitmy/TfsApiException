using System;
using BuildClientExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FailingTest()
        {
            BuildHttpClient.BuildClient();
        }
    }
}
