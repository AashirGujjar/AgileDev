using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the car class
        clsCar aCar = new clsCar();
        // Create a variable to store the primary key
        Int32 vinNumber;

        // Create a variable to store the result of the find operation
        Boolean found = false;

        // Get the primary key entered by the user
        vinNumber = Convert.ToInt32(txtvinNum.Text);

        // Find the record
        found = aCar.Find(vinNumber);

        // If found
        if (found == true)
        {
            // Display the values of the property in the form
            txtMake.Text = aCar.Make;
            txtModel.Text = aCar.Model;
            txtYear.Text = aCar.Year.ToString();
            txtColor.Text = aCar.Color;
            txtPrice.Text = aCar.Price.ToString();
            txtPurchaseDate.Text = aCar.PurchaseDate.ToShortDateString();
        }
    }
}