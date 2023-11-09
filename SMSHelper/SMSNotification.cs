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
        public void SendSMS(ContactUsModel data)
        {
            try
            {
                var accountSid = "ACc5c5ec44367bb75d732b16bcc85333b2";
                var authToken = "20d5ee445979936b58ee2ac2e02d11ed";
                TwilioClient.Init(accountSid, authToken);

                string Contact_Phone = data.Contact_Phone;
                var messageOptions = new CreateMessageOptions(
                  new PhoneNumber("+91"+Contact_Phone));
                messageOptions.From = new PhoneNumber("+18583975119");

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
    }
}
