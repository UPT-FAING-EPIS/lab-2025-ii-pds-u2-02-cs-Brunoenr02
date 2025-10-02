namespace Notifications.Domain
{
    /// <summary>
    /// Representa un mensaje largo que puede ser enviado por diferentes medios.
    /// </summary>
    public class LongMessage: AbstractMessage
    {
        /// <summary>
        /// Inicializa una nueva instancia de <see cref="LongMessage"/> con el objeto de envío especificado.
        /// </summary>
        /// <param name="messageSender">El objeto responsable de enviar el mensaje.</param>
        public LongMessage(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }
        /// <summary>
        /// Envía el mensaje largo utilizando el objeto de envío configurado.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Cadena con el resultado del envío.</returns>
        public override string SendMessage(string Message)
        {
           return _messageSender.SendMessage(Message);
        }
    }
}