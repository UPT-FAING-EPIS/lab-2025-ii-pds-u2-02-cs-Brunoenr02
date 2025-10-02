namespace CustomerApp.Domain
{
    /// <summary>
    /// Simula el acceso a la base de datos para almacenar y gestionar clientes.
    /// </summary>
    public class DataAccessLayer
    {
        /// <summary>
        /// Lista de clientes almacenados en memoria.
        /// </summary>
        public List<Customer> Customers { get; set; }
        /// <summary>
        /// Inicializa una nueva instancia de <see cref="DataAccessLayer"/> y la lista de clientes.
        /// </summary>
        public DataAccessLayer()
        {
            Customers = new List<Customer>();
        }
        /// <summary>
        /// Guarda un cliente en la lista simulando el almacenamiento en base de datos.
        /// </summary>
        /// <param name="customer">El cliente a guardar.</param>
        /// <returns>True si el cliente fue guardado correctamente.</returns>
        public bool SaveCustomer(Customer customer)
        {
            Customers.Add(customer);
            return true;
        }        
    }
}