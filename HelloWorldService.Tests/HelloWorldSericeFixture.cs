using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bll=HelloWorld.Service;
using Moq;

namespace HelloWorldService.Tests
{
    [TestClass]
    public class HelloWorldServieFixture
    {
        [TestMethod]
        public void HelloWorldService_APISupportingAnyClient_ReturnsHelloWorld()
        {
            Bll.IHelloWorld service = new Bll.HelloWorldService();
            Assert.AreEqual(service.GetHelloWorld(),"Hello World");
        }
        [TestMethod]
        public void HelloWorldService_CurrentWriterDoesNotExist_ReturnsFalse()
        {
            Bll.HelloWorldService service = new Bll.HelloWorldService();
            Assert.IsFalse(service.Save());
        }

        [TestMethod]
        public void HelloWorldService_WriterExist_SavesReturnsTrue()
        {
            Mock<Bll.IHelloWorldWritter> writer = new Mock<Bll.IHelloWorldWritter>();
            writer.Setup(w => w.WriteLine("Hello World")).Returns(true);
            Bll.HelloWorldService service = new HelloWorld.Service.HelloWorldService(writer.Object);
            Assert.IsTrue(service.Save());
            writer.Verify();
        }
    }
}
