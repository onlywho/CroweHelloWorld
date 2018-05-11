using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CroweHelloWorld.Tests
{
    [TestClass]
    public class TestSimpleProductController
    {
        [TestMethod]
        public void Get_ShouldReturnHelloWorld()
        {
            var expected = "Hello World!";
            var controller = new HelloWorldController();

            var result = controller.Get();

            Assert.AreEqual(expected, result);
        }
    }
}
