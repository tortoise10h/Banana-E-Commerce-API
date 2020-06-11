using System.Net;
using System.Net.Mail;
using Banana_E_Commerce_API.Helpers;
using Microsoft.Extensions.Options;

namespace Banana_E_Commerce_API.Services
{
    public interface IEmailService
    {
        void SendMail(
            string toEmail,
            string toName,
            string subject,
            string body
        );
    }

    public class EmailService : IEmailService
    {
        private readonly IOptions<AppSettings> _appSettings;

        public EmailService(
            IOptions<AppSettings> appSettings
        )
        {
            _appSettings = appSettings;
        }

        public void SendMail(
            string toEmail,
            string toName,
            string subject,
            string body
        )
        {
            var fromAddress = new MailAddress(
                _appSettings.Value.ShopEmail,
                "Banana Boys Fruit Store");
            var toAddress = new MailAddress(toEmail, toName);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false
            };
            smtp.Credentials = new NetworkCredential(fromAddress.Address,
                    _appSettings.Value.ShopEmailPassword);
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                message.IsBodyHtml = true;
                smtp.Send(message);
            }
        }
    }
}