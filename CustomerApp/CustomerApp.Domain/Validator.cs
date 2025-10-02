namespace CustomerApp.Domain
{
    /// <summary>
    /// Proporciona métodos para validar los datos de un cliente antes de su registro.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Valida los campos obligatorios de un cliente. Lanza excepción si algún campo es inválido.
        /// </summary>
        /// <param name="customer">El cliente a validar.</param>
        /// <returns>True si el cliente es válido.</returns>
        public bool ValidateCustomer(Customer customer)
        {
            //Need to Validate the Customer Object
            if (string.IsNullOrEmpty(customer.Name)) throw new ArgumentException("Name can't be null or empty");
            if (string.IsNullOrEmpty(customer.Email)) throw new ArgumentException("Email can't be null or empty");
            if (string.IsNullOrEmpty(customer.MobileNumber)) throw new ArgumentException("MobileNumber can't be null or empty");
            if (string.IsNullOrEmpty(customer.Address)) throw new ArgumentException("Address can't be null or empty");
            return true;
        }
    }
}