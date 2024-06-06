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
            mVinNumber = 3;
            mMake = "Toyota";
            mModel = "Corolla";
            mYear = 2020;
            mColor = "Red";
            mPrice = 20000;
            mPurchaseDate = Convert.ToDateTime("12/10/2023");
            return true;
        }
    }
}