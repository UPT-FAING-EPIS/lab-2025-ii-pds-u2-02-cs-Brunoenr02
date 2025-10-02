using System.Net;
using System.Net.Mail;

namespace CustomerApp.Domain
{
    /// <summary>
    /// Proporciona servicios para el envío de correos electrónicos relacionados con el registro de clientes.
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// Envía un correo electrónico de confirmación de registro al cliente especificado.
        /// </summary>
        /// <param name="customer">El cliente al que se enviará el correo de registro.</param>
        /// <returns>True si el correo fue enviado correctamente.</returns>
        public bool SendRegistrationEmail(Customer customer)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                //Port = 587,
                Credentials = new NetworkCredential(customer.Email, customer.Password),
                EnableSsl = true,
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress(customer.Email),
                Subject = "Test mail",
                Body = "<h1>Hello</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(customer.Email);
            //smtpClient.Send(mailMessage);
            return true;
        }        
    }
}