using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 vinNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        vinNumber = Convert.ToInt32(Session["vinNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCarCollection AllCar = new clsCarCollection();
        AllCar.ThisCar.Find(vinNumber);
        AllCar.Delete();
        Response.Redirect("CarList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CarList.aspx");
    }
}