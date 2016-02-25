using System;

namespace BlackBarLabs.Twilio.Exceptions
{
    public class UnverifiedPhoneNumberException : Exception
    {
        public UnverifiedPhoneNumberException(string message)
            :base(message)
        {
        }
    }
}
