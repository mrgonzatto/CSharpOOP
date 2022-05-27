
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        /// <summary>
        /// Construtor padrão, sem parâmetros
        /// </summary>
        public Customer() : this(0) // Encadeamento de construtores
        {

        }

        /// <summary>
        /// Construtor para inicializar customerId que é private
        /// </summary>
        /// <param name="customerId"></param>
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; } // Propriedade auto-implementada

        private string _lastName;
        public string LastName // Propriedade C#
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName; 
            }
        }

        /*
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; } 
        */
        public List<Address> AddressList { get; set; } // Composição

        // Um atributo static é definido como pertencente à classe e não a uma instância de objeto do tipo desta classe
        public static int InstanceCount { get; set; }

        //------------------------------------------------------------

        /// <summary>
        /// Validação dos dados do cliente
        /// </summary>
        /// <returns>Válido?</returns>
        public bool Validate()
        {
            var isValid = true;

            if( string.IsNullOrWhiteSpace(LastName) ) isValid = false;
            if( string.IsNullOrWhiteSpace(EmailAddress) ) isValid = false;

            return isValid;
        }

        //------------------------------------------------------------
    }
}
