using SendGrid.Helpers.Mail;
using SendGrid;

namespace HangFire.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Send(string userId, string message)
        {
            var apiKey = _configuration.GetSection("APIs")["SendGridApi"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("******", "Example User");
            var subject = "www.mysite.com bilgilendirme";
            var to = new EmailAddress("(******,", "Example User");
            //var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>Site kuralları</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, null, htmlContent);
            await client.SendEmailAsync(msg);
        }
    }
}
