using Microsoft.AspNetCore.Mvc;
using Maxdel.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Maxdel.DB;
using Maxdel.Repositorio;

namespace MaxdelTest.Controllers
{
    public class HomeControllerTest
    {
        [Test]
        public void IndexViewCase01()
        {
            var mockController = new Mock<IHomeRepositorio>();

            var controller = new HomeController(null, mockController.Object);  
            var view = controller.Index() as ViewResult;

            Assert.IsNotNull(view);
        }
        [Test]
        public void MenuViewCase01()
        {
            var mockController = new Mock<IHomeRepositorio>();
            var controller = new HomeController(null, mockController.Object);
            var view = controller.Menu() as ViewResult;

            Assert.IsNotNull(view);
        }
    }
}
