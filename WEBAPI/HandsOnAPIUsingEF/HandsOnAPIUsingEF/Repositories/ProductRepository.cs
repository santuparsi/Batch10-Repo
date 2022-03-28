using HandsOnAPIUsingEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.DBContext;
namespace HandsOnAPIUsingEF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private MyContext _context = null;
        public ProductRepository(MyContext context)
        {
            _context = context;
        }
        public void Add(Product product) //add new product
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id) //delete product by id
        {
            Product product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Product GetProduct(int id) //get product by id
        {
          return _context.Products.Find(id);
        }

        public List<Product> GetProducts() //get all the products
        {
            return _context.Products.ToList();
        }

        public void PlaceOrder(Order order) //place order
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
