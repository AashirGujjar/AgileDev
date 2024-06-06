using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Check if the session variable is not null
            if (Session["UserName"] != null && Session["UserRole"] != null && Session["UserRole"].ToString() == "admin")
            {
                lblUserName.Text = Session["UserName"].ToString();
            }
            else
            {
                // If the session is null or the user is not admin, redirect to login page
                Response.Redirect("~/Login.aspx");
            }
        }
    }

    protected void btnManageUsers_Click(object sender, EventArgs e)
    {
        // Redirect to ManageUsers.aspx
        Response.Redirect("ManageUsers.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // End the user session
        Session.Clear();
        Session.Abandon();

        // Redirect to the login page
        Response.Redirect("~/Login.aspx");
    }
}