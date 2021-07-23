using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStudioManager.Server.Services
{
    public class AuthMessageSenderOptions
    {
        public string EmailUserName { get; set; }
        public string EmailPassword { get; set; }
        public string EmailOutlookUserName { get; set; }
        public string EmailOutlookPassword { get; set; }

        //TwilioSettings
        public string accountSid { get; set; }
        public string authToken { get; set; }
        public string twilioPhonNumber { get; set; }
        public string testSecret { get; set; }
    }
}
