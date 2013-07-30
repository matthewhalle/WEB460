using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clsWebServices2;


namespace WEB_460.Week3
{
    public partial class frmAddressBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFindLastName_Click(object sender, EventArgs e)
        {
            try {
                // create new instance of web service 
                Service1 serviceObj =new Service1();

		        // new instance of web service to be created

		        dsAddress dsFindLastName = new dsAddress();

                string TempPath = Server.MapPath("AddressBook.accdb");
                
		        // path to access the database

		        dsFindLastName = serviceObj.FindAddress(txtFindLastName.Text, TempPath);

		        //run the method in the in web service then return


		        if (dsFindLastName.tblAddressBook.Rows.Count > 0)
		        {
		            
			        // on the return query then fill each text box with results 
                    
		            txtFirstName.Text = dsFindLastName.tblAddressBook[0].FirstName;

		            txtLastName.Text = dsFindLastName.tblAddressBook[0].LastName;

		            txtEmail.Text = dsFindLastName.tblAddressBook[0].Email;

		            txtPhoneNumber.Text = dsFindLastName.tblAddressBook[0].PhoneNumber;


		        } else {
			        lblMessage.Text = "No records were found!!";

		        }

	            } catch (Exception ex) {
		            // if unable to return then return error message

		            lblMessage.Text = ex.Message;

	            }


        }
    }
}