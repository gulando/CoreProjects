using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;
namespace ControllersAndActions.Tests
{
    public class ActionTests
    {
        [Fact]
        public void ViewSelected()
        {
            //// Arrange
            //HomeController controller = new HomeController();
           
            //// Act
            //ViewResult result = controller.ReceiveForm("Adam", "London");
           
            //// Assert
            //Assert.Equal("Result", result.ViewName);
        }

        [Fact]
        public void ModelObjectType0()
        {
            //Arrange
            //ExampleController controller = new ExampleController();
           
            //// Act
            //ViewResult result = controller.Index();
           
            //// Assert
            //Assert.IsType<System.DateTime>(result.ViewData.Model);
        }

        [Fact]
        public void ModelObjectType1()
        {
            ////Arrange
            //ExampleController controller = new ExampleController();
           
            //// Act
            //ViewResult result = controller.Index();
           
            //// Assert
            //Assert.IsType<string>(result.ViewData["Message"]);
            //Assert.Equal("Hello", result.ViewData["Message"]);
            //Assert.IsType<System.DateTime>(result.ViewData["Date"]);
        }

        [Fact]
        public void Redirection()
        {
            // Arrange
            ExampleController controller = new ExampleController();
            // Act
            RedirectToActionResult result = controller.Redirect4();
            // Assert
            Assert.False(result.Permanent);
            Assert.Equal("Index", result.ActionName);
        }

        [Fact]
        public void JsonActionMethod()
        {
            //// Arrange
            //ExampleController controller = new ExampleController();
            //// Act
            //JsonResult result = controller.Index();
            //// Assert
            //Assert.Equal(new[] { "Alice", "Bob", "Joe" }, result.Value);
        }
    }
}