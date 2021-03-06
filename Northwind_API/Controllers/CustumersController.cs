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
    public class CustumersController : ControllerBase
    {
        // GET: api/<CustumersController>
        [HttpGet]
        public List<Customer> Get()
        {
            var Custumers = new CustumersSC().GetCustumers().ToList();
            return Custumers;
        }

        // GET api/<CustumersController>/5
        [HttpGet("{id}")]
        public Customer Get(string id)
        {
            return new CustumersSC().GetCustomerById(id);
        }

        // POST api/<CustumersController>
        [HttpPost]
        public void Post([FromBody] CustumerModel newCustumer)
        {
            new CustumersSC().AddCustomer(newCustumer);
        }

        // PUT api/<CustumersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustumersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            new CustumersSC().DeleteCustomerById(id);
            return Ok();
        }
        #region helpers
        private IActionResult ThrowInternalErrorException(Exception ex)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
