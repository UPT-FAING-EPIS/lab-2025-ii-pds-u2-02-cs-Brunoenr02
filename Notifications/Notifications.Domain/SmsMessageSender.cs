namespace Notifications.Domain
{
    /// <summary>
    /// Implementa el envío de mensajes utilizando SMS.
    /// </summary>
    public class SmsMessageSender : IMessageSender
    {
        /// <summary>
        /// Envía el mensaje especificado por SMS.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Cadena indicando que el mensaje fue enviado por SMS.</returns>
        public string SendMessage(string Message)
        {
            return "'" + Message + "' : This Message has been sent using SMS";
        }
    }
}