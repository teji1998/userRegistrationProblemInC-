
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


        [TestMethod]
        public void givenFirstName_WhenIsLessThanMinimumLength_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("Te");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WhenHasNumericValue_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("Teju1998");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WhenHasSpecialCharacter_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("Teju$");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WhenHasNoCapitalLetter_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("teju");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WhenDoesNotHaveFirstLetterHasCapital_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("tejuK");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WhenisEmpty_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Kulkarni");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenLastName_WhenHasMinimumLength_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Kul");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void givenLastName_WhenIsLessThanMinimumLength_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("Ku");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WhenHasNumericValue_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("Kulkarni1998");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WhenHasSpecialCharacter_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("Kulkarni$");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WhenHasNoCapitalLetter_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("kulkarni");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WhenDoesNotHaveFirstLetterHasCapital_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("tKulkarni");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WhenisEmpty_ShouldReturnFalse()
        {
            bool result = userValidation.nameValidation("");
            Assert.IsFalse(result);
        }



    }
}
