namespace efept.Services
{
    public interface ICorreoService
    {
        Task SendEmailAsync(string toEmail, string subject, string message);
    }
}
