using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mongo2.Controllers;
using Mongo2.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mongo2.Controllers.Tests
{
    [TestClass()]
    public class SessionControllerTests
    {
        private SessionController controller;
        //mock
        Mock<ISession> mockISession = new Mock<ISession>();
        public SessionControllerTests()
        {
            controller = new SessionController(mockISession.Object);
        }

        [TestMethod()]
        public void SessionControllerTest_return_success()
        {
            var session = new Session() { Id = "1" };
            //arrange
            

            
            mockISession.Setup(x => x.GetSessionById(It.IsAny<string>())).Returns(session);


            //act
            var result =(OkObjectResult)controller.getSessions();




            //assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType<IActionResult>(result);
            Assert.AreEqual(session, result.Value);
        }

        [TestMethod()]
        public void AllSessionTest_return_success()
        {
            //arrange
            List<Session> list = new List<Session>() { new Session() { Id="1",userId="23",Jwt="sv"} };
            mockISession.Setup(x => x.AllSessions()).Returns(list);



            //act
            var result =(OkObjectResult)controller.AllSessions();
            var item = (List<Session>)result.Value;


            //assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType<IActionResult>(result);
            Assert.AreEqual(list.Count,item.Count);
        }
    }
}