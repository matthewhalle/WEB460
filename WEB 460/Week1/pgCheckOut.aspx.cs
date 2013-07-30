using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_460.Week1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submitbtn_Click(object sender, EventArgs e)
        {

        }
        public string FirstName
        {
            get { return FirstNameTextBox.Text; }
        }
        public string LastName
        {
            get { return LastNameTextBox.Text; }
        }
        public string Address1
        {
            get { return Addresstextbox.Text; }
        }
        public string Address2
        {
            get { return Addresstextbox2.Text; }
        }
        public string City
        {
            get { return Citytextbox.Text; }
        }
        public string State
        {
            get { return Statetextbox.Text; }
        }
        public string Phone
        {
            get { return PhoneNumtextbox.Text; }
        }
        public string CardType
        {
            get { return RadioButtonList2.Text; }
        }
        public string CardNum
        {
            get { return Credittextbox.Text; }
        }
    }
}