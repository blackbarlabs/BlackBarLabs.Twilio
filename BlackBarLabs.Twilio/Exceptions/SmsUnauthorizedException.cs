using System;

namespace BlackBarLabs.Twilio.Exceptions
{
    public class SmsUnauthorizedException : Exception
    {
        public SmsUnauthorizedException(string message)
            : base(message)
        {
        }
    }
}
