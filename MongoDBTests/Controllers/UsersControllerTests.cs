//using Castle.Core.Configuration;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MongoDB.Controllers;
//using MongoDB.Interfaces;
//using MongoDB.Models;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MongoDB.Controllers.Tests
//{
//    [TestClass()]
//    public class UsersControllerTests
//    {
//        private UsersController controller;
//        Mock<UserInterface> mockUserInterface=new Mock<UserInterface>();
        
        

//        //[TestMethod()]
//        //public void GetTest_Return_Success()
//        //{
//        //    //arrange
//        //    var list = new List<Users>() { new Users { Email = "abc", Id = "2", Name = "sad", Password = "123" } };
            
            

//        //    mockUserInterface.Setup(x => x.GetUsers()).Returns(list);

//        //    //act
//        //    var result = (OkObjectResult)controller.Get();
//        //    var items = (List<Users>)result.Value;

//        //    //Assert
//        //    Assert.IsNotNull(result);
//        //    Assert.IsInstanceOfType<IActionResult>(result);
//        //    Assert.AreEqual(list.Count, items.Count);
//        //}

//        [TestMethod()]
//        public void GetUserById_Id_Return_Success()
//        {
//            //arrange


//            controller = new UsersController(mockUserInterface.Object);
//            var user = new Users() { Id = "1" };
//            mockUserInterface.Setup(x => x.GetUserById(It.IsAny<string>())).Returns(user);

//            //act
//            var result = (OkObjectResult)controller.GetUserById("1");
          

//            //Assert
//            Assert.IsNotNull(result);
//            Assert.IsInstanceOfType<IActionResult>(result);
//            Assert.AreEqual(user, (Users)result.Value);
//        }
//    }
//}