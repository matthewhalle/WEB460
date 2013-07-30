using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clsDataLayer;

namespace WEB_460.Week4
{
    public partial class frmAddressBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!Page.IsPostBack))
            {
                //dsAddress addressSet = default(dsAddress);
                var addressSet = new dsAddress();
                addressSet = BindGridView();

                // Dusplay the content of the first record retrieved in the corresponding textboxes
                txtFirstName.Text = addressSet.tblAddressBook[0].FirstName;
                txtLastName.Text = addressSet.tblAddressBook[0].LastName;
                txtEmail.Text = addressSet.tblAddressBook[0].Email;
                txtPhoneNumber.Text = addressSet.tblAddressBook[0].PhoneNumber;

            }


        }
        private dsAddress BindGridView()
        {
            // upon calling this function bind gridview to this DB

            string TempPath = Server.MapPath("~/Week4/AddressBook.mdb");

            // establish variables of data sets and DB

            var myAddressSet = new dsAddress();

            var oDataLayer = new clsDataLayer2();

            // call the a function to retrieve contents of DB

            myAddressSet = oDataLayer.GetAllAddresses(TempPath);

            // establish what table we are retrieving

            gvAddresses.DataSource = myAddressSet.tblAddressBook;

            // Bind to gridview and return data to be viewed

            gvAddresses.DataBind();

            return myAddressSet;



        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string TempPath = Server.MapPath("~/Week4/AddressBook.mdb");

            var myDataLayer = new clsDataLayer2();

            // upon button click create new instance of data set and send variables to the insert address function to update the DB then return to update displayed gridview

            myDataLayer.InsertAddress(TempPath, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNumber.Text);

            BindGridView();
        }
    }
}