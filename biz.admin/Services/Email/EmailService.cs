using System;
using System.Net;
using System.Net.Mail;

namespace biz.admin.Services.Email
{
    public class EmailService: IEmailService
    {
        public string SendEmail(EmailModel email)
        {
            var response = "";
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "Smtp.Gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("erick@minimalist.mx", "minimalist2019");
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("no-reply@metalitec.com", "Metalitec");
                mailMessage.To.Add(email.To);
                mailMessage.Subject = email.Subject;
                mailMessage.IsBodyHtml = email.IsBodyHtml;
                mailMessage.Body = email.Body;
                smtpClient.Send(mailMessage);

                response = "Correo enviado";
            }
            catch (Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }
    }
}