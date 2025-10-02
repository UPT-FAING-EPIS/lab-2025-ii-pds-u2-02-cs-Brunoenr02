namespace CustomerApp.Domain
{
    /// <summary>
    /// Representa un cliente con información personal y credenciales de acceso.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Nombre completo del cliente.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Dirección de correo electrónico del cliente.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Número de teléfono móvil del cliente.
        /// </summary>
        public string MobileNumber { get; set; }
        /// <summary>
        /// Dirección física del cliente.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Contraseña utilizada para autenticación del cliente.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Crea una nueva instancia de <see cref="Customer"/> con los datos proporcionados.
        /// </summary>
        /// <param name="name">Nombre completo del cliente.</param>
        /// <param name="email">Correo electrónico del cliente.</param>
        /// <param name="mobileNumber">Número de teléfono móvil.</param>
        /// <param name="address">Dirección física.</param>
        /// <param name="password">Contraseña para autenticación.</param>
        /// <returns>Instancia de <see cref="Customer"/> inicializada.</returns>
        public static Customer Create(string name, string email, string mobileNumber, string address, string password)
        {
            return new Customer() {
                Name = name, Email = email, MobileNumber = mobileNumber, Address = address, Password = password
            };
        }
    }
}