namespace Notifications.Domain
{
    /// <summary>
    /// Define la interfaz para el envío de mensajes por diferentes medios.
    /// </summary>
    public interface IMessageSender
    {
        /// <summary>
        /// Envía el mensaje especificado por el medio implementado.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Cadena con el resultado del envío.</returns>
        string SendMessage(string Message);
    }
}