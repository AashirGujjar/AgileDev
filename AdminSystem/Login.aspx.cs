using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string password = txtPassword.Text;

        ClsUsersCollection usersCollection = new ClsUsersCollection();
        ClsUser user = usersCollection.GetByEmail(email);

        if (user != null && user.Password == password)
        {
            if (user.IsActive)
            {
                // Start user session
                Session["UserID"] = user.UserID;
                Session["UserName"] = user.UserName;
                Session["UserRole"] = user.Role;

                // Redirect based on user role
                if (user.Role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    Response.Redirect("~/Admin/Admin.aspx");
                }
                else
                {
                    Response.Redirect("Dashboard.aspx");
                }
            }
            else
            {
                lblMessage.Text = "Your account is inactive. Please contact support.";
            }
        }
        else
        {
            lblMessage.Text = "Invalid email or password.";
        }
    }
}
