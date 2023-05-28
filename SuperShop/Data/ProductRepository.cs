using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class ProductRepository : GenericyRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
