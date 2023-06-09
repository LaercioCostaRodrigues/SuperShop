using SuperShop.Data.Entities;
using System.Linq;

namespace SuperShop.Data
{
    public interface IProductRepository : IGenericyRepository<Product>
    {
        public IQueryable GetAllWithUsers();
    }
}
