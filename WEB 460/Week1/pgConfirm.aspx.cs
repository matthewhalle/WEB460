using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_460.Week1
{
    public partial class pgConfirm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Namelbl.Text = PreviousPage.FirstName + " " + PreviousPage.LastName;
            }
            catch (Exception ex)
            {

                Statuslbl.Text = ex.ToString();
            }
            try
            {
                Addresslbl.Text = PreviousPage.Address1 + " " + PreviousPage.Address2;
            }
            catch (Exception ex)
            {

                Statuslbl.Text = ex.ToString();
            }
            try
            {
                CreditCardTypelbl.Text = PreviousPage.CardType;
            }
            catch (Exception ex)
            {

                Statuslbl.Text = ex.ToString();
            }
            try
            {
                CreditCardNumlbl.Text = PreviousPage.CardNum;
            }
            catch (Exception ex)
            {

                Statuslbl.Text = ex.ToString();
            }
        }

        protected void SubmitOrderbtn_Click(object sender, EventArgs e)
        {
            Statuslbl.Text = "Order Submitted successfully!";
        }
    }
}