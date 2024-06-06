using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstCar
    {
        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //test to see that it exists
            Assert.IsNotNull(ACar);
        }



        [TestMethod]
        public void makePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Testmake";
            //assign the data to the property
            ACar.Make = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Make, TestData);
        }

        [TestMethod]
        public void vinNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            ACar.VinNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.VinNumber, TestData);
        }

        [TestMethod]
        public void modelPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Testmake";
            //assign the data to the property
            ACar.Model = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Model, TestData);
        }

        [TestMethod]
        public void yearPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 2000;
            //assign the data to the property
            ACar.Year = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Year, TestData);
        }

        [TestMethod]
        public void colorPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Red";
            //assign the data to the property
            ACar.Color = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Color, TestData);
        }

        [TestMethod]
        public void pricePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 2000;
            //assign the data to the property
            ACar.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Price, TestData);
        }


        [TestMethod]
        public void purchaseDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            ACar.PurchaseDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.PurchaseDate, TestData);
        }

        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 vinNumber = 3;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        ///******************PROPERTY DATA TESTS******************/


        [TestMethod]
        public void TestVinNumberFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 vinNumber = 1;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //check the vinNumber property
            if (ACar.VinNumber != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMakeFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 vinNumber = 1;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //check the make property
            if (ACar.Make != "Tesla")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 vinNumber = 1;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //check the model property
            if (ACar.Model != "Tesla")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestYearFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 vinNumber = 1;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //check the year property
            if (ACar.Year != 2000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColorFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 vinNumber = 1;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //check the color property
            if (ACar.Color != "Red")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 vinNumber = 1;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //check the price property
            if (ACar.Price != 1000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPurchaseDateFound()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 vinNumber = 1;
            //invoke the method
            Found = ACar.Find(vinNumber);
            //check the purchaseDate property
            if (ACar.PurchaseDate != Convert.ToDateTime("06/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
