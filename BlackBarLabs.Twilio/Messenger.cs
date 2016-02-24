using Twilio;

namespace BlackBarLabs.Twilio
{
    public class Messenger : Web.ISendSmsService
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
                // handle the error ...
            }
            return true;
        }
    }
}
