using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MyApplication.Services.Interfaces;
using System;

namespace MyApplication.Services
{
    public class EmailService : IEmailService, IDisposable
    {
        private string SmtpAddress;
        private int SmtpPort;
        private string SmtpUser;
        private string SmtpEmail;
        private string SmtpAuth;

        private SmtpClient _smtp { get; set; }

        public EmailService(IConfiguration configuration)
        {
            // Configure these in appsettings.json
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
                if (_smtp == null)
                {
                    _smtp = new SmtpClient();
                    _smtp.Connect(SmtpAddress, SmtpPort);
                    _smtp.AuthenticationMechanisms.Remove("XOAUTH2");
                    _smtp.Authenticate(SmtpEmail, SmtpAuth);
                }
                return _smtp;
            }
        }

        public void Send(string receiver, string subject, string message)
        {
            Send(new MailboxAddress("", receiver), subject, message);
        }

        public void Send(MailboxAddress receiver, string subject, string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(SmtpUser, SmtpEmail));
            emailMessage.To.Add(receiver);
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("html") { Text = message };
            Send(emailMessage);
        }

        public void Send(MimeMessage email)
        {
            SmtpEmailClient.Send(email);
        }

        public void Dispose()
        {
            if (_smtp != null)
                _smtp.Dispose();
        }

    }
}
