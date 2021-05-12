using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BACKEND_TAREA3.Backend;
using BACKEND_TAREA3.DataAccess;
using BACKEND_TAREA3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Northwind_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //GET PRODUCT
        // GET: api/<ProductsController>
        [HttpGet]
        public List<Product> Get()
        {
            var Products = new ProductsSC().GetProduct().ToList();
            return Products;
        }

        //GET PRODUCT BY ID 
        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public  Product Get(int id)
        {
            return new ProductsSC().GetProductByID(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] ProductModel newProduct)
        {
            new ProductsSC().AddProduct(newProduct);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(ProductModel ProductId)
        {
            try
            {
                new ProductsSC().DeleteProduct(ProductId);
                return Ok();
            }
            catch (Exception ex)
            {
                return ThrowInternalErrorException(ex);
            }
           
        }

        #region helpers
        private IActionResult ThrowInternalErrorException(Exception ex)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
