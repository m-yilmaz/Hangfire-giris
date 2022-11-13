using Hangfire;
using HangFire.Web.Services;

namespace HangFire.Web.BackgroundJobs
{
    public class FireAndForgetJobs
    {

        public static void EmailSendToUserJob(string userId, string message)
        {
            // tek sefer çalışan işleri oluşturmak için kullanılır.
            // her bir job'u sql e kaydeder sonra çalıştırır.
            BackgroundJob.Enqueue<IEmailSender>(x => x.Send(userId, message));

        }
    }
}
