using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        
        public ProductRepository()
        {
        }
        public List<Product> GetAllProducts()
        {
            using (var dbContext = new mockdbEntities())
            {
                return dbContext.Products.ToList();
            }
        }
    }
}
