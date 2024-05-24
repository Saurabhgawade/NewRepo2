using Microsoft.VisualStudio.TestTools.UnitTesting;
using unittestpractise1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace unittestpractise1.Controllers.Tests
{
    [TestClass()]
    public class DemoControllerTests
    {
        private DemoController _controller;
        private Mock<Interfacedemo> mockingData = new Mock<Interfacedemo>();
        [TestMethod()]

       
        public void GetTest()
        {
            _controller = new DemoController(mockingData.Object);
            mockingData.Setup(x => x.getValue(1)).Returns(2);

           var result= _controller.Get(1);

            Assert.IsNotNull(result);
        }
    }
}