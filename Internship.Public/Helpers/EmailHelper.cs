using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;

namespace Internship.Public.Helpers
{
    public class EmailProvider : IDisposable
    {
        private string SmtpAddress;
        private int SmtpPort;
        private string SmtpUser;
        private string SmtpEmail;
        private string SmtpAuth;

        // Create a on-demand private field
        private SmtpClient _EmailClient { get; set; }

        public EmailProvider(IConfiguration configuration)
        {
            // Please configure these in appsettings.json
            SmtpAddress = configuration["EmailConfiguration:host"];
            SmtpPort = int.Parse(configuration["EmailConfiguration:port"]);
            SmtpUser = configuration["EmailConfiguration:user"];
            SmtpEmail = configuration["EmailConfiguration:email"];
            SmtpAuth = configuration["EmailConfiguration:auth"];
        }

        private SmtpClient SmtpEmailClient
        {
            get
            {
                if (_EmailClient == null)
                {
                    _EmailClient = new SmtpClient();
                    _EmailClient.Connect(SmtpAddress, SmtpPort);
                    _EmailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                    _EmailClient.Authenticate(SmtpEmail, SmtpAuth);
                }
                return _EmailClient;
            }
        }

        public void Send(string email, string subject, string message, string replyTo = null)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(SmtpUser, SmtpEmail));
            emailMessage.To.Add(new MailboxAddress("", email));

            if (replyTo != null)
                emailMessage.ReplyTo.Add(new MailboxAddress("", replyTo));

            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("html") { Text = message };
            SmtpEmailClient.Send(emailMessage);
        }

        public void Dispose()
        {
            if (_EmailClient != null)
                _EmailClient.Dispose();
        }

    }
}
