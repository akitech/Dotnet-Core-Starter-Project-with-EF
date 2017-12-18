using MimeKit;

namespace MyApplication.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(MimeMessage email);
        void Send(MailboxAddress email, string subject, string message);
        void Send(string email, string subject, string message);
    }
}
