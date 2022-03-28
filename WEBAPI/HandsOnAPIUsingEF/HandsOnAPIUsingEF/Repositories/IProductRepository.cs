using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Entities;
namespace HandsOnAPIUsingEF.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void Add(Product product);
        void Delete(int id);
        void Update(Product product);
        void PlaceOrder(Order order);
    }
}
