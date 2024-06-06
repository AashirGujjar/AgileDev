using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsUser
    {
        // Private data members
        private int mUserID;
        private string mUserName;
        private string mPassword;
        private string mEmail;
        private string mRole = "user";
        private bool mIsActive = true;

        // Public properties
        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public string Role
        {
            get { return mRole; }
            set { mRole = value; }
        }

        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        // Find method for user by UserID
        public bool Find(int userID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", userID);
            DB.Execute("sproc_tblUser_FindByUserID");

            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Valid method
        public string Valid(string userName, string password, string email, string role)
        {
            // Create a string variable to store the error
            string Error = "";

            // Validation rules

            // UserName cannot be blank
            if (userName.Length == 0)
            {
                Error += "The user name may not be blank. ";
            }
            // UserName must be less than 50 characters
            if (userName.Length > 50)
            {
                Error += "The user name must be less than 50 characters. ";
            }

            // Password cannot be blank
            if (password.Length == 0)
            {
                Error += "The password may not be blank. ";
            }
            // Password must be less than 50 characters
            if (password.Length > 50)
            {
                Error += "The password must be less than 50 characters. ";
            }

            // Email cannot be blank
            if (email.Length == 0)
            {
                Error += "The email may not be blank. ";
            }
            // Email must be less than 100 characters
            if (email.Length > 100)
            {
                Error += "The email must be less than 100 characters. ";
            }
            // Email must be in a valid format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Error += "The email format is not valid. ";
            }

            // Role cannot be blank
            if (role.Length == 0)
            {
                Error += "The role may not be blank. ";
            }
            // Role must be less than 20 characters
            if (role.Length > 20)
            {
                Error += "The role must be less than 20 characters. ";
            }

            // Return any error messages
            return Error;
        }
    }
}