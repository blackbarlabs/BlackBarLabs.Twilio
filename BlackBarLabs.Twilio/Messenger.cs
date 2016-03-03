using BlackBarLabs.Twilio.Exceptions;
using Twilio;

namespace BlackBarLabs.Twilio
{
    public class Messenger //: Web.ISendSmsService
    {
        private readonly string accountSid;
        private readonly string authToken;

        public Messenger(string accountSid, string authToken)
        {
            this.accountSid = accountSid;
            this.authToken = authToken;
        }

        public bool SendSmsMessage(string fromNumber, string toNumber, string text)
        {
            var twilio = new TwilioRestClient(accountSid, authToken);
            var message = twilio.SendMessage(fromNumber, toNumber, text);

            if (message.RestException != null)
            {
                var error = message.RestException.Message;
                if (message.RestException.Status == "400")
                {
                    if (message.RestException.Code == "21608")
                        throw new UnverifiedPhoneNumberException(message.RestException.Message);
                    if (message.RestException.Code == "21211")
                        throw new InvalidPhoneNumberException(message.RestException.Message);
                }
                if (message.RestException.Status == "401")
                    throw new SmsUnauthorizedException(message.RestException.Message);
                return false;
            }
            return true;
        }
    }
}
