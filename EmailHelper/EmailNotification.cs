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
        public void SendEmailContact(ContactUsModel data)
        {
            string Contact_Name = data.Contact_Name;
            string Contact_Email = data.Contact_Email;

            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("BridgeWayLogistic", "bridgewaylogistics23@gmail.com"));
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
                smtp.Authenticate("bridgewaylogistics23@gmail.com", "yxun vxph rjee qyqa");

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
        public void SendEmailEnquiry(EnquiryModel data)
        {
            string Enquiry_Name = data.Enquiry_Name;
            string Enquiry_Email = data.Enquiry_Email;

            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("BridgeWayLogistic", "bridgewaylogistics23@gmail.com"));
            email.To.Add(new MailboxAddress(Enquiry_Name, Enquiry_Email));

            email.Subject = "BridgeWayLogistic";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = "Hello " + Enquiry_Name + " Thank you for your interest in our services, your enquiry has been submitted, we will get back to you as soon as possible."
            };
            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate("bridgewaylogistics23@gmail.com", "yxun vxph rjee qyqa");

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}
