using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackBarLabs.Twilio.Tests
{
    [TestClass]
    public class MessengerTest
    {
        [Ignore]
        [TestMethod]
        public void SendEmail()
        {
            var accountSid = System.Configuration.ConfigurationManager.AppSettings["Twilio.AccountSid"];
            var authToken = System.Configuration.ConfigurationManager.AppSettings["Twilio.AuthToken"];
            var fromNumber = System.Configuration.ConfigurationManager.AppSettings["Twilio.TestFromNumber"];
            var toNumber = System.Configuration.ConfigurationManager.AppSettings["Twilio.TestToNumber"];
            var messenger = new Messenger(accountSid, authToken);
            messenger.SendSmsMessage(fromNumber, toNumber, "Check us out at http://www.eastfive.com");
        }
    }
}
