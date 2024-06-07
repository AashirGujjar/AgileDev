using System;
using System.Collections.Generic;

namespace ClassLibrary
    
{
    public class clsCarCollection
{
        List<clsCar> mCarList = new List<clsCar>();
        clsCar mThisCar = new clsCar();
        public clsCarCollection()
        {
            //onject for data connection
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCars_SelectAll");
            populateArray(DB);
        }
        void populateArray(clsDataConnection DB)
        {
            //populate the array list based on the datat table in the parameter DB

            //variable for the index
            Int32 Index = 0;

            //varible to store the record count 
            Int32 RecordCount;
            RecordCount = DB.Count;
            //clear private array list
            mCarList = new List<clsCar>();
            //while there are record to process
            while (Index < RecordCount)
            {
                clsCar Acar = new clsCar();
                Acar.VinNumber=  Convert.ToInt32(DB.DataTable.Rows[Index]["vinNumber"]);
                Acar.Make = Convert.ToString(DB.DataTable.Rows[Index]["make"]);
                Acar.Model = Convert.ToString(DB.DataTable.Rows[Index]["model"]);
                Acar.Color = Convert.ToString(DB.DataTable.Rows[Index]["color"]);
                Acar.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["price"]);
                Acar.Year = Convert.ToInt32(DB.DataTable.Rows[Index]["year"]);
                Acar.PurchaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["purchasedate"]);

                //add the record to private data memnber 
                mCarList.Add(Acar);
                //point to next record
                Index++;
            }

        }

       
        public List<clsCar> CarList
        {
            get { return mCarList; }
            set { mCarList = value; }
        }

        public clsCar ThisCar
        {
            get { return mThisCar; }
            set { mThisCar = value; }
        }

        public int Count
        {
            get { return mCarList.Count; }
            set {  }
        }
        public int Add()
        {
            ///connect to DB
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("make", mThisCar.Make);
            DB.AddParameter("model", mThisCar.Model);
            DB.AddParameter("color", mThisCar.Color);
            DB.AddParameter("year", mThisCar.Year);
            DB.AddParameter("price", mThisCar.Price);
            DB.AddParameter("purchasedate", mThisCar.PurchaseDate);

            //execute the query returning the primary key
            return DB.Execute("sproc_tblCars_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@vinNumber", mThisCar.VinNumber);
            DB.Execute("sproc_tblCar_Delete");
        }

       

        public void Update()
        {
            ///connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters sfor stored procedure
            DB.AddParameter("@vinNumber", mThisCar.VinNumber);
            DB.AddParameter("make", mThisCar.Make);
            DB.AddParameter("model", mThisCar.Model);
            DB.AddParameter("color", mThisCar.Color);
            DB.AddParameter("year", mThisCar.Year);
            DB.AddParameter("price", mThisCar.Price);
            DB.AddParameter("purchasedate", mThisCar.PurchaseDate);

            //execute the query returning the primary key
            DB.Execute("sproc_tblCar_Update");
        }

        public void ReportByModel(string model)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@model", model);
            DB.Execute("sproc_tblCars_FilteredByModel");
            populateArray(DB);
        }
    }
}