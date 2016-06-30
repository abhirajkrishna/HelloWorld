using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_World;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //testing purpose
            Assert.AreEqual("Hello World", Hello_World.Hello_World.WriteMessage());




        }
    }
}
