using AspNetMvcHelloWorld.Controllers;
using AspNetMvcHelloWorld.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace AspNetMvcHelloWorld.Tests
{
    [TestClass]
    public class MessageControllerTests
    {
        [TestMethod]
        public void MessageContollerGetIndex()
        {
            var target = new MessageController(new MockRepository());
            var result = target.Index() as ViewResult;
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.IsNotNull(result);
            var vm = result.Model as Message;
            Assert.IsInstanceOfType(vm, typeof(Message));
            Assert.IsNotNull(vm);
            Assert.IsTrue(vm.Greet == "My mocked greeting");
        }

        private class MockRepository : IRepository
        {
            public Message GetMessage()
            {
                return new Message { Greet = "My mocked greeting" };
            }
        }
    }
}
