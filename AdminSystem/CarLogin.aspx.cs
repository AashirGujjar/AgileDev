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
        clsSUPuser Anuser = new clsSUPuser();
        string Username = txtusername.Text;
        string password = txtpassword.Text;
        Boolean Found = false;
        Username = Convert.ToString(txtusername.Text);
        password = Convert.ToString(txtpassword.Text);


        Found = Anuser.FindUser(Username, password);

        Session["AnUser"] = Anuser;
        if (txtusername.Text == "")
        {
            lblError.Text = "Enter User Name";
        }

        else if (txtpassword.Text == "")
        {
            lblError.Text = "Enter password";
        }
        else if (Found == true)
        {
            Response.Redirect("CarList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login Details are Not correct. Try Again!";
        }
    }
}