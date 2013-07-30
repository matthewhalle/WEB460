using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace clsBusinessLayer
{
    public class Class1
    {
        public static string SendEmail(string emailTo, string emailSubject, string emailMessage, string emailStatus)
        {
            MailMessage sendEmail = new MailMessage("halle.matthew@gmail.com", emailTo, emailSubject, emailMessage);
            //When method called then send email using host informtion
            SmtpClient SMTPServer = new SmtpClient("smtp.gmail.com", 587);
            //when sending information use this information for delivery
            SMTPServer.EnableSsl = true;
            SMTPServer.UseDefaultCredentials = false;
            SMTPServer.Credentials = new System.Net.NetworkCredential("matthew@gmail.com", "password");
            //above lines were needed to approve credentials to send email
            SMTPServer.Send(sendEmail);
            //send email
            return emailStatus;

            //remove try catch and move to SendBtn_Click
            //try
            //{
            //    SMTPServer.Send(sendEmail);
            //}
            //catch (Exception ex)
            //{
            //    return emailStatus = ex.ToString();
            //}
            //return emailStatus = "Email sent!";

        }

    }
}
