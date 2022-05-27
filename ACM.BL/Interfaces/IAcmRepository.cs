using System.Linq;

namespace ACM.BL.Interfaces
{
    public interface IAcmRepository
    {
        IQueryable<Product> Products { get; }
    }
}
