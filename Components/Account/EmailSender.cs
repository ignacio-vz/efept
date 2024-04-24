using efept.Data;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;
using System.Net;

namespace efept.Components.Account
{
    public class EmailSender : IEmailSender<ApplicationUser>
    {
        private readonly string SmtpServer;
        private readonly int SmtpPort;
        private readonly string SmtpUsername;
        private readonly string SmtpPassword;

        public EmailSender(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword)
        {
            SmtpServer = smtpServer;
            SmtpPort = smtpPort;
            SmtpUsername = smtpUsername;
            SmtpPassword = smtpPassword;
        }

        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
        {
            return SendEmailAsync(email, "Confirm your email", $"Please confirm your email by clicking this link: <a href=\"{confirmationLink}\">{confirmationLink}</a>");
        }

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
        {
            return SendEmailAsync(email, "Reset your password", $"Please reset your password by entering this code: {resetCode}");
        }

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
        {
            return SendEmailAsync(email, "Reset your password", $"Please reset your password by clicking this link: <a href=\"{resetLink}\">{resetLink}</a>");
        }

        private async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            var smtpClient = new SmtpClient(SmtpServer, SmtpPort)
            {
                Credentials = new NetworkCredential(SmtpUsername, SmtpPassword),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(SmtpUsername),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };

            mailMessage.To.Add(toEmail);

            await smtpClient.SendMailAsync(mailMessage);

        }
    }
}
