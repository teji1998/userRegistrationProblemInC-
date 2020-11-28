
using Microsoft.VisualStudio.TestTools.UnitTesting;
using userRegistrationProblem;

namespace userValidationTest
{
    [TestClass]
    public class UnitTest1
    {
        private UserValidation userValidation;

        public UnitTest1()
        {
            userValidation = new UserValidation();
        }

        
        [TestMethod]
        public void givenFirstName_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Tejaswini");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenFirstName_WhenHasMinimumLength_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Tej");
            Assert.IsTrue(result);
        }

    }
}
