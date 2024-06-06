using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        ClsUsersCollection usersCollection = new ClsUsersCollection();
        ClsUser newUser = new ClsUser
        {
            UserName = txtUserName.Text,
            Password = txtPassword.Text,
            Email = txtEmail.Text,
            
            IsActive = true
        };

        string validationMessage = newUser.Valid(newUser.UserName, newUser.Password, newUser.Email, newUser.Role);
        if (string.IsNullOrEmpty(validationMessage))
        {
            usersCollection.ThisUser = newUser;
            int userId = usersCollection.Add();

            if (userId != -1)
            {
                lblMessage.Text = "User registered successfully!";
            }
            else
            {
                lblMessage.Text = "An error occurred while registering the user.";
            }
        }
        else
        {
            lblMessage.Text = validationMessage;
        }
    }
}
