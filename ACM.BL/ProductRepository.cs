using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retorna um produto
        /// </summary>
        /// <param name="productId">Id</param>
        /// <returns>Produto</returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Vodka";
                product.ProductDescription = "Vodka Smirnoff 1L";
                product.CurrentPrice = 15.96M;
            }

            //Herança: Observe a herança de Object->Product->ToString()
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            Console.WriteLine($"Product: {product.EntityState.ToString()}");
            Console.WriteLine($"Product: {product.HasChanges}");
            Console.WriteLine($"Product: {product.IsValid}");



            return product;
        }

        /// <summary>
        /// Salva o produto atual
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Insert
                    }
                    else
                    {
                        // Update
                    }
                }
                else                 
                    success = false;                
            }
            return success;
        }
    }
}
