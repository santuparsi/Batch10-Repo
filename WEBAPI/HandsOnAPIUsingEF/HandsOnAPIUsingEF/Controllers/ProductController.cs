using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Entities;
using HandsOnAPIUsingEF.Repositories;
using Microsoft.AspNetCore.Cors;

namespace HandsOnAPIUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private IProductRepository _repository = null;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult Get()
        {
            List<Product> products = _repository.GetProducts();
            return Ok(products); //sending producs as responsone
        }
       
        [HttpGet]
        [Route("GetProductById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Product product = _repository.GetProduct(id);
                if (product != null)
                    return Ok(product);
                else
                    return Content("Invalid Id");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                _repository.Add(product);
                return Ok("Product Added"); //empty response
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("PlaceOrder")]
        public IActionResult AddOrder(Order order)
        {
            try
            {
                _repository.PlaceOrder(order);
                return Ok("Order is Placed");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("EditProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                _repository.Update(product);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}
