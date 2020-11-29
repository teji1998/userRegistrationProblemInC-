
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

        [TestMethod]
        public void givenMobileNumber_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.mobileNumberValidation("91 9920275347");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenMobileNumber_WhenDoesNotHaveCountryCode_ShouldReturnFalse()
        {
            bool result = userValidation.mobileNumberValidation("9920275347");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WhenDoesNotHaveSpaceBetweenCountryCodeAndMobileNumber_ShouldReturnFalse()
        {
            bool result = userValidation.mobileNumberValidation("919920275347");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WhenDoesIsOfInvalidLength_ShouldReturnFalse()
        {
            bool result = userValidation.mobileNumberValidation("91 99920275347");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WhenStartsWithANumberLessThanSix_ShouldReturnFalse()
        {
            bool result = userValidation.mobileNumberValidation("91 4520275347");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WhenEmpty_ShouldReturnFalse()
        {
            bool result = userValidation.mobileNumberValidation("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.passwordValidation("Teji@1998");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenPassword_WhenBeginsWithSmallLetter_ShouldReturnTrue()
        {
            bool result = userValidation.passwordValidation("tejiK@1998");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenPassword_WhenBeginsWithNumber_ShouldReturnTrue()
        {
            bool result = userValidation.passwordValidation("1Teji@k1998");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenPassword_WhenLessThanMinimumLength_ShouldReturnFalse()
        {
            bool result = userValidation.passwordValidation("Teji@9");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithoutCapitalLetter_ShouldReturnFalse()
        {
            bool result = userValidation.passwordValidation("teji@1198");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithoutSmallLetter_ShouldReturnFalse()
        {
            bool result = userValidation.passwordValidation("TEJI@1998");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithoutNumbers_ShouldReturnFalse()
        {
            bool result = userValidation.passwordValidation("Tejiexo@");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithoutSpecialCharacter_ShouldReturnFalse()
        {
            bool result = userValidation.passwordValidation("Teji1998");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithEmpty_ShouldReturnFalse()
        {
            bool result = userValidation.passwordValidation("");
            Assert.IsFalse(result);
        }

        

    }
}
