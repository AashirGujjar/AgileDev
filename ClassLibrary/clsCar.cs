using System;
using System.Xml.Linq;

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

        public string Valid(string make, string model, string year, string color, string price, string purchaseDate)
        {
            String Error = "";

            //temperory variable for data values
          


            //for make
            if (make.Length == 0)
            {
                //record the error
                Error += "Company Name cannot be blank";
            }

           

            if (make.Length > 50)
            {
                Error += "Company Name cannot be longer than 50 characters:";
            }

            //for model
            if (model.Length == 0)
            {
                //record the error
                Error += "Company Name cannot be blank";
            }



            if (model.Length > 50)
            {
                Error += "Company Name cannot be longer than 50 characters:";
            }

            if (color.Length == 0)
            {
                //record the error
                Error += "Color cannot be blank";
            }

            if (color.Length > 50)
            {
                Error += "Color cannot be longer than 50 characters:";
            }

            // Validate Price
            int priceValue;
            if (!int.TryParse(price, out priceValue))
            {
                Error += "Price must be a valid integer number. ";
            }
            else
            {
                if (priceValue < 0)
                {
                    Error += "Price cannot be negative. ";
                }
                if (priceValue > 10000000)
                {
                    Error += "Price cannot exceed 10 million. ";
                }
            }
            try
            {
                DateTime purchaseDateValue = Convert.ToDateTime(purchaseDate);

                // Get the current date
               
                DateTime currentDate = DateTime.Now.Date;
                 DateTime currentYear = currentDate.AddYears(-100);
                // Check if the purchase date is in the past
                if (purchaseDateValue < currentYear)
                {
                    Error += "The purchase date cannot before 100 years. ";
                }

                // Check if the purchase date is in the future
                if (purchaseDateValue > currentDate)
                {
                    Error += "The purchase date cannot be in the future. ";
                }
            }
            catch
            {
                Error += "The purchase date was not a valid date. ";
            }
            try
            {
                int yearValue = Convert.ToInt32(year);

                int currentYear = DateTime.Now.Year;

                // Check if the year is within the last 100 years
                if (yearValue < currentYear - 100)
                {
                    Error += "The year cannot be more than 100 years in the past. ";
                }

                // Check if the year is in the future
                if (yearValue > currentYear)
                {
                    Error += "The year cannot be in the future. ";
                }
            }
            catch
            {
                Error += "The year was not a valid year. ";
            }
            // Validate Color
            if (string.IsNullOrEmpty(color))
            {
                Error += "Color cannot be blank. ";
            }
            else if (color.Length > 50)
            {
                Error += "Color cannot exceed 100 characters. ";
            }


            return Error;

        }
    }
}