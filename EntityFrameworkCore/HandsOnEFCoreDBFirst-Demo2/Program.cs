using System;
using HandsOnEFCoreDBFirst_Demo2.Entities;
using System.Collections.Generic;
using System.Linq;
namespace HandsOnEFCoreDBFirst_Demo2
{
    class ProductRepository
    {
        private readonly Batch10DBContext db;
        public ProductRepository()
        {
            this.db = new Batch10DBContext();
        }
        public  void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges(); //to save the data in table
        }
        public Product GetProduct(int id) //Get Product By Id
        {
            //Product product = db.Products.Find(id);
            //Product product = (from p in db.Products where p.ProductId == id select p).Single();
            Product product = db.Products.Single(p => p.ProductId == id);
            return product;

        }
        //public List<Product> GetProducts(double price)
        //{
        //    //Get All the Products
        //    List<Product> products = db.Products.Where(p => p.Price > price).ToList();
        //    return products;
        //}
        public List<Product> GetProducts()
        {
            //Get All the Products
            List<Product> products = db.Products.ToList();
            return products;
        }
        public void Delete(int pid)
        {
            Product product = db.Products.Find(pid); //Delete Product
            db.Products.Remove(product);
            db.SaveChanges();

        }
        public void EditProduct(Product editProduct) //Edit Product
        {
            db.Products.Update(editProduct);
            db.SaveChanges();
        }
        public void PlaceOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("1.AddProduct");
                    Console.WriteLine("2.GetProduct");
                    Console.WriteLine("3.GetAll");
                    Console.WriteLine("4.DeleteProduct");
                    Console.WriteLine("5.EditProduct");
                    Console.WriteLine("6.PlaceOrder");
                    Console.WriteLine("Enter Choice");
                    int ch = int.Parse(Console.ReadLine());
                    ProductRepository repository = new ProductRepository();
                    switch (ch)
                    {
                        case 1:
                            {
                                Product product = new Product();
                                Console.WriteLine("Enter ProductName");
                                product.ProductName = Console.ReadLine();
                                Console.WriteLine("Enter Product Price");
                                product.Price = double.Parse(Console.ReadLine());
                                repository.AddProduct(product);
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Enter Id");
                                int id = int.Parse(Console.ReadLine());
                                Product product = repository.GetProduct(id);
                                Console.WriteLine($"Id: {product.ProductId} Name: {product.ProductName} Price: {product.Price}");
                            }
                            break;
                        case 3:
                            {
                                foreach (Product product in repository.GetProducts())
                                {
                                    Console.WriteLine($"Id: {product.ProductId} Name: {product.ProductName} Price: {product.Price}");
                                }
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Enter Id");
                                int id = int.Parse(Console.ReadLine());
                                repository.Delete(id);

                            }
                            break;
                        case 5:
                            {
                                Product product = new Product();
                                Console.WriteLine("Enter ProductId");
                                product.ProductId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter ProductName");
                                product.ProductName = Console.ReadLine();
                                Console.WriteLine("Enter Product Price");
                                product.Price = double.Parse(Console.ReadLine());
                                repository.EditProduct(product);
                            }
                            break;
                        case 6:
                            {
                                Order placeOrder = new Order();
                                Console.WriteLine("Enter Product id");
                                placeOrder.ProductId = int.Parse(Console.ReadLine());
                                placeOrder.OrderDate = DateTime.Now;
                                repository.PlaceOrder(placeOrder);
                                Console.WriteLine("Order Successfull");
                            }
                            break;

                    }
                } while (true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
