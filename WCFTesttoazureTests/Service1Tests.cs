using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFTesttoazure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFTesttoazure.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetDataTest()
        {
           // Assert.Fail();
        }

        [TestMethod()]
        public void GetDataUsingDataContractTest()
        {
           //Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Service1 addservice = new Service1();
            double result = addservice.Add(4, 5.5);
            Assert.AreEqual(9.5, result);
        }
    }
}