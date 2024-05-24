using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unittestpractise.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Unittestpractise.Controllers.Tests
{
    [TestClass()]
    public class OrderControllerTests
    {
        private OrderController _controller;
        private Mock<Interface> mockdata = new Mock<Interface>();

        [TestMethod()]
        public void OrderControllerTest()
        {
            _controller = new OrderController(mockdata.Object);

            mockdata.Setup(x => x.getValue(1)).Returns(1);

            var result = _controller.Get(1);

            Assert.IsNotNull(result);
        }
    }
}