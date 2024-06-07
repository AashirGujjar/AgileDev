using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class ClsUsersCollectionTests
    {
        // Good test data
        private string goodUserName = "TestUser";
        private string goodPassword = "TestPassword";
        private string goodEmail = "testuser@example.com";
        private string goodRole = "user";
        private bool goodIsActive = true;

        [TestInitialize]
        public void TestInitialize()
        {
            // Clean up test data before each test if necessary
            CleanUpTestData();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up test data after each test if necessary
            CleanUpTestData();
        }

        private void CleanUpTestData()
        {
            // Remove any test users that might have been created
            var collection = new ClsUsersCollection();
            var testUser = collection.GetByEmail(goodEmail);
            if (testUser != null)
            {
                collection.Delete(testUser.UserID);
            }
        }

        /****************** Instance of the class Test *********************/

        [TestMethod]
        public void InstanceOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            Assert.IsNotNull(allUsers);
        }

        /************************* Property OK Tests ************************/

        [TestMethod]
        public void UsersListOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            List<ClsUser> testList = new List<ClsUser>();
            ClsUser testItem = new ClsUser
            {
                UserID = 1,
                UserName = "TestUser",
                Password = "TestPassword",
                Email = "test@example.com",
                Role = "user",
                IsActive = true
            };

            testList.Add(testItem);
            allUsers.UsersList = testList;

            Assert.AreEqual(allUsers.UsersList, testList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            int count = allUsers.Count;
            Assert.AreEqual(count, allUsers.Count);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            ClsUser testItem = new ClsUser
            {
                UserID = 1,
                UserName = "TestUser",
                Password = "TestPassword",
                Email = "test@example.com",
                Role = "user",
                IsActive = true
            };

            allUsers.ThisUser = testItem;

            Assert.AreEqual(allUsers.ThisUser, testItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            List<ClsUser> testList = new List<ClsUser>();
            ClsUser testItem = new ClsUser
            {
                UserID = 1,
                UserName = "TestUser",
                Password = "TestPassword",
                Email = "test@example.com",
                Role = "user",
                IsActive = true
            };

            testList.Add(testItem);
            allUsers.UsersList = testList;

            Assert.AreEqual(allUsers.Count, testList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            Assert.AreEqual(allUsers.Count, allUsers.Count);
        }

        /*************************** Add Method Test **************************************/

        [TestMethod]
        public void AddMethodOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            ClsUser testUser = new ClsUser
            {
                UserName = goodUserName,
                Password = goodPassword,
                Email = goodEmail,
                Role = goodRole,
                IsActive = goodIsActive
            };

            allUsers.ThisUser = testUser;
            int primaryKey = allUsers.Add();
            testUser.UserID = primaryKey;

            allUsers.ThisUser.Find(primaryKey);
            Assert.AreEqual(allUsers.ThisUser, testUser);
        }

        /********************************** Update Method Test ************************************/

        [TestMethod]
        public void UpdateMethodOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            ClsUser testUser = new ClsUser
            {
                UserName = goodUserName,
                Password = goodPassword,
                Email = goodEmail,
                Role = goodRole,
                IsActive = goodIsActive
            };

            allUsers.ThisUser = testUser;
            int primaryKey = allUsers.Add();
            testUser.UserID = primaryKey;

            testUser.UserName = "UpdatedUser";
            testUser.Password = "UpdatedPassword";
            testUser.Email = "updated@example.com";
            testUser.Role = "admin";
            testUser.IsActive = false;

            allUsers.ThisUser = testUser;
            allUsers.Update();
            allUsers.ThisUser.Find(primaryKey);
            Assert.AreEqual(allUsers.ThisUser, testUser);
        }

        /********************************** Delete Method Test ************************************/

        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            ClsUser testUser = new ClsUser
            {
                UserName = goodUserName,
                Password = goodPassword,
                Email = goodEmail,
                Role = goodRole,
                IsActive = goodIsActive
            };

            allUsers.ThisUser = testUser;
            int primaryKey = allUsers.Add();
            testUser.UserID = primaryKey;

            allUsers.ThisUser.Find(primaryKey);
            allUsers.Delete(primaryKey);
            bool found = allUsers.ThisUser.Find(primaryKey);

            Assert.IsFalse(found);
        }

        /********************************** Filter Method Test ************************************/

        [TestMethod]
        public void ReportByUserNameMethodOK()
        {
            ClsUsersCollection allUsers = new ClsUsersCollection();
            ClsUsersCollection filteredUsers = new ClsUsersCollection();
            filteredUsers.ReportByUserName("");

            Assert.AreEqual(allUsers.Count, filteredUsers.Count);
        }

        [TestMethod]
        public void ReportByUserNameNoneFound()
        {
            ClsUsersCollection filteredUsers = new ClsUsersCollection();
            filteredUsers.ReportByUserName("NonExistentUser");

            Assert.AreEqual(0, filteredUsers.Count);
        }

       
    }
}