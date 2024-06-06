using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
   
        private ClsUsersCollection usersCollection = new ClsUsersCollection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if user is logged in and is admin
                if (Session["UserID"] == null || Session["UserRole"] == null || Session["UserRole"].ToString() != "admin")
                {
                    // If no user is logged in or user is not admin, redirect to login page
                    Response.Redirect("~/Login.aspx");
                }
                else
                {
                    LoadUsers();
                }
            }
        }

        private void LoadUsers()
        {
            GridViewUsers.DataSource = usersCollection.UsersList;
            GridViewUsers.DataBind();
        }

        protected void GridViewUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewUsers.EditIndex = e.NewEditIndex;
            LoadUsers();
        }

        protected void GridViewUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewUsers.EditIndex = -1;
            LoadUsers();
        }

        protected void GridViewUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userId = Convert.ToInt32(GridViewUsers.DataKeys[e.RowIndex].Value);
            GridViewRow row = GridViewUsers.Rows[e.RowIndex];

            ClsUser user = usersCollection.UsersList.FirstOrDefault(u => u.UserID == userId);
            if (user != null)
            {
                user.UserName = (row.Cells[1].Controls[0] as TextBox).Text;
                user.Password = (row.Cells[2].Controls[0] as TextBox).Text;
                user.Email = (row.Cells[3].Controls[0] as TextBox).Text;
                user.Role = (row.Cells[4].Controls[0] as TextBox).Text;
                user.IsActive = (row.Cells[5].Controls[0] as CheckBox).Checked;

                usersCollection.ThisUser = user;
                usersCollection.Update();
            }

            GridViewUsers.EditIndex = -1;
            LoadUsers();
        }

        protected void GridViewUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(GridViewUsers.DataKeys[e.RowIndex].Value);

            usersCollection.Delete(userId);
            LoadUsers();
        }

        protected void BtnAddUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AddUser.aspx");
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            // Clear the session
            Session.Clear();
            // Redirect to login page
            Response.Redirect("~/Login.aspx");
        }
    }
