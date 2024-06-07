using System;

namespace ClassLibrary
{
    public class clsSUPuser
    {
        private string mDepartment;
        private int mUserID;
        private string mPassword;
        private string mUserName;


        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }

        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }


        public bool FindUser(string userName, string password)
        {
            //create a instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the E_Id to search for 
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");

            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);

                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);

                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);


                //return that everything worked OK

                return true;
            }
            else
            {
                //return false indicating an problem 
                return false;
            }
        }
    }
}
