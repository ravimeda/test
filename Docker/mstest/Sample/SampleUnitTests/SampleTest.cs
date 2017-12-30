using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleLibrary;
using System;

namespace SampleTests
{
    [TestClass]
    public class SampleTest
    {
        string message = "";
        SampleClass sample = new SampleClass();

        [TestMethod]
        public void TestGetMessage1()
        {
            message = sample.GetMessage();
            Assert.IsTrue(string.Equals("Hello !", message));
        }

        [TestMethod]
        public void TestGetMessage2()
        {
            message = sample.GetMessage("Foo");
            Assert.IsTrue(string.Equals("Hello Foo!", message));
        }

        [TestMethod]
        public void TestGetMessage3()
        {
            message = sample.GetMessage("Foo Bar");
            Assert.IsTrue(string.Equals("Hello Foo Bar!", message));
        }

        [TestMethod]
        public void TestGetMessage4()
        {
            string now = DateTime.Now.ToString();
            message = sample.GetMessage(now);
            Assert.IsTrue(string.Equals($"Hello {now}!", message));
        }
    }
}
