using DataBaseAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMSHelper
{
    public class SMSNotification
    {
        public void SendSMSContact(ContactUsModel data)
        {
            try
            {
                var accountSid = "AC5263205a522408b40e9e42e6406952df";
                var authToken = "35636e7e5838e8b3204c0665c8547f9a";
                TwilioClient.Init(accountSid, authToken);

                string Contact_Phone = data.Contact_Phone;
                var messageOptions = new CreateMessageOptions(
                  new PhoneNumber("+91"+Contact_Phone));
                messageOptions.From = new PhoneNumber("+12029465215");

                string Contact_Name = data.Contact_Name;
                messageOptions.Body = "Hello "+ Contact_Name +" Thank you for contacting us, we will get back to you as soon as possible.";

                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void SendSMSEnquiry(EnquiryModel data)
        {
            try
            {
                var accountSid = "AC5263205a522408b40e9e42e6406952df";
                var authToken = "35636e7e5838e8b3204c0665c8547f9a";
                TwilioClient.Init(accountSid, authToken);

                string Enquiry_Phone = data.Enquiry_Phone.ToString();
                var messageOptions = new CreateMessageOptions(
                  new PhoneNumber("+91" + Enquiry_Phone));
                messageOptions.From = new PhoneNumber("+12029465215");

                string Enquiry_Name = data.Enquiry_Name;
                messageOptions.Body = "Hello " + Enquiry_Name + " Thank you for your interest in our services, your enquiry has been submitted, we will get back to you as soon as possible.";

                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
