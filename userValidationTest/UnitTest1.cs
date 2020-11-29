
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
        public void GivenFirstName_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Tejaswini");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenFirstName_WhenHasMinimumLength_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Tej");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void GivenFirstName_WhenIsLessThanMinimumLength_ShouldThrowAnException()
        {
            try
            {
                bool result = userValidation.nameValidation("Te");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should contain atleast three letters ", userException.Message);
            }
        }

       [TestMethod]
        public void GivenFirstName_WhenHasNumericValue_ShouldThrowAnException()
        {
            try
            {
                bool result = userValidation.nameValidation("Teju1998");
            }
            catch(UserException userException)
            {
                Assert.AreEqual("Name should not have numbers", userException.Message);
            }
        }

        [TestMethod]
        public void GivenFirstName_WhenHasSpecialCharacter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("Teju$");
            }catch(UserException userException)
            {
                Assert.AreEqual("Name should not contain special characters", userException.Message);
            }
            
        }

        [TestMethod]
        public void GivenFirstName_WhenHasNoCapitalLetter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("teju");
            }catch(UserException userException)
            {
                Assert.AreEqual("Name should have first letter capital", userException.Message);
            }
        }

        [TestMethod]
        public void GivenFirstName_WhenDoesNotHaveFirstLetterHasCapital_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("tejuK");
            }catch (UserException userException)
            {
                Assert.AreEqual("Name should have first letter capital", userException.Message);
            }
        }

        [TestMethod]
        public void GivenFirstName_WhenHasSpaceInBetween_ShouldReturnFalse()
        {
            try
            {
               bool result = userValidation.nameValidation("Teju K");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should not have a space", userException.Message);
            }
        }

        [TestMethod]
        public void GivenFirstName_WhenisEmpty_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should not be empty", userException.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Kulkarni");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenLastName_WhenHasMinimumLength_ShouldReturnTrue()
        {
            bool result = userValidation.nameValidation("Kul");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void GivenLastName_WhenIsLessThanMinimumLength_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("Ku");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should contain atleast three letters ", userException.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_WhenHasNumericValue_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("Kulkarni1998");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should not have numbers", userException.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_WhenHasSpecialCharacter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("Kulkarni$");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should not contain special characters", userException.Message);
            }

        }

        [TestMethod]
        public void GivenLastName_WhenHasNoCapitalLetter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("kulkarni");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should have first letter capital", userException.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_WhenDoesNotHaveFirstLetterHasCapital_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("tKulkarni");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should have first letter capital", userException.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_WhenHasSpaceInBetween_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("Kulkarni T");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should not have a space", userException.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_WhenisEmpty_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.nameValidation("");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Name should not be empty", userException.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.mobileNumberValidation("91 9920275347");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenMobileNumber_WhenDoesNotHaveCountryCode_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.mobileNumberValidation("9920275347");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Country code is absent", userException.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_WhenContainsAlphabet_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.mobileNumberValidation("91 9a20275347");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("There should be no alphabets", userException.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_WhenContainsSpecialCharacter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.mobileNumberValidation("91 9!20275347");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("There should be no special characters", userException.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_WhenDoesNotHaveSpaceBetweenCountryCodeAndMobileNumber_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.mobileNumberValidation("919920275347");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("There should be space between country code and mobile number", userException.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_WhenDoesIsOfInvalidLength_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.mobileNumberValidation("91 99920275347");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("The length of mobile number is invalid", userException.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_WhenStartsWithANumberLessThanSix_ShouldReturnFalse()
        { 
             bool result = userValidation.mobileNumberValidation("91 4520275347");
            Assert.IsFalse(result);        
        }

        [TestMethod]
        public void GivenMobileNumber_WhenEmpty_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.mobileNumberValidation("");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Mobile number should not be empty", userException.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WhenValid_ShouldReturnTrue()
        {
            bool result = userValidation.passwordValidation("Teji@1998");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenPassword_WhenBeginsWithSmallLetter_ShouldReturnTrue()
        {
            bool result = userValidation.passwordValidation("tejiK@1998");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenPassword_WhenBeginsWithNumber_ShouldReturnTrue()
        {
            bool result = userValidation.passwordValidation("1Teji@k1998");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenPassword_WhenLessThanMinimumLength_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.passwordValidation("Teji@9");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Password should be of atleast 8 characters", userException.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WhenHasSpaceInBetween_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.passwordValidation("Teji @1998");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Password should not have a space", userException.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WithoutCapitalLetter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.passwordValidation("teji@1198");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Password should consist of capital letters", userException.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WithoutSmallLetter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.passwordValidation("TEJI@1998");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Password should have atleast one lower case letter", userException.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WithoutNumbers_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.passwordValidation("Tejiexo@");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Password should contain numbers", userException.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WithoutSpecialCharacter_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.passwordValidation("Teji1998");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Password should contain special character", userException.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WithEmpty_ShouldReturnFalse()
        {
            try
            {
                bool result = userValidation.passwordValidation("");
            }
            catch (UserException userException)
            {
                Assert.AreEqual("Password should not be empty", userException.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc@1.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmails_WhenAreValid_ShouldReturnTrue(string email)
        {
            bool result = userValidation.emailIdValidation(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("abc.com")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        [DataRow(" ")]
        public void GivenEmail_WhenAreNotValid_ShouldReturnFalse(string email)
        {
            bool result = userValidation.emailIdValidation(email);
            Assert.IsFalse(result);
        }

    }
}
