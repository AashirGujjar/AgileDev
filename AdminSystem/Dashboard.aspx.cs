using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Check if the session variable is not null
            if (Session["UserName"] != null)
            {
                lblUserName.Text = Session["UserName"].ToString();
            }
            else
            {
                // If the session is null, redirect to login page
                Response.Redirect("Login.aspx");
            }
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // End the user session
        Session.Clear();
        Session.Abandon();

        // Redirect to the login page
        Response.Redirect("Login.aspx");
    }
}
