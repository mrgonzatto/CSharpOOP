using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; } // Utiliza Data Tempo e Fuso Horário
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddresId { get; set; }

        // Herança -> Sobrescrita de métodos
        // Aqui também vemos a atuação do polimorfismo, já que o objeto herda de Object, cada um dos objetos
        // que implementa este método terá um comportamento específico para sua instância.
        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
