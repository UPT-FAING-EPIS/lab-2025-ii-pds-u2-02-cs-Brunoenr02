namespace Notifications.Domain
{
    /// <summary>
    /// Representa un mensaje corto que puede ser enviado por diferentes medios. Valida la longitud antes de enviar.
    /// </summary>
    public class ShortMessage: AbstractMessage
    {
        /// <summary>
        /// Mensaje de error para mensajes que exceden la longitud permitida.
        /// </summary>
        public const string LARGE_ERROR_MESSAGE = "Unable to send the message as length > 10 characters";
        /// <summary>
        /// Inicializa una nueva instancia de <see cref="ShortMessage"/> con el objeto de envío especificado.
        /// </summary>
        /// <param name="messageSender">El objeto responsable de enviar el mensaje.</param>
        public ShortMessage(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }
        /// <summary>
        /// Envía el mensaje corto si cumple con la longitud permitida. Lanza excepción si excede el límite.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Cadena con el resultado del envío.</returns>
        /// <exception cref="ArgumentException">Se lanza si el mensaje excede la longitud permitida.</exception>
        public override string SendMessage(string Message)
        {
            if (Message.Length <= 25)
                return _messageSender.SendMessage(Message);
            else
                throw new ArgumentException(LARGE_ERROR_MESSAGE);
        }
    }
}