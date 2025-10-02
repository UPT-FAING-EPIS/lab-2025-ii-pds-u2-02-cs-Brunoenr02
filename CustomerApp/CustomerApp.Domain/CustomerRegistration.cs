using CustomerApp.Domain;

/// <summary>
/// Gestiona el proceso de registro de clientes, incluyendo validación, almacenamiento y notificación por correo electrónico.
/// </summary>
public class CustomerRegistration
{
    /// <summary>
    /// Registra un nuevo cliente realizando validación, guardado en base de datos y envío de correo de confirmación.
    /// </summary>
    /// <param name="customer">El objeto <see cref="Customer"/> a registrar.</param>
    /// <returns>True si el registro fue exitoso.</returns>
    public bool RegisterCustomer(Customer customer)
    {
        //Step1: Validate the Customer
        Validator validator = new Validator();
        bool IsValid = validator.ValidateCustomer(customer);
        //Step1: Save the Customer Object into the database
        DataAccessLayer customerDataAccessLayer = new DataAccessLayer();
        bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);
        //Step3: Send the Registration Email to the Customer
        EmailService email = new EmailService();
        email.SendRegistrationEmail(customer);
        return true;
    }
}