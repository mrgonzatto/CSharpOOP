using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            // Cria uma instância de endereço
            Address address = new Address(addressId);

            // Código que retorna o endereço específico

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Fim da rua";
                address.StreetLine2 = "Casa da mãe";
                address.City = "Videira";
                address.State = "SC";
                address.Country = "Brasil";
                address.PostalCode = "00000-000";
            }

            return address;
        }

        public IEnumerable<Address> RetreiveByCustomerId(int customerId)
        { 
            var addressList = new List<Address>();
            
            Address address = new Address(1);            
            address.AddressType = 1;
            address.StreetLine1 = "Fim da rua";
            address.StreetLine2 = "Casa da mãe";
            address.City = "Videira";
            address.State = "SC";
            address.Country = "Brasil";
            address.PostalCode = "00000-000";
            addressList.Add(address);

            address = new Address(2);
            address.AddressType = 2;
            address.StreetLine1 = "Fim da rua";
            address.StreetLine2 = "Casa da mãe";
            address.City = "Videira";
            address.State = "SC";
            address.Country = "Brasil";
            address.PostalCode = "00000-000";
            addressList.Add(address);

            return addressList;
        }
        

        public bool Save(Address address)
        {
            return true;
        }

    }
}
