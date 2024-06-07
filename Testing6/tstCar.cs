using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstCar
    {

        //good test data
        string make = "Tesla";
        string model = "model";
        String year = Convert.ToString("2000");
        String color = "Red";
        string price = Convert.ToString("2000");
        string purchaseDate = DateTime.Now.ToShortDateString();
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
            Int32 vinNumber = 1;
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

        //parametric tests for make
        [TestMethod]
        public void MakeMinLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string make = "";

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
           

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMin()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string make = "q";

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMinplusone()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string make = "qq";

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMaxLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = new string('q', 49);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMax()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = new string('q', 50);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMid()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Name = new string('q', 25);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMaxPlusOne()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string make = new string('q', 51);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeExtremeMax()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string make = new string('q', 500);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //parameter test for model
        [TestMethod]
        public void ModelMinLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string model = "";

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);


            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMin()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string model = "q";

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void modelMinplusone()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string model = "qq";

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxLessOne()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string model = new string('q', 49);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMax()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string Model = new string('q', 50);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMid()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string model = new string('q', 25);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxPlusOne()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string model = new string('q', 51);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelExtremeMax()
        {
            //Create a instamce of the class we want to create 
            clsCar ACar = new clsCar();

            //string variable for error message 
            String Error = "";

            //create some test to pass to the method
            string model = new string('q', 500);

            //invoke the method 
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ColorMinLessOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = "";
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColorMin()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = "q";
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColorMinPlusOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = "qq";
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColorMaxLessOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = new string('q', 49);
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColorMax()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = new string('q', 50);
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColorMid()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = new string('q', 25);
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColorMaxPlusOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = new string('q', 51);
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColorExtremeMax()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string color = new string('q', 500);
            Error = ACar.Valid(make, model, year, color, price, purchaseDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = -100000001;  // Just below minimum value
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = -1;  // Just below minimum value
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PriceMin()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = 0;  // Minimum value
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = 1;  // Just above minimum value
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = 9999999;  
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PriceMax()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = 10000000;  
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = 10000001;  
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsCar ACar = new clsCar();
            string Error = "";
            int Price = 1000000000;  
            Error = ACar.Valid(make, model, year, color, Price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }
        
/******************Parameter Tests for purchaseDate******************/
[TestMethod]
public void PurchaseDateExtremeMin()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-200);
            string purchaseDate = TestDate.ToString();
            Error = ACar.Valid(make, model, year, color, price.ToString(), purchaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchaseDateMinLessOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-101);
            string purchaseDate = TestDate.ToString();
            Error = ACar.Valid(make, model, year, color, price.ToString(), purchaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchaseDateMin()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string purchaseDate = TestDate.ToString();
            Error = ACar.Valid(make, model, year, color, price.ToString(), purchaseDate);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PurchaseDateMinPlusOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(+1);
            string purchaseDate = TestDate.ToString();
            Error = ACar.Valid(make, model, year, color, price.ToString(), purchaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchaseDateExtremeMax()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);
            string purchaseDate = TestDate.ToString();
            Error = ACar.Valid(make, model, year, color, price.ToString(), purchaseDate);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchaseDateInvalidData()
        {
            clsCar ACar = new clsCar();
            String Error = "";

            string purchaseDate = "this is not a date";

            Error = ACar.Valid(make, model, year, color, price.ToString(), purchaseDate);

            Assert.AreNotEqual(Error, "");
        }

        /******************Parameter Tests for Year******************/
        [TestMethod]
        public void YearExtremeMin()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            int year = DateTime.Now.Year - 201;
            Error = ACar.Valid(make, model, year.ToString(), color, price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void YearMinLessOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            int year = DateTime.Now.Year - 101;
            Error = ACar.Valid(make, model, year.ToString(), color, price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void YearMin()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            int year = DateTime.Now.Year - 100;
            Error = ACar.Valid(make, model, year.ToString(), color, price.ToString(), purchaseDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void YearMinPlusOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            int year = DateTime.Now.Year - 99;
            Error = ACar.Valid(make, model, year.ToString(), color, price.ToString(), purchaseDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void YearMax()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            int year = DateTime.Now.Year;
            Error = ACar.Valid(make, model, year.ToString(), color, price.ToString(), purchaseDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void YearMaxPlusOne()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            int year = DateTime.Now.Year + 1;
            Error = ACar.Valid(make, model, year.ToString(), color, price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void YearExtremeMax()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            int year = DateTime.Now.Year + 100;
            Error = ACar.Valid(make, model, year.ToString(), color, price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void YearInvalidData()
        {
            clsCar ACar = new clsCar();
            String Error = "";
            string year = "invalid year";
            Error = ACar.Valid(make, model, year, color, price.ToString(), purchaseDate);
            Assert.AreNotEqual("", Error);
        }



    }
}
