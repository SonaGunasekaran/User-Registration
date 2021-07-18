using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
       UserRegistrationExp registration;
        [TestInitialize]
        public void TestSetup()
        {
            registration = new UserRegistrationExp();
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

    }
}
