namespace Notifications.Domain
{
    /// <summary>
    /// Implementa el envío de mensajes utilizando correo electrónico.
    /// </summary>
    public class EmailMessageSender : IMessageSender
    {
        /// <summary>
        /// Envía el mensaje especificado por correo electrónico.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Cadena indicando que el mensaje fue enviado por email.</returns>
        public string SendMessage(string Message)
        {
            return "'" + Message + "'   : This Message has been sent using Email";
        }
    }
}