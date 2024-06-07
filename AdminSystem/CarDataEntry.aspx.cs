using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 vinNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        vinNumber = Convert.ToInt32(Session["vinNumber"]);

        if (IsPostBack == false)
        {
            if(vinNumber!=-1)
            {
                DisplayModel();
            }
        }
    }
    void DisplayModel()
    {
      
        clsCarCollection AllCar = new clsCarCollection();
        //find record to update 
        AllCar.ThisCar.Find(vinNumber);
        //display the data for the record
        txtvinNum.Text = AllCar.ThisCar.VinNumber.ToString();
        txtMake.Text = AllCar.ThisCar.Make;
        txtModel.Text = AllCar.ThisCar.Model ;
        txtColor.Text = AllCar.ThisCar.Color;
        txtYear.Text = AllCar.ThisCar.Year.ToString();
        txtPrice.Text = AllCar.ThisCar.Price.ToString();
        txtPurchaseDate.Text = AllCar.ThisCar.PurchaseDate.ToString();
        
       
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCar ACar = new clsCar();
        string make = txtMake.Text;
        string model = txtModel.Text;
        string color = txtColor.Text;
        string price = txtPrice.Text;   
        string year = txtYear.Text;
        string purchaseDate = txtPurchaseDate.Text;
        string Error = "";
        Error = ACar.Valid(make, model, year, color, price, purchaseDate);


        if (Error == "")
        {
            ACar.VinNumber = vinNumber;
            ACar.Make = make;
            ACar.Model = model;
            ACar.Color = color;
            ACar.Year = Convert.ToInt32(year);
            ACar.Price = Convert.ToInt32(price);
            ACar.PurchaseDate = Convert.ToDateTime(purchaseDate);
            Session["ACar"] = ACar;

            clsCarCollection carList = new clsCarCollection();
           
            //if this is a new record
            if (vinNumber == -1)
            {
                //set the thisregister property
                carList.ThisCar = ACar;
                //add the new record
                carList.Add();
            }

            //otherwise it must be update
            else
            {
                //find the record to update
                carList.ThisCar.Find(vinNumber);
                
                carList.ThisCar = ACar;
                //update the record
                carList.Update();

            }


            Response.Redirect("CarList.aspx");
        }
        else
        {
            //displaying error
            lblError.Text = Error;
        }


        



    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CarList.aspx");
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