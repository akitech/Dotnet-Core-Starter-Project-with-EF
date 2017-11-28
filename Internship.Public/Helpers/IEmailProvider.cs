namespace Internship.Public.Helpers
{
    public interface IEmailProvider
    {
        void Send(string email, string subject, string message, string replyTo = null);
    }
}
