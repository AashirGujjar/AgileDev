using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manageccount : System.Web.UI.Page
{
    private ClsUsersCollection usersCollection = new ClsUsersCollection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Check if the session variable is not null
            if (Session["UserID"] != null)
            {
                LoadUserData();
            }
            else
            {
                // If the session is null, redirect to login page
                Response.Redirect("Login.aspx");
            }
        }
    }

    private void LoadUserData()
    {
        int userId = Convert.ToInt32(Session["UserID"]);
        var user = usersCollection.UsersList.Where(u => u.UserID == userId).ToList();
        GridViewAccount.DataSource = user;
        GridViewAccount.DataBind();
    }

    protected void GridViewAccount_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewAccount.EditIndex = e.NewEditIndex;
        LoadUserData();
    }

    protected void GridViewAccount_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridViewAccount.EditIndex = -1;
        LoadUserData();
    }

    protected void GridViewAccount_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int userId = Convert.ToInt32(GridViewAccount.DataKeys[e.RowIndex].Value);
        GridViewRow row = GridViewAccount.Rows[e.RowIndex];

        ClsUser user = usersCollection.UsersList.FirstOrDefault(u => u.UserID == userId);
        if (user != null)
        {
            user.UserName = (row.Cells[0].Controls[0] as TextBox).Text;
            user.Email = (row.Cells[1].Controls[0] as TextBox).Text;
            user.Password = (row.Cells[2].Controls[0] as TextBox).Text;
            usersCollection.ThisUser = user;
            usersCollection.Update();
        }

        GridViewAccount.EditIndex = -1;
        LoadUserData();
    }

    protected void btnDeleteAccount_Click(object sender, EventArgs e)
    {
        int userId = Convert.ToInt32(Session["UserID"]);
        usersCollection.Delete(userId);
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Login.aspx");
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