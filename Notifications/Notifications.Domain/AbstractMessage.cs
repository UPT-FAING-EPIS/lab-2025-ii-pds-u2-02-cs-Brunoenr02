namespace Notifications.Domain
{
    /// <summary>
    /// Clase base abstracta para mensajes que pueden ser enviados por diferentes medios.
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// Referencia al objeto responsable de enviar el mensaje.
        /// </summary>
        protected IMessageSender _messageSender;
        /// <summary>
        /// Envía el mensaje utilizando el método definido en la subclase.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Cadena con el resultado del envío.</returns>
        public abstract string SendMessage(string Message);        
    }
}