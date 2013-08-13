using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clsDataLayer;

namespace WEB_460.Week6
{
    public partial class DeviceApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdFind_Click(object sender, EventArgs e)
        {
            clsDataLayer2 myDAL = new clsDataLayer2();
            dsAddress myAddressSet;
            // add your comment here
            myAddressSet = myDAL.FindAddress(Server.MapPath("Addressbook.mdb"), Convert.ToInt32(txtAddressID.Text));
            lblStatus.Text = String.Empty;
            // add your comment here
            if ((!(myAddressSet == null) && (myAddressSet.tblAddressBook.Rows.Count != 0)))
            {
                this.txtFirstName.Text = myAddressSet.tblAddressBook[0].FirstName;
                this.txtLastName.Text = myAddressSet.tblAddressBook[0].LastName;
                this.txtEmail.Text = myAddressSet.tblAddressBook[0].Email;
                this.txtPhoneNumber.Text = myAddressSet.tblAddressBook[0].PhoneNumber;
                Session["ValidRecord"] = true;
            }
            else
            {
                lblStatus.Text = "No record was found";
                Session["ValidRecord"] = false;
            }

        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            clsDataLayer2 myDAL = new clsDataLayer2();
            
            if ((bool) (Session["ValidRecord"] = true))
            {
                myDAL.UpdateAddress(Server.MapPath("Addressbook.mdb"), Convert.ToInt32(txtAddressID.Text), txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtEmail.Text);
            }
        }
    }
}