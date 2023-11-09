using DataBaseAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace EmailHelper
{
    public class EmailNotification
    {
        public void SendEmail(ContactUsModel data)
        {
            string Contact_Name = data.Contact_Name;
            string Contact_Email = data.Contact_Email;

            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("BridgeWayLogistic", "BridgeWayLogistic@gmail.com"));
            email.To.Add(new MailboxAddress(Contact_Name, Contact_Email));

            email.Subject = "BridgeWayLogistic";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = "Hello " + Contact_Name + " Thank you for contacting us, we will get back to you as soon as possible."
        };
            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate("himanshugupta2308@gmail.com", "gqtw ffez flrc rnoj");

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}
