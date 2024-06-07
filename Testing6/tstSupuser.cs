using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstSupuser
    {
        
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsSUPuser AnUser = new clsSUPuser();
                //test to see that it exists
                Assert.IsNotNull(AnUser);
            }
            [TestMethod]
            public void UserIDPropertyOK()
            {
                //create an instance of the class we want to create
                clsSUPuser AnUser = new clsSUPuser();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                AnUser.UserID = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnUser.UserID, TestData);
            }
            [TestMethod]
            public void PasswordPropertyOK()
            {
                //create an instance of the class we want to create
                clsSUPuser AnUser = new clsSUPuser();
                //create some test data to assign to the property
                string TestData = "password123";
                //assign the data to the property
                AnUser.Password = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnUser.Password, TestData);

            }

            [TestMethod]
            public void DepartmentPropertyOK()
            {
                //create an instance of the class we want to create
                clsSUPuser AnUser = new clsSUPuser();
                //create some test data to assign to the property
                string TestData = "Department";
                //assign the data to the property
                AnUser.Department = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnUser.Department, TestData);

            }

            [TestMethod]
            public void FindUserMethodOK()
            {
                //create an instance of the class we want to create
                clsSUPuser AnUser = new clsSUPuser();
                //create a Boolean variable to store the results of the validation
                Boolean Found = false;
                //create some test data to use with the method
                string UserName = "Aadarsh";
                string Password = "Aadarsh";
                //invoke the method
                Found = AnUser.FindUser(UserName, Password);
                //test to see if the result is true
                Assert.IsTrue(Found);
            }

            [TestMethod]
            public void TestUsernamePWFound()
            {
                //create an instance of the class we want to create
                clsSUPuser AnUser = new clsSUPuser();
                //create a Boolean variable to store the result of the search
                Boolean Found = false;
                //create a Boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                string Username = "Aadarsh";
                string Password = "Aadrsh000";
                //invoke the method
                Found = AnUser.FindUser(Username, Password);
                if (AnUser.UserName == Username && AnUser.Password == Password)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);


            }
        
    }
}
