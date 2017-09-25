using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void SayMyNameTest()
        {
            TestProject.IService1 ser = new Service1();
            var response = ser.SayMyName("Jiří");
            var result = response.Contains("Jiří");
            Assert.IsTrue(result);
        }
    }
}