using SendGrid;
using SendGrid.Helpers.Mail;
using System;

namespace FIT5032_Week08A.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "FIT5032 Example Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = contents;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }
}