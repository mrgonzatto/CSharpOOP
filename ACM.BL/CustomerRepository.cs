
using System.Collections.Generic;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {

        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository(); // Relacionamento de colaboração
        }

        public Customer Retrieve(int customerId)
        { 
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetreiveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Retorna todos os clientes
        /// </summary>
        /// <returns>Lista de Clientes</returns>
        public List<Customer> Retrieve() // Overloading = Sobrescrita de métodos que possuem o mesmo nome com parâmetros diferentes
        {
            // Implementação do código que carrega todos os clientes

            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
