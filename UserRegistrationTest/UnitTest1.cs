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
            //Assign
            string expected = "Name should not be empty";
            string name = "";
            try
            {
                //act
                string actual = registration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException ex)
            {
                //assert
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        public void LastNameException()
        {
            //Assign
            string expected = "Name should not be null";
            string name = null;
            try
            {
                //act
                string actual = registration.CheckName(name);
                Assert.AreEqual(actual, expected);
            }
            catch (CustomException ex)
            {
                //assert
                Assert.AreEqual(ex.Message, expected);
            }
        }
        [TestMethod]
        public void PasswordExceptionTest()
        {
            //Assign
            string expected = "Password should not be empty";
            string password = "";
            //act
            try
            {
                string actual = registration.PasswordCheck(password);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ce)
            {
                //assert
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
            string actual = UserRegistrationExp.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Checks for validation using annotation = if phone number not valid
        /// </summary>
        [TestMethod]
        public void CheckValidation2()
        {
            user.firstName = "Damon";
            user.lastName = "Salvatore";
            user.phoneNumber = "45678923";
            user.EmailAddress = "dstvd@gmail.com";
            user.Password = "Dasa@1mjh";
            string expected = "Phone number should exactly 10";
            string actual = UserRegistrationExp.TestUserRegistration(user);
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
            string actual = UserRegistrationExp.TestUserRegistration(user);
            Assert.AreEqual(expected, actual);
        }
    }
}
