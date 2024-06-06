using System;

namespace ClassLibrary
{
    public class clsCar
    {
        // Private fields
        private Int32 mVinNumber;
        private string mMake;
        private string mModel;
        private int mYear;
        private string mColor;
        private int mPrice;
        private DateTime mPurchaseDate;

        // Public properties
        public int VinNumber
        {
            get { return mVinNumber; }
            set { mVinNumber = value; }
        }

        public string Make
        {
            get { return mMake; }
            set { mMake = value; }
        }

        public string Model
        {
            get { return mModel; }
            set { mModel = value; }
        }

        public int Year
        {
            get { return mYear; }
            set { mYear = value; }
        }

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public int Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public DateTime PurchaseDate
        {
            get { return mPurchaseDate; }
            set { mPurchaseDate = value; }
        }

        public bool Find(int vinNumber)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the vinNumber to search for
            DB.AddParameter("@VinNumber", vinNumber);
            // Execute the stored procedure
            DB.Execute("sproc_Cars_FindByvinNumber");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Set the private fields
                mVinNumber = Convert.ToInt32(DB.DataTable.Rows[0]["vinNumber"]);
                mMake = Convert.ToString(DB.DataTable.Rows[0]["make"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["model"]);
                mYear = Convert.ToInt32(DB.DataTable.Rows[0]["year"]);
                mColor = Convert.ToString(DB.DataTable.Rows[0]["color"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["price"]);
                mPurchaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["purchaseDate"]);

                // Return that everything worked OK
                return true;
            }
            else
            {
                // Return false indicating a problem
                return false;
            }
        }
    }
}