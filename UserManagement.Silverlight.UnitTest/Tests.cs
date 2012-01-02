using Microsoft.VisualStudio.TestTools.UnitTesting;

using UserManagement.Silverlight.ServiceReference1;
using UserManagement.Silverlight.ViewModel;

namespace UserManagement.Silverlight.UnitTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void UserName_WithUserHavingFirstAndLastName_ShouldConcatenateAsUserName()
        {
            // Arrange
            UserDto userDetails = new UserDto
                {
                    Id = 101,
                    FirstName = "James",
                    LastName = "Bond"
                };

            UserViewModel viewModel = new UserViewModel(userDetails);

            // Act
            string result = viewModel.UserName;

            // Assert
            Assert.AreEqual("James Bond", result);
        }
    }
}