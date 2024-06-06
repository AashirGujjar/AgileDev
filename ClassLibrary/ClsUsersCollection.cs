using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsUsersCollection
    {
        // Private data member for the list
        private List<ClsUser> mUsersList = new List<ClsUser>();
        // Private data member for ThisUser
        private ClsUser mThisUser = new ClsUser();

        // Public property for the UsersList
        public List<ClsUser> UsersList
        {
            get { return mUsersList; }
            set { mUsersList = value; }
        }

        // Public property for Count
        public int Count
        {
            get { return mUsersList.Count; }
        }

        // Public property for ThisUser
        public ClsUser ThisUser
        {
            get { return mThisUser; }
            set { mThisUser = value; }
        }

        // Constructor for the class
        public ClsUsersCollection()
        {
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure to get all users
            DB.Execute("sproc_tblUser_SelectAll");
            // Populate the list with the data table
            PopulateArray(DB);
        }

        // Method to populate the list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            // Populate the list based on the table in the database
            int Index = 0;
            int RecordCount = DB.Count;
            mUsersList = new List<ClsUser>();
            while (Index < RecordCount)
            {
                ClsUser AUser = new ClsUser();
                AUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AUser.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AUser.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AUser.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AUser.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AUser.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                mUsersList.Add(AUser);
                Index++;
            }
        }

        public bool IsEmailRegistered(string email)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Email", email);
            DB.Execute("sproc_tblUser_FindByEmail");
            return DB.Count == 1;
        }

        public int Add()
        {
            // Add a new record to the database based on the values of mThisUser
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Role", mThisUser.Role);
            DB.AddParameter("@IsActive", mThisUser.IsActive);
            // Execute the query
            DB.Execute("sproc_tblUser_Insert");

            // Check if a new row has been added and return the new UserID
            if (DB.Count == 1)
            {
                return Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
            }
            else
            {
                return -1; // Indicate failure
            }
        }

        // Method to retrieve a user by email
        public ClsUser GetByEmail(string email)
        {
            // Optional: Perform any email validation here

            // Search for the user in the UsersList by email
            return UsersList.FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public void Delete(int userID)
        {
            // Delete a record from the database based on the UserID
            clsDataConnection DB = new clsDataConnection();
            // Set the parameter for the stored procedure
            DB.AddParameter("@UserID", userID);
            // Execute the stored procedure
            DB.Execute("sproc_tblUser_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserID", mThisUser.UserID);
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Role", mThisUser.Role);
            DB.AddParameter("@IsActive", mThisUser.IsActive);
            DB.Execute("sproc_tblUser_Update");
        }
    }
}