using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Testing1;
using ClassLibrary;
namespace Testing1.Tests
{
    [TestClass]
    public class ClsUserTests
    {
        // Good test data
        private string goodUserName = "GoodUser";
        private string goodPassword = "GoodPassword";
        private string goodEmail = "good@example.com";
        private string goodRole = "user";

        [TestMethod]
        public void UserNameMin()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid("a", goodPassword, goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void UserNameMinPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid("aa", goodPassword, goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void UserNameMaxLessOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(new string('a', 49), goodPassword, goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void UserNameMax()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(new string('a', 50), goodPassword, goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(new string('a', 51), goodPassword, goodEmail, goodRole);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void UserNameBlank()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid("", goodPassword, goodEmail, goodRole);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void PasswordMin()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, "a", goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, "aa", goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, new string('a', 49), goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void PasswordMax()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, new string('a', 50), goodEmail, goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, new string('a', 51), goodEmail, goodRole);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void PasswordBlank()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, "", goodEmail, goodRole);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void EmailMin()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, "a@b.c", goodRole);

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, "ab@c.d", goodRole);

            // Assert
            Assert.AreEqual("", error);
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            ClsUser user = new ClsUser();
            // The length of the email address should be 100 characters in total
            string email = new string('a', 88) + "@example.com";
            string error = user.Valid(goodUserName, goodPassword, email, goodRole);
            Assert.AreEqual("", error);
        }


        [TestMethod]
        public void EmailMax()
        {
            ClsUser user = new ClsUser();
            // The length of the email address should be 100 characters in total
            string email = new string('a', 70) + "@example.com";
            string error = user.Valid(goodUserName, goodPassword, email, goodRole);
            Assert.AreEqual("", error);
        }




        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, new string('a', 91) + "@example.com", goodRole);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void EmailBlank()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, "", goodRole);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void EmailInvalidFormat()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, "invalidemail", goodRole);

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void RoleMin()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, goodEmail, "a");

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, goodEmail, "aa");

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, goodEmail, new string('a', 19));

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void RoleMax()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, goodEmail, new string('a', 20));

            // Assert
            Assert.AreEqual("", error);
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, goodEmail, new string('a', 21));

            // Assert
            Assert.AreNotEqual("", error);
        }

        [TestMethod]
        public void RoleBlank()
        {
            // Arrange
            ClsUser user = new ClsUser();
            string error = "";

            // Act
            error = user.Valid(goodUserName, goodPassword, goodEmail, "");

            // Assert
            Assert.AreNotEqual("", error);
        }
    }
}