using webV6.Controllers;
using WebV6.Tests.FakeServices;

namespace WebV6.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTesting
    {
        [TestMethod]
        public void HomePageCheck()
        {
            // Arrange
            var repository = new FakeRepository();
            var uploadFile = new FakeFileUpload();
            var controller = new HomeController(repository, uploadFile);

            //Act
            
        }
    }
}