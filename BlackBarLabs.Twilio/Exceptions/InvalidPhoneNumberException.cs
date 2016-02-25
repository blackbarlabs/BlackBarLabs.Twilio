using System;

namespace BlackBarLabs.Twilio.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message)
            :base(message)
        {
        }
    }
}
