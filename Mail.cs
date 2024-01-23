using ConsoleAPp;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPp
{
    public  class Mail
    {
        public static Tuple<bool, string> SendEMail()
        {
            try
            {
               
                 
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("ramanathan@datanetiix.com");
                    mail.To.Add("yuvan@datanetiix.com");
                    mail.Subject = "  Email Test  ";
                    mail.Body = "<h1> This Is The Test Message </h1>";
                    mail.IsBodyHtml = true;
                   
                    
                    using (SmtpClient smtp = new SmtpClient("smtp.office365.com", 587))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("ramanathan@datanetiix.com", "Chinn@2000");
                        smtp.EnableSsl = true;
                     
                        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                        smtp.Send(mail);
                        
                    }
                }
            
                return Tuple.Create(true, "Email Sent Successfully.");

            }
                    catch (Exception ex)
            {
                var msg = ex.Message;
                return Tuple.Create(false, msg);
            }
        }
    }
}

