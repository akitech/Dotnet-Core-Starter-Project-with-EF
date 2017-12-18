namespace MyApplication.Services.Interfaces
{
    public interface ISmsService
    {
        void Send(long number, string message);
    }
}
