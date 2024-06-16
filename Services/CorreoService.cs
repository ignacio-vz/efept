using System.Net.Mail;
using System.Net;

namespace efept.Services
{
    public class CorreoService : ICorreoService
    {
        public IConfiguration Configuration { get; }
        public CorreoService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            var smtpClient = new SmtpClient(Configuration["Smtp:Server"], int.Parse(Configuration["Smtp:Port"]!))
            {
                Credentials = new NetworkCredential(Environment.GetEnvironmentVariable("Smtp_Username"), Environment.GetEnvironmentVariable("Smtp_Password")),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(Environment.GetEnvironmentVariable("Smtp_Username")!),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };

            mailMessage.To.Add(toEmail);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
