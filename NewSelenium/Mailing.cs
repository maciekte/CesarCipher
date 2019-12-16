using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Net.Mail;
using System.Net;


namespace NewSelenium
{
    [TestFixture]
    class Mailing
    {
        [Test]
        public void MethodToSendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();

                string FromEmail = "maciej.tobiasz@gmail.com";
                string Password = "Password";
                string ToEmail = "receiver_email";
                string Subject = "Test subject";
                string ContentBody = "Test selenium tutorial";

                mail.From = new MailAddress(FromEmail);
                mail.To.Add(ToEmail);
                mail.Subject = Subject;
                mail.Body = ContentBody;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.Credentials = new NetworkCredential(FromEmail, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);


            }
            finally
            {
                    
            }
        }

    }
}
