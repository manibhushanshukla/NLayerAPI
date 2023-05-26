using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Common.EmailService
{
    public class EmailService
    {
        public static async Task SendEmailWithLink(string emailAddress, string link)
        {
            var email = new MailMessage();
            email.To.Add(new MailAddress(emailAddress));
            email.Subject = "Create your login password";
            email.Body = $"Please click on this link to create your login password: {link}";
            email.From = new MailAddress("vijaypat8959@gmail.com");


            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("vijaypat8959@gmail.com", "ztnfqpxxbluzqvia");
                smtp.EnableSsl = true;

                await smtp.SendMailAsync(email);
            }
        }
    }
}
