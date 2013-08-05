using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using clsBusinessLayer;

namespace WEB_460.Week2
{
    public partial class pgEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                clsBusinessLayer.Class1.SendEmail(ToTextBox.Text, SubjectTextBox.Text, MessageTextBox.Text, StatusLbl.Text);
                //Apply method within the clsBusinessLayer
            }
            catch (Exception ex)
            {
                StatusLbl.Text = "An error has happened sending the email, " + ex.ToString();
                //If error return exception data to help resolve for troubleshooting 
                //use of ex.Message vs ex.ToString, the ex.ToString will give better insight into error
                //http://stackoverflow.com/questions/2176707/net-ex-message-vs-ex-tostring
                
            }
            StatusLbl.Text = "The message was sent successfully to: " + ToTextBox.Text;
            //If no errors then report no errors and who the email was send to
            //StatusLbl.Text = clsBusinessLayer.Class1.SendEmail(ToTextBox.Text, SubjectTextBox.Text, MessageTextBox.Text, StatusLbl.Text);
            //insert try catch statement to match iLab instructions
            
        }
        //I first as concept setup locally within the local page
        //commented out once moved code to DLL
        //private string SendEmail(string emailTo, string emailSubject, string emailMessage, string emailStatus)
        //{
        //    MailMessage sendEmail = new MailMessage("halle.matthew@gmail.com", emailTo, emailSubject,emailMessage);
        //    SmtpClient SMTPServer = new SmtpClient("smtp.gmail.com", 587);
        //    SMTPServer.EnableSsl = true;
        //    SMTPServer.UseDefaultCredentials = false;
        //    SMTPServer.Credentials = new System.Net.NetworkCredential("matthew@gmail.com", "password");
            

        //    try
        //    {
        //        SMTPServer.Send(sendEmail);
        //    }
        //    catch (Exception ex)
        //    {
        //        return emailStatus = ex.ToString();
        //    }
        //    return emailStatus = "Email sent!";
        //}

    }
}
