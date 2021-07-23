using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using BlazorStudioManager.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BlazorStudioManager.Server.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IEmailConfiguration _emailConfiguration;

        public EmailSender(IEmailConfiguration emailConfiguration, IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            _emailConfiguration = emailConfiguration;
            Options = optionsAccessor.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync(string email, string subject, string message)
        {

            string emailFrom = Options.EmailUserName;
            string emailPassword = Options.EmailPassword;

            SmtpClient client = new SmtpClient("smtp.office365.com")
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(emailFrom, emailPassword),
                Port = 587,
                EnableSsl = true
            };

            MailMessage mailMessage = new MailMessage
            {
                IsBodyHtml = true,
                From = new MailAddress(emailFrom)
            };
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.Body = message;
            client.Send(mailMessage);

            return Task.CompletedTask;
        }

        //public Task SendEmailMessageAsync(EmailMessage emailMessage)
        //{
        //    string emailFrom = "support@ShowBuilder.net";
        //    string emailPassword = "Sds.71771";

        //    SmtpClient client = new SmtpClient("smtp.office365.com")
        //    {
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(emailFrom, emailPassword),
        //        Port = 587,
        //        EnableSsl = true
        //    };

        //    MailMessage mailMessage = new MailMessage
        //    {
        //        IsBodyHtml = true,
        //        From = new MailAddress(emailFrom)
        //    };

        //    foreach (var emailTo in emailMessage.ToAddresses)
        //    {
        //        mailMessage.To.Add(emailTo.ToString());
        //    }

        //    mailMessage.Subject = emailMessage.Subject;
        //    mailMessage.Body = emailMessage.Content;
        //    client.Send(mailMessage);

        //    return Task.CompletedTask;

        //}
    }
}
