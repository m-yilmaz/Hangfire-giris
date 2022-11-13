namespace HangFire.Web.Services
{
    public interface IEmailSender
    {
       Task Send(string userId, string message);
    }
}
