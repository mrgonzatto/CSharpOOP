using System;
using System.Linq;
using ACM.BL.Interfaces;
using ACMWeb.Models;

namespace ACM.BL.EF
{
    public class EFAcmRepository : IAcmRepository
    {
        private ACMDbContext context;

        public EFAcmRepository(ACMDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
