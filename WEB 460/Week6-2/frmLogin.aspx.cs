using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using clsDataLayer;

namespace WEB_460.Week6_2
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool IsFound = clsDataLayer2.GetUser(Server.MapPath("AddressBook.mdb"), txtUserID.Text, txtPassword.Text);
            if (IsFound == true) 
            {
                // user credentials were found in the database so notify the system that the user is authenticated
                // add the redirect to week 5 form page
                System.Web.Security.FormsAuthentication.SetAuthCookie(txtUserID.Text, false);
                lblStatus.Text = "Login Successfull";
                Response.Redirect("~/Week5/frmEmployees.aspx");
            }
           
            else {
                // invalid user credentials
                int myAttempts = clsDataLayer2.LoginAttempts(Server.MapPath("AddressBook.mdb"), txtUserID.Text);
                // return the false attempts by user
                // update the session variable with the new value
                lblStatus.Text = "The User ID and/or Password supplied is incorrect. Please try again!";
                if (myAttempts >= 3)
                {
                    clsDataLayer2.LockAccount(Server.MapPath("AddressBook.mdb"), txtUserID.Text);
                    // return if 3 or more false attempts have been made upon a user
                    lblStatus.Text = "Your account has been locked and will need to be reset by the system  administrator!";
                }
            }
        }
    }
}