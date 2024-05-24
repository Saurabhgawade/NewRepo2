//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using mongofinal.Controllers;
//using mongofinal.Models;
//using Moq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mongofinal.Controllers.Tests
//{
//    [TestClass()]
//    public class UsersControllerTests
//    {
//        private UsersController usersController;
//        private Mock<Interfaceuser> mockuser=new Mock<Interfaceuser>();


//        [TestMethod()]
//        public void getByIdTest()
//        {
//            usersController = new UsersController(mockuser.Object);
//            mockuser.Setup(x => x.getUserById("59b99db4cfa9a34dcd7885b6")).Returns(new Users());

//            var result = usersController.getById();
//            Assert.IsNotNull(result);
//        }
//        [TestMethod]
//        public void getAll_Test_Success()
//        {
//             List<Users> users= new List<Users>() { new Users() { Id = "1", Name = "saurabh", Email = "vhvj", Password = "dvh" } };
//            usersController = new UsersController(mockuser.Object);
//            mockuser.Setup(x => x.getAllUsers()).Returns(users);

//           var result= usersController.getAll();

//            Assert.IsNotNull(result);

//        }
//    }
//}