using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack==false)
        {
            DisplayModel();

        }
    }
    void DisplayModel()
    {
        clsCarCollection Cars = new clsCarCollection();
        lstModelList.DataSource= Cars.CarList;
        lstModelList.DataValueField = "vinNumber";
        lstModelList.DataTextField = "model";
        lstModelList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["vinNumber"] = -1;
        //refirect to datatentry page
        Response.Redirect("CarDataEntry.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //primary key variable stored 
        Int32 vinNumber;
        //if a record has been selected fromt the list 
        if (lstModelList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            vinNumber = Convert.ToInt32(lstModelList.SelectedValue);
            //store the data in the session
            Session["vinNumber"] = vinNumber;
            //redirect to the edit page
            Response.Redirect("CarDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //primary key variable stored 
        Int32 vinNumber;
        //if a record has been selected fromt the list 
        if (lstModelList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            vinNumber = Convert.ToInt32(lstModelList.SelectedValue);
            //store the data in the session
            Session["vinNumber"] = vinNumber;
            //redirect to the edit page
            Response.Redirect("CarConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        clsCarCollection AllCar = new clsCarCollection();

        AllCar.ReportByModel(txtFilter.Text);
        lstModelList.DataSource = AllCar.CarList;
        //set the name for primary key
        lstModelList.DataValueField = "vinNumber";
        lstModelList.DataTextField = "model";
        lstModelList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCarCollection AllCar = new clsCarCollection();

        AllCar.ReportByModel("");
        txtFilter.Text = "";
        lstModelList.DataSource = AllCar.CarList;
       
        lstModelList.DataValueField = "vinNumber";
        lstModelList.DataTextField = "model";
        lstModelList.DataBind();
       
    }
    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}