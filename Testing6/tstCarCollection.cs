using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of new class RegisterCollection
            clsCarCollection AllCar = new clsCarCollection();
            //test to see if it exists
            Assert.IsNotNull(AllCar);
        }

        [TestMethod]
        public void CarListOK()
        {
            //instance of register collection class
            clsCarCollection AllCar = new clsCarCollection();


            //create some test data to assign to the property 
            //in this case a list 
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list 
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.Make = "Tesla";
            TestItem.Model = "model";
            TestItem.Color = "Red";
            TestItem.Price = 1000;
            TestItem.Year = 2000;
            TestItem.PurchaseDate = DateTime.Now;

            //add the test item to list 
            TestList.Add(TestItem);
            //asssign the data to a property
            AllCar.CarList = TestList;
            //test to see two values are th esame
            Assert.AreEqual(AllCar.CarList, TestList);
        }

        [TestMethod]

        public void ThisCarPropertyOK()
        {
            clsCarCollection AllCar = new clsCarCollection();
            //test data 
            clsCar TestItem = new clsCar();
            TestItem.Make = "Tesla";
            TestItem.Model = "model";
            TestItem.Color = "Red";
            TestItem.Price = 1000;
            TestItem.Year = 2000;
            TestItem.PurchaseDate = DateTime.Now;


            AllCar.ThisCar = TestItem;

            
            //test to see two values are th esame
            Assert.AreEqual(AllCar.ThisCar, TestItem);
        }

        [TestMethod]

        public void ListandCountOK()
        {
            
            clsCarCollection AllCar = new clsCarCollection();


            //create some test data to assign to the property 
            //in this case a list 
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list 
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.Make = "Tesla";
            TestItem.Model = "model";
            TestItem.Color = "Red";
            TestItem.Price = 1000;
            TestItem.Year = 2000;
            TestItem.PurchaseDate = DateTime.Now;

            //add the test item to list 
            TestList.Add(TestItem);
            //asssign the data to a property
            AllCar.CarList = TestList;
            
           
            Assert.AreEqual(AllCar.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCarCollection AllCar = new clsCarCollection();
            //test data 
            clsCar TestItem = new clsCar();
            TestItem.Make = "Tesla";
            TestItem.Model = "model";
            TestItem.Color = "Red";
            TestItem.Price = 1000;
            TestItem.Year = 2000;
            TestItem.PurchaseDate = DateTime.Now;


            //asssign the data to a property
            AllCar.ThisCar = TestItem;
            //add record
            Int32 PrimaryKey = 0;
            PrimaryKey = AllCar.Add();
            //set the primary key to test data
            TestItem.VinNumber = PrimaryKey;
            //find the record
            AllCar.ThisCar.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllCar.ThisCar, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCar = new clsCarCollection();
            //create a new item for test data 
            clsCar TestItem = new clsCar();

            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its property 
            TestItem.VinNumber = 1;
            TestItem.Make = "Tesla";
            TestItem.Model = "model";
            TestItem.Color = "Red";
            TestItem.Price = 1000;
            TestItem.Year = 2000;
            TestItem.PurchaseDate = DateTime.Now;

            AllCar.ThisCar= TestItem;
            //add the record
            PrimaryKey = AllCar.Add();
            //set the primary key of the test data
            TestItem.VinNumber = PrimaryKey;
            //find the record
            AllCar.ThisCar.Find(PrimaryKey);
            //delete the record 
            AllCar.Delete();
            //now find the record
            Boolean Found = AllCar.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByModelMethodOK()
        {
            clsCarCollection AllCar = new clsCarCollection();
            clsCarCollection Filteredmodel = new clsCarCollection();
            Filteredmodel.ReportByModel("");
            Assert.AreEqual(AllCar.Count, Filteredmodel.Count);
        }

        [TestMethod]
        public void ReportBymodelNoneFound()
        {
            clsCarCollection AllCar = new clsCarCollection();
            clsCarCollection Filteredmodel = new clsCarCollection();
            Filteredmodel.ReportByModel("mnb");
            Assert.AreEqual(0, Filteredmodel.Count);
        }

        [TestMethod]
        public void FilterBymodelTestDataFound()
        {
            //create an instance of the class we want to create
            clsCarCollection Filteredmodel = new clsCarCollection();

            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //non-existing username
            Filteredmodel.ReportByModel("ggggg");

            //check the ucorrect is found
            if (Filteredmodel.Count == 2)
            {
                //checked to see that the first record is 2
                if (Filteredmodel.CarList[0].VinNumber != 2)
                {
                    OK = false;
                }
                if (Filteredmodel.CarList[1].VinNumber != 13)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
