using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    static void Main(string[] args)
    {
        try
        {
            var accountSid = "ACc5c5ec44367bb75d732b16bcc85333b2";
            var authToken = "e2437a8ff34b591b8a9d53ad7f6e69bd";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
              new PhoneNumber("+919165516478"));
            messageOptions.From = new PhoneNumber("+18583975119");
            messageOptions.Body = "Hi Himanshu";


            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}