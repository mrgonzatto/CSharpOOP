using System.ComponentModel.DataAnnotations.Schema;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int produtctId)
        {
            ProductId = produtctId;
        }

        //----------

        [Column(TypeName = "decimal(8,2)")]
        public decimal? CurrentPrice { get; set; } //? = nullable type possibilita valor nulo
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        //----------

        public override string ToString() => ProductName;

        /// <summary>
        /// Valida propriedades do produto
        /// </summary>
        /// <returns>É válido?</returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if(CurrentPrice == null) isValid = false;

            return isValid;
        }
        
    }
}
