using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegistrationExp registration;
        UserAnnotation user;
        [TestInitialize]
        public void TestSetup()
        {
            registration = new UserRegistrationExp();
            user = new UserAnnotation();
        }
        [TestCategory("Name")]
        [TestMethod]
        public void FirstNameException()
        {
            string expected = "Name should not be empty";
            string name = "";
            try
            {
                string actual = registration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        public void LastNameException()
        {
            string expected = "Name should not be null";
            string name = null;
            try
            {
                string actual = registration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException ex)
            {

                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        public void PasswordExceptionTest()
        {
            string expected = "Password should not be empty";
            string password = "";
            try
            {
                string actual = registration.PasswordCheck(password);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ce)
            {
                
                Assert.AreEqual(ce.Message, expected);
            }
        }
        [TestMethod]
        public void CheckValidation1()
        {
            user.firstName = "Da";
            user.lastName = "Salvatore";
            user.phoneNumber = "4567892356";
            user.EmailAddress = "dstvd@gmail.com";
            user.Password = "Dasa@1mjh";
            string expected = "First Name should be min of 3";
            string actual = UserRegistrationExp.ValidateUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckValidation2()
        {
            user.firstName = "Damon";
            user.lastName = "Salvatore";
            user.phoneNumber = "45678923";
            user.EmailAddress = "dstvd@gmail.com";
            user.Password = "Dasa@1mjh";
            string expected = "Phone number should exactly 10";
            string actual = UserRegistrationExp.ValidateUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckValidation3()
        {
            user.firstName = "Damon";
            user.lastName = "S";
            user.phoneNumber = "45678923";
            user.EmailAddress = "dstvd@gmail.com";
            user.Password = "Dasa@1mjh";
            string expected = "Last Name should be min of 3";
            string actual = UserRegistrationExp.ValidateUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckValiditionShouldReturnHappy()
        {
            user.firstName = "Damon";
            user.lastName = "Salvatore";
            user.phoneNumber = "4567892378";
            user.EmailAddress = "dstvd@gmail.com";
            user.Password = "Dasa@1mjh";
            string expected = "Happy";
            string actual = UserRegistrationExp.ValidateUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckValiditionShouldReturnSad()
        {
            user.firstName = "Damon";
            user.lastName = "S";
            user.phoneNumber = "45678923";
            user.EmailAddress = "dstvd@gmail.com";
            user.Password = "Dasa@1mjh";
            string expected = "Sad";
            string actual = UserRegistrationExp.ValidateUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("dstvdgmail.com", "0")]
        [DataRow("dstvd@gmail.com", "1")]
        [DataRow("dstvd//@gmail.com", "0")]
        [DataRow("dstvd@gm.c", "0")]
        [DataRow("dstvd@gmail.co", "1")]
        [DataRow("dst.vd@gmail.com", "1")]
        public void ParameterizedTestForMail(string mail, string expected)
        {
            string actual =registration.CheckMail(mail);
            Assert.AreEqual(expected, actual);
        }
    }
}
